using System.Runtime.CompilerServices;

namespace AoC22
{
    namespace Problem1
    {
        public class Problem1 : IProblem<long>
        {
            private static IEnumerable<long> Helper(String input)
            {
                return input.Split(Environment.NewLine + Environment.NewLine)
                    .Select(b => b.Split(Environment.NewLine).Select(Int64.Parse).Sum());
            }
            public long Solve(String input)
            {
                return Helper(input).Max();
            }

            public long Solve2(string input)
            {
                return Helper(input).OrderByDescending(x => x).Take(3).Sum();
            }
        }
    }
}