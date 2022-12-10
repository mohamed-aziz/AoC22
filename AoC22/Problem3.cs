using System.Diagnostics;

namespace AoC22
{
    namespace Problem3
    {
        public class Problem3: IProblem<long>
        {
            private long GetPriority(Char item)
            {

                var code = (int)item; 
                if (code >= 97)
                {
                    return code - 96;
                }

                return code - 64 + 26;

            }
            public long Solve(string input)
            {
                long score = 0;
                foreach (var rucksack in input.Split(Environment.NewLine))
                {
                    Debug.Assert(rucksack.Length % 2 == 0);
                    var rucksackLen = rucksack.Length / 2; 
                    var firstCompartment = new HashSet<char>(rucksack.Substring(0, rucksackLen ));
                    var secondCompartment = new HashSet<char>(rucksack.Substring(rucksackLen));

                    IEnumerable<char> intersection = from c in firstCompartment
                        where secondCompartment.Contains(c)
                        select c;

                    score += intersection.Select(GetPriority).Sum();
                }

                return score;
            }

            public long Solve2(string input)
            {
                long score = 0;
                foreach (var group in input.Split(Environment.NewLine).Chunk(3))
                {

                    var firstSack = new HashSet<char>(group[0]);
                    var secondSack = new HashSet<char>(group[1]);
                    var thirdSack = new HashSet<char>(group[2]);

                    IEnumerable<char> intersection = from c in firstSack
                        where secondSack.Contains(c) && thirdSack.Contains(c)
                        select c;

                    score += intersection.Select(GetPriority).Sum();
                }

                return score;
            }
        }        
    }
}

