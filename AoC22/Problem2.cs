namespace AoC22
{
    namespace Problem2
    {
        public class Problem2: IProblem<long>
        {
            public const long win = 6, lose = 0, draw = 3;

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
                        score += draw;
                    }
                    else if (b == "Y")
                    {
                        score += win;
                    }
                    else if (b == "Z")
                    {
                        score += lose;
                    }
                } else if (a == "B")
                {
                    // paper
                    if (b == "X")
                    {
                        score += lose;
                    }
                    else if (b == "Y")
                    {
                        score += draw;
                    }
                    else if (b == "Z")
                    {
                        score += win;
                    }
                } else if (a == "C")
                {
                    // Scissors
                    if (b == "X")
                    {
                        score += win;
                    }
                    else if (b == "Y")
                    {
                        score += lose;
                    }
                    else if (b == "Z")
                    {
                        score += draw;
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
                    "X" => lose,
                    "Y" => draw,
                    "Z" => win,
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
