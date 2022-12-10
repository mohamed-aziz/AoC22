using AoC22.Problem8;

namespace Tests;

[TestFixture]
public class TestProblem8
{
    private Problem8 _problem;
    [SetUp]
    public void SetUp()
    {
        _problem = new Problem8();
    }

    [Test]
    public void TestPart1()
    {
        var input = @"30373
25512
65332
33549
35390";
        var result = _problem.Solve(input);
        Assert.That(result, Is.EqualTo(21));
    }

    [Test]
    public void SolvePart1()
    {
        var input = File.ReadAllText(@"Inputs\\day8.txt");
        var result = _problem.Solve(input);
        Assert.That(result, Is.EqualTo(1698));
    }
}
