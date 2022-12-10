namespace AoC22
{
    namespace Problem4
    {
        public class Problem4: IProblem<long>
        {
            public long Solve(string input)
            {
                var score = 0;
                foreach (var pairs in input.Split(Environment.NewLine))
                {
                    var splitPairs = pairs.Split(',').Select(x => x.Split('-').Select(int.Parse).ToArray()).ToArray();
                    var (pair11, pair12, pair21, pair22) = (splitPairs[0][0], splitPairs[0][1], splitPairs[1][0], splitPairs[1][1]);

                    if ((pair11 <= pair21 && pair12 >= pair22) || (pair21 <= pair11 && pair22 >= pair12))
                    {
                        score++;
                    }
                }

                return score;
            }

            public long Solve2(string input)
            {
                var score = 0;
                foreach (var pairs in input.Split(Environment.NewLine))
                {
                    var splitPairs = pairs.Split(',').Select(x => x.Split('-').Select(int.Parse).ToArray()).ToArray();
                    var (pair11, pair12, pair21, pair22) = (splitPairs[0][0], splitPairs[0][1], splitPairs[1][0], splitPairs[1][1]);
                    if ((pair11 <= pair21 && pair21 <= pair12) || (pair11 <= pair22 && pair22 <= pair12) || (pair21 <= pair11 && pair11 <= pair22) || (pair21 <= pair12 && pair12 <= pair22))
                    {
                        score++;
                    }
                }

                return score;
            }
        }        
    }
}

