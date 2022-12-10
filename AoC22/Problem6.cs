using System.Runtime.CompilerServices;

namespace AoC22
{
    namespace Problem6
    {
        public class Problem6: IProblem<long>
        {
            public long Helper(string input, int packetLength)
            {
                var i = 0;
                var heap = new List<char>();
                while (i < input.Length)
                {
                    var item = input[i];

                    if (heap.Contains(item))
                    {
                        var idx = heap.IndexOf(item);
                        for (var j = 0; j <= idx; j++)
                        {
                            heap.RemoveAt(0);
                        }
                    }
                    heap.Add(item);
                    ++i;
                    
                    if (heap.Count == packetLength)
                    {
                        break;
                    }
                }

                return i;
            } 
            public long Solve(string input)
            {
                return Helper(input, 4);
            }

            public long Solve2(string input)
            {
                return Helper(input, 14);
            }
        }        
    }
}


