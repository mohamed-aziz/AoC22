using System.Text.RegularExpressions;

namespace AoC22
{
    namespace Problem5
    {
        public class Move
        {
            
        }
        
        public class Problem5: IProblem<string>
        {
            private List<Stack<char>> GetStacks(string input)
            {
                var transposedString = "";

                var stacks = new List<Stack<char>>();
                var matches = new Regex(@"\[([A-Z])\]", RegexOptions.Singleline).Matches(input);

                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
                return stacks;
            } 
            
            
            public string Solve(string input)
            {
                var crates = new List<Stack<char>>();
                GetStacks(input);

                return "";
            }

            public string Solve2(string input)
            {
                throw new NotImplementedException();
            }
        }         
    }
}

