using System.Text.RegularExpressions;

namespace AoC22
{
    namespace Problem7
    {
        public enum EntryType
        {
            File,
            Folder
        }
        // copied from ChatGPT
        public class TreeNode
        {
            public int Value { get; set; }
            
            public string DirectoryName { get; set; }
            
            public EntryType Type { get; set; }
            
            public List<TreeNode> Children { get; set; }

            public TreeNode(int value, string directoryName, EntryType entryType)
            {
                this.Value = value;
                this.DirectoryName = directoryName;
                this.Type = entryType;
                this.Children = new List<TreeNode>();
            }
            
        }
        
        public class Tree
        {
            public TreeNode Root { get; set; }

            public Tree(TreeNode root)
            {
                this.Root = root;
            }
            
        }

        public abstract class TreeFactory
        {
            public static Tree CreateTree(string input)
            {
                var node = new TreeNode(-1, "/", EntryType.Folder);
                var dirStack = new Stack<TreeNode>(new []{node});
                Tree fileTree = new Tree(node);
                
                foreach (var line in input.Split(Environment.NewLine))
                {
                    if (line.Contains("$ cd"))
                    {
                        var matches = new Regex(@"\$ cd ([A-Za-z\./]+)").Matches(line);
                        var cwd = matches[0].Groups[1].Value;
                        if (cwd == "..")
                        {
                            node = dirStack.Pop();
                        }
                        else
                        {
                            var newNode = new TreeNode(-1, cwd, EntryType.Folder);
                            dirStack.Push(node);
                            node.Children.Add(newNode);
                            node = newNode;
                        }
                    }
                    else if (line[0] != '$')
                    {
                        // if it's dir I don't care only if it's accessed
                        var re = new Regex(@"^(\d+) (.+)$");
                        if (!re.IsMatch(line))
                        {
                            continue;
                        }

                        var matches = re.Matches(line);
                        var filename = matches[0].Groups[2].Value;
                        var size = int.Parse(matches[0].Groups[1].Value);
                        
                        node.Children.Add(new TreeNode(size, filename, EntryType.File));
                    }
                }

                return fileTree;
                
            }
        }

        public class Problem7: IProblem<long>
        {

            private int UpdateTreeWeights(TreeNode node)
            {
                int size = 0;
                foreach (var childNode in node.Children)
                {
                    if (childNode.Type == EntryType.File)
                    {
                        size += childNode.Value;
                    } else if (childNode.Type == EntryType.Folder)
                    {
                        size += UpdateTreeWeights(childNode);
                    }
                }
                
                node.Value = size;
                return size;
            }

            private int FindAtMost100000(TreeNode node)
            {

                var dirSize = 0;
                if (node.Value <= 100000)
                {
                    dirSize += node.Value;    
                }
                
                
                foreach (var childNode in node.Children)
                {
                    if (childNode.Type == EntryType.Folder)
                    {
                        dirSize += FindAtMost100000(childNode);
                    }
                }

                return dirSize;
            }

            private int FindSmallestDelete(TreeNode node, int requiredSpace)
            {
                var dirSize = Int32.MaxValue;
                if (node.Value >= requiredSpace)
                {
                    dirSize = node.Value;
                }
                
                foreach (var childNode in node.Children)
                {
                    if (childNode.Type == EntryType.Folder)
                    {
                        dirSize = Math.Min(dirSize, FindSmallestDelete(childNode, requiredSpace));
                    }
                }

                return dirSize;
            }
            
            public long Solve(string input)
            {
                var tree = TreeFactory.CreateTree(input);
                UpdateTreeWeights(tree.Root);
                
                return FindAtMost100000(tree.Root);
            }

            public long Solve2(string input)
            {
                var tree = TreeFactory.CreateTree(input);
                UpdateTreeWeights(tree.Root);

                var requiredSpace = 30000000 - (70000000 - tree.Root.Value);
                return FindSmallestDelete(tree.Root, requiredSpace);
            }
        }        
    }
}

