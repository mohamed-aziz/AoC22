using System.Text.RegularExpressions;

namespace AoC22
{
    namespace Problem5
    {
        public class Move
        {
            public int Number { get; init; }
            public int From { get; init; }
            public int To { get; init; }
        }

        public abstract class MovesFactory
        {
            public static List<Move> GetMoves(string input)
            {
                var moves = new List<Move>();
                foreach (var line in input.Split(Environment.NewLine))
                {
                    var matches = new Regex(@"^move (\d+) from (\d+) to (\d+)$").Matches(line);
                    matches.ToList().ForEach(m => moves.Add(new Move
                    {
                        Number = int.Parse(m.Groups[1].Value),
                        From = int.Parse(m.Groups[2].Value),
                        To = int.Parse(m.Groups[3].Value)
                    }));
                }
                
                return moves;
            }
        }
        
        public class Problem5
        {

            public string Solve(List<Stack<Char>> stacks, List<Move> moves)
            {
                foreach (var move in moves)
                {
                    for (var i = 0; i < move.Number; i++)
                    {
                        var item = stacks[move.From - 1].Pop();
                        stacks[move.To - 1].Push(item);
                    }
                }
                
                return string.Join("", stacks.Select(s => s.Count != 0 ? s.Peek().ToString() : ""));
            }

            public string Solve2(List<Stack<Char>> stacks, List<Move> moves)
            {
                foreach (var move in moves)
                {
                    var intermediateStack = new Stack<char>();
                    for (var i = 0; i < move.Number; i++)
                    {
                        var item = stacks[move.From - 1].Pop();
                        intermediateStack.Push(item);
                    }

                    while (intermediateStack.Count != 0)
                    {
                        var item = intermediateStack.Pop();
                        stacks[move.To - 1].Push(item);    
                    }
                }
                
                return string.Join("", stacks.Select(s => s.Count != 0 ? s.Peek().ToString() : ""));
            }
        }         
    }
}

