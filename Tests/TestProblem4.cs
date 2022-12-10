using AoC22.Problem4;

namespace Tests;

[TestFixture]
public class TestProblem4
{
    private Problem4 _problem;

    [SetUp]
    public void SetUp()
    {
        _problem = new Problem4();
    }

    [Test]
    public void TestPart1()
    {
        var result = _problem.Solve(@"2-4,6-8
2-3,4-5
5-7,7-9
2-8,3-7
6-6,4-6
2-6,4-8");
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void SolvePart1()
    {
        var input = File.ReadAllText(@"inputs\\day4.txt");
        var result = _problem.Solve(input);
        Assert.That(result, Is.EqualTo(651));
    }

    [Test]
    public void TestPart2()
    {
        var result = _problem.Solve2(@"2-4,6-8
2-3,4-5
5-7,7-9
2-8,3-7
6-6,4-6
2-6,4-8");
        Assert.That(result, Is.EqualTo(4));
    }

    
    [Test]
    public void SolvePart2()
    {
        var input = File.ReadAllText(@"inputs\\day4.txt");
        var result = _problem.Solve2(input);
        Assert.That(result, Is.EqualTo(956));
    }
}
