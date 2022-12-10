namespace AoC22
{
    namespace Problem2
    {
        public class Problem2: IProblem<long>
        {
            private const long Win = 6;
            private const long Lose = 0;
            public const long Draw = 3;

            public long GetPlayScore(String a)
            {
                return a switch
                {
                    "X" => 1,
                    "Y" => 2,
                    "Z" => 3,
                    _ => throw new ArgumentException("Invalid input", a)
                };
            }
            
            private long GetScore(String a, String b)
            {
                long score = GetPlayScore(b);
                if (a == "A")
                {
                    // rock
                    if (b == "X")
                    {
                        score += Draw;
                    }
                    else if (b == "Y")
                    {
                        score += Win;
                    }
                    else if (b == "Z")
                    {
                        score += Lose;
                    }
                } else if (a == "B")
                {
                    // paper
                    if (b == "X")
                    {
                        score += Lose;
                    }
                    else if (b == "Y")
                    {
                        score += Draw;
                    }
                    else if (b == "Z")
                    {
                        score += Win;
                    }
                } else if (a == "C")
                {
                    // Scissors
                    if (b == "X")
                    {
                        score += Win;
                    }
                    else if (b == "Y")
                    {
                        score += Lose;
                    }
                    else if (b == "Z")
                    {
                        score += Draw;
                    }
                }

                return score;
            }
            public long Solve(string input)
            {
                var scores = new List<long>();
                foreach (var line in input.Split(Environment.NewLine))
                {
                    var (x, y) = line.Split(' ') switch
                    {
                        var a => (a[0], a[1])
                    };
                    scores.Add(GetScore(x, y));
                }
                
                return scores.Sum();
            }

            
            private long GetScore2(String a, String b)
            {
                long score = b switch
                {
                    "X" => Lose,
                    "Y" => Draw,
                    "Z" => Win,
                    _ => throw new ArgumentException("Invalid input", a)
                };
                
                if (a == "A")
                {
                    // rock
                    if (b == "X")
                    {
                        score += GetPlayScore("Z");
                    }
                    else if (b == "Y")
                    {
                        score += GetPlayScore("X");
                    }
                    else if (b == "Z")
                    {
                        score += GetPlayScore("Y");
                    }
                } else if (a == "B")
                {
                    // paper
                    if (b == "X")
                    {
                        score += GetPlayScore("X");
                    }
                    else if (b == "Y")
                    {
                        score += GetPlayScore("Y");
                    }
                    else if (b == "Z")
                    {
                        score += GetPlayScore("Z");
                    }
                } else if (a == "C")
                {
                    // Scissors
                    if (b == "X")
                    {
                        score += GetPlayScore("Y");
                    }
                    else if (b == "Y")
                    {
                        score += GetPlayScore("Z");
                    }
                    else if (b == "Z")
                    {
                        score += GetPlayScore("X");
                    }
                }

                return score;
            }
            
            public long Solve2(string input)
            {
                var scores = new List<long>();
                foreach (var line in input.Split(Environment.NewLine))
                {
                    var (x, y) = line.Split(' ') switch
                    {
                        var a => (a[0], a[1])
                    };
                    scores.Add(GetScore2(x, y));
                }
                
                return scores.Sum();
            }
        }        
    }
}
