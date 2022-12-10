using AoC22.Problem2;

namespace Tests;

[TestFixture]
public class TestProblem2
{
    private Problem2 _problem;
    
    [SetUp]
    public void SetUp()
    {
        _problem = new Problem2();
    }
    
    [Test]
    public void TestPart1()
    {
        var result = _problem.Solve(@"A Y
B X
C Z");
        Assert.That(result, Is.EqualTo(15));
    }

    [Test]
    public void SolvePart1()
    {
        var input = File.ReadAllText(@"inputs\\day2.txt");
        var result = _problem.Solve(input);
        Assert.That(result, Is.EqualTo(12794));
    }

    [Test]
    public void TestPart2()
    {
        var result = _problem.Solve2(@"A Y
B X
C Z");
        Assert.That(result, Is.EqualTo(12));
    }

    [Test]
    public void SolvePart2()
    {
        var input = File.ReadAllText(@"inputs\\day2.txt");
        var result = _problem.Solve2(input);
        Assert.That(result, Is.EqualTo(14979));
    }

}