using AoC22.Problem5;

namespace Tests;

[TestFixture]
public class TestProblem5
{
    private Problem5 _problem;
    private List<Move> _moves;
    private List<Stack<char>> _stacks;
    [SetUp]
    public void SetUp()
    {
        _problem = new Problem5();
        _moves = MovesFactory.GetMoves(@"move 1 from 8 to 1
move 1 from 6 to 1
move 3 from 7 to 4
move 3 from 2 to 9
move 11 from 9 to 3
move 1 from 6 to 9
move 15 from 3 to 9
move 5 from 2 to 3
move 3 from 7 to 5
move 6 from 9 to 3
move 6 from 1 to 6
move 2 from 3 to 7
move 5 from 4 to 5
move 7 from 9 to 4
move 2 from 9 to 5
move 10 from 4 to 2
move 6 from 5 to 4
move 2 from 7 to 6
move 10 from 2 to 3
move 21 from 3 to 5
move 1 from 3 to 6
move 3 from 6 to 9
move 1 from 8 to 9
move 5 from 4 to 5
move 4 from 9 to 3
move 17 from 5 to 1
move 1 from 6 to 2
move 16 from 5 to 1
move 3 from 3 to 6
move 6 from 6 to 4
move 1 from 2 to 4
move 4 from 1 to 2
move 2 from 6 to 2
move 28 from 1 to 3
move 1 from 9 to 7
move 1 from 8 to 7
move 1 from 5 to 4
move 1 from 2 to 6
move 1 from 3 to 1
move 3 from 2 to 5
move 1 from 6 to 3
move 4 from 4 to 7
move 5 from 5 to 2
move 1 from 5 to 6
move 6 from 1 to 3
move 1 from 6 to 2
move 26 from 3 to 6
move 2 from 7 to 9
move 4 from 7 to 3
move 19 from 6 to 3
move 6 from 2 to 4
move 5 from 3 to 2
move 1 from 9 to 7
move 26 from 3 to 8
move 6 from 4 to 3
move 1 from 3 to 8
move 1 from 6 to 7
move 6 from 3 to 6
move 6 from 6 to 4
move 1 from 9 to 2
move 2 from 4 to 9
move 22 from 8 to 2
move 2 from 6 to 5
move 1 from 9 to 1
move 1 from 6 to 5
move 1 from 7 to 5
move 3 from 6 to 7
move 2 from 6 to 1
move 1 from 1 to 5
move 3 from 5 to 9
move 4 from 8 to 4
move 2 from 1 to 4
move 18 from 2 to 1
move 2 from 7 to 8
move 3 from 9 to 5
move 8 from 1 to 9
move 5 from 9 to 3
move 1 from 9 to 8
move 2 from 9 to 4
move 2 from 7 to 8
move 5 from 5 to 7
move 1 from 9 to 3
move 4 from 8 to 4
move 1 from 7 to 8
move 4 from 4 to 3
move 2 from 8 to 3
move 1 from 8 to 9
move 2 from 1 to 8
move 3 from 4 to 5
move 1 from 8 to 4
move 1 from 9 to 3
move 1 from 8 to 5
move 8 from 1 to 8
move 11 from 2 to 9
move 12 from 3 to 5
move 1 from 3 to 9
move 1 from 8 to 5
move 11 from 9 to 3
move 4 from 5 to 9
move 3 from 8 to 7
move 3 from 7 to 8
move 1 from 5 to 8
move 7 from 4 to 3
move 1 from 4 to 5
move 1 from 2 to 8
move 3 from 7 to 6
move 3 from 4 to 8
move 1 from 7 to 9
move 2 from 4 to 7
move 5 from 8 to 1
move 3 from 6 to 5
move 2 from 4 to 2
move 1 from 9 to 4
move 1 from 8 to 6
move 1 from 2 to 9
move 1 from 8 to 5
move 3 from 8 to 4
move 3 from 4 to 2
move 4 from 3 to 9
move 17 from 5 to 9
move 9 from 9 to 6
move 1 from 9 to 3
move 5 from 6 to 3
move 3 from 6 to 3
move 8 from 9 to 5
move 2 from 8 to 5
move 1 from 4 to 8
move 1 from 5 to 3
move 1 from 8 to 5
move 3 from 2 to 6
move 3 from 1 to 4
move 7 from 5 to 1
move 1 from 2 to 6
move 13 from 3 to 6
move 2 from 7 to 8
move 13 from 6 to 5
move 3 from 5 to 7
move 6 from 5 to 6
move 1 from 7 to 6
move 2 from 7 to 3
move 1 from 6 to 8
move 13 from 3 to 5
move 9 from 5 to 9
move 7 from 5 to 7
move 17 from 9 to 2
move 3 from 4 to 7
move 9 from 2 to 9
move 10 from 9 to 3
move 8 from 7 to 8
move 2 from 5 to 3
move 4 from 2 to 6
move 11 from 3 to 9
move 9 from 6 to 5
move 5 from 9 to 8
move 1 from 3 to 1
move 3 from 9 to 1
move 2 from 5 to 2
move 1 from 7 to 9
move 2 from 9 to 4
move 2 from 9 to 8
move 13 from 1 to 8
move 3 from 8 to 5
move 27 from 8 to 1
move 10 from 5 to 9
move 1 from 7 to 2
move 2 from 4 to 3
move 10 from 9 to 6
move 1 from 8 to 7
move 15 from 1 to 9
move 13 from 9 to 5
move 15 from 5 to 7
move 5 from 1 to 3
move 8 from 7 to 1
move 7 from 7 to 1
move 16 from 1 to 8
move 4 from 3 to 9
move 4 from 1 to 7
move 4 from 9 to 6
move 5 from 2 to 7
move 15 from 8 to 6
move 1 from 9 to 1
move 3 from 3 to 4
move 1 from 9 to 7
move 1 from 2 to 7
move 1 from 2 to 7
move 1 from 8 to 1
move 3 from 4 to 8
move 3 from 8 to 1
move 8 from 6 to 8
move 7 from 1 to 4
move 11 from 6 to 8
move 14 from 6 to 5
move 13 from 8 to 7
move 4 from 7 to 5
move 15 from 7 to 4
move 6 from 5 to 4
move 2 from 5 to 9
move 1 from 5 to 2
move 3 from 8 to 5
move 19 from 4 to 7
move 10 from 5 to 8
move 2 from 6 to 8
move 1 from 4 to 8
move 2 from 7 to 9
move 9 from 7 to 4
move 6 from 4 to 6
move 11 from 4 to 8
move 2 from 5 to 4
move 5 from 6 to 4
move 1 from 6 to 7
move 3 from 9 to 5
move 3 from 8 to 5
move 3 from 7 to 6
move 11 from 8 to 7
move 1 from 9 to 5
move 1 from 6 to 8
move 1 from 2 to 1
move 5 from 4 to 9
move 2 from 4 to 1
move 2 from 1 to 4
move 1 from 1 to 9
move 4 from 5 to 1
move 1 from 4 to 6
move 17 from 7 to 5
move 9 from 8 to 7
move 6 from 9 to 7
move 3 from 1 to 9
move 12 from 7 to 9
move 12 from 9 to 5
move 5 from 7 to 9
move 17 from 5 to 3
move 7 from 3 to 1
move 5 from 1 to 5
move 5 from 9 to 2
move 4 from 3 to 5
move 1 from 4 to 8
move 5 from 2 to 1
move 22 from 5 to 9
move 3 from 7 to 6
move 6 from 6 to 9
move 2 from 5 to 4
move 1 from 6 to 3
move 2 from 4 to 1
move 3 from 8 to 2
move 1 from 3 to 4
move 24 from 9 to 1
move 4 from 3 to 9
move 2 from 2 to 9
move 2 from 3 to 1
move 1 from 8 to 6
move 1 from 6 to 9
move 1 from 8 to 9
move 2 from 7 to 4
move 1 from 8 to 3
move 1 from 4 to 7
move 3 from 9 to 8
move 1 from 2 to 1
move 9 from 9 to 3
move 1 from 8 to 7
move 1 from 4 to 3
move 2 from 9 to 7
move 1 from 9 to 3
move 2 from 8 to 4
move 12 from 3 to 8
move 2 from 1 to 7
move 1 from 4 to 3
move 30 from 1 to 5
move 6 from 5 to 7
move 12 from 7 to 2
move 1 from 3 to 4
move 2 from 1 to 3
move 1 from 4 to 9
move 10 from 5 to 7
move 10 from 2 to 6
move 8 from 8 to 3
move 3 from 1 to 3
move 5 from 6 to 3
move 2 from 8 to 5
move 1 from 9 to 2
move 2 from 8 to 6
move 4 from 7 to 2
move 3 from 2 to 7
move 2 from 7 to 5
move 1 from 4 to 9
move 11 from 3 to 1
move 7 from 6 to 9
move 3 from 2 to 3
move 10 from 1 to 7
move 14 from 7 to 5
move 3 from 7 to 6
move 5 from 9 to 7
move 29 from 5 to 7
move 6 from 3 to 9
move 2 from 9 to 7
move 15 from 7 to 5
move 11 from 5 to 6
move 5 from 9 to 5
move 10 from 5 to 8
move 1 from 2 to 4
move 1 from 8 to 2
move 2 from 4 to 3
move 2 from 5 to 9
move 8 from 8 to 9
move 11 from 9 to 3
move 1 from 1 to 8
move 18 from 7 to 3
move 1 from 9 to 3
move 28 from 3 to 5
move 12 from 6 to 7
move 1 from 2 to 9
move 15 from 7 to 2
move 1 from 8 to 1
move 10 from 2 to 9
move 10 from 5 to 3
move 2 from 2 to 3
move 18 from 3 to 4
move 6 from 9 to 4
move 1 from 1 to 7
move 1 from 6 to 4
move 1 from 8 to 2
move 1 from 9 to 4
move 2 from 9 to 4
move 19 from 4 to 3
move 1 from 7 to 9
move 1 from 9 to 7
move 1 from 6 to 8
move 3 from 2 to 8
move 2 from 9 to 5
move 15 from 3 to 1
move 7 from 5 to 1
move 3 from 4 to 9
move 1 from 7 to 2
move 3 from 3 to 1
move 6 from 5 to 2
move 3 from 3 to 9
move 4 from 9 to 2
move 5 from 5 to 3
move 1 from 3 to 5
move 3 from 5 to 7
move 3 from 8 to 5
move 1 from 7 to 5
move 4 from 5 to 1
move 4 from 4 to 2
move 2 from 7 to 8
move 12 from 1 to 6
move 1 from 8 to 6
move 6 from 2 to 3
move 9 from 3 to 8
move 1 from 3 to 4
move 3 from 6 to 1
move 2 from 9 to 2
move 1 from 4 to 5
move 2 from 8 to 3
move 10 from 2 to 1
move 2 from 4 to 7
move 12 from 1 to 4
move 1 from 5 to 1
move 7 from 4 to 9
move 2 from 3 to 2
move 6 from 9 to 2
move 1 from 9 to 1
move 1 from 7 to 8
move 5 from 6 to 7
move 3 from 6 to 1
move 6 from 2 to 3
move 2 from 4 to 3
move 1 from 6 to 8
move 1 from 6 to 7
move 8 from 3 to 9
move 2 from 4 to 5
move 3 from 2 to 4
move 10 from 8 to 2
move 22 from 1 to 9
move 9 from 2 to 4
move 1 from 1 to 3
move 1 from 3 to 2
move 3 from 2 to 4
move 2 from 7 to 1
move 14 from 4 to 2
move 2 from 1 to 8
move 2 from 4 to 5
move 4 from 7 to 8
move 24 from 9 to 6
move 3 from 5 to 9
move 1 from 9 to 8
move 1 from 5 to 2
move 1 from 6 to 7
move 6 from 9 to 1
move 1 from 7 to 3
move 5 from 8 to 6
move 9 from 6 to 3
move 4 from 1 to 4
move 2 from 1 to 2
move 11 from 6 to 3
move 13 from 3 to 2
move 2 from 9 to 8
move 8 from 3 to 8
move 2 from 8 to 5
move 1 from 7 to 5
move 3 from 6 to 3
move 11 from 8 to 5
move 13 from 2 to 4
move 10 from 5 to 2
move 2 from 3 to 4
move 2 from 5 to 7
move 15 from 4 to 9
move 2 from 7 to 4
move 2 from 4 to 2
move 2 from 4 to 9
move 2 from 4 to 2
move 1 from 3 to 8
move 1 from 8 to 1
move 1 from 1 to 2
move 1 from 6 to 3
move 7 from 2 to 4
move 1 from 5 to 3
move 7 from 9 to 1
move 7 from 1 to 2
move 4 from 6 to 9
move 12 from 9 to 7
move 6 from 7 to 5
move 1 from 3 to 5
move 7 from 4 to 7
move 3 from 7 to 8
move 3 from 8 to 6
move 18 from 2 to 9
move 7 from 2 to 3
move 15 from 9 to 4
move 3 from 3 to 9
move 1 from 3 to 1
move 3 from 5 to 4
move 1 from 1 to 2
move 1 from 9 to 2
move 2 from 6 to 2
move 5 from 7 to 6
move 5 from 2 to 7
move 3 from 3 to 4
move 5 from 5 to 3
move 6 from 7 to 4
move 9 from 4 to 2
move 18 from 4 to 9
move 6 from 2 to 1
move 1 from 1 to 9
move 4 from 7 to 4
move 7 from 2 to 4
move 1 from 2 to 8
move 1 from 4 to 2
move 4 from 3 to 4
move 16 from 9 to 5
move 9 from 9 to 8
move 1 from 9 to 7
move 4 from 1 to 2
move 2 from 5 to 4
move 10 from 5 to 4
move 4 from 2 to 1
move 5 from 1 to 2
move 1 from 8 to 5
move 1 from 6 to 5
move 4 from 8 to 5
move 2 from 6 to 9
move 3 from 6 to 2
move 2 from 9 to 1
move 1 from 7 to 6
move 1 from 3 to 8
move 9 from 5 to 9
move 4 from 8 to 1
move 2 from 8 to 2
move 1 from 5 to 7
move 9 from 9 to 8
move 1 from 7 to 5
move 9 from 8 to 2
move 6 from 1 to 6
move 6 from 2 to 6
move 10 from 2 to 5
move 5 from 2 to 1
move 1 from 3 to 5
move 8 from 5 to 4
move 5 from 1 to 3
move 10 from 6 to 8
move 3 from 6 to 9
move 4 from 3 to 1
move 5 from 8 to 2
move 4 from 5 to 9
move 1 from 3 to 7
move 1 from 7 to 3
move 1 from 8 to 6
move 1 from 6 to 1
move 15 from 4 to 8
move 5 from 9 to 2
move 1 from 9 to 1
move 1 from 1 to 3
move 6 from 4 to 8
move 12 from 8 to 7
move 1 from 3 to 5
move 3 from 1 to 9
move 13 from 4 to 9
move 5 from 7 to 2
move 1 from 5 to 4
move 8 from 9 to 5
move 6 from 2 to 5
move 2 from 5 to 6");
        
        _stacks = new List<Stack<char>>
        {
            new(new[] { 'F', 'T', 'C', 'L', 'R', 'P', 'G', 'Q' }),
            new(new[] { 'N', 'Q', 'H', 'W', 'R', 'F', 'S', 'J' }),
            new(new[] { 'F', 'B', 'H', 'W', 'P', 'M', 'Q'}),
            new(new[] { 'V', 'S', 'T', 'D', 'F'}),
            new(new[] { 'Q', 'L', 'D', 'W', 'V', 'F', 'Z'}),
            new(new[] { 'Z', 'C', 'L', 'S'}),
            new(new[] { 'Z', 'B', 'M', 'V', 'D', 'F'}),
            new(new[] { 'T', 'J', 'B'}),
            new(new[] { 'Q', 'N', 'B', 'G', 'L', 'S', 'P', 'H'})
        };
    }

    [Test]
    public void TestPart1()
    {
        var moves = MovesFactory.GetMoves(@"move 1 from 2 to 1
move 3 from 1 to 3
move 2 from 2 to 1
move 1 from 1 to 2");
        var stacks = new List<Stack<char>>
        {
            new(new[] { 'Z', 'N' }),
            new(new[] { 'M', 'C', 'D' }),
            new(new[] { 'P'})
        };
        var result= _problem.Solve(stacks, moves);
        Assert.That(result, Is.EqualTo("CMZ"));
    }
    
    [Test]
    public void SolvePart1()
    {
        var result = _problem.Solve(_stacks, _moves);
        Assert.That(result, Is.EqualTo("VGBBJCRMN"));
    }

    [Test]
    public void SolvePart2()
    {
        var result = _problem.Solve2(_stacks, _moves);
        Assert.That(result, Is.EqualTo("LBBVJBRMH"));
    }

}