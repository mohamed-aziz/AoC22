using AoC22.Problem3;

namespace Tests;

[TestFixture]
public class TestProblem3
{
    private Problem3 _problem;
    [SetUp]
    public void SetUp()
    {
        _problem = new Problem3();
    }

    [Test]
    public void TestPart1()
    {
        var result = _problem.Solve(@"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw");
        Assert.That(result, Is.EqualTo(157));
    }
    
    [Test]
    public void SolvePart1()
    {
        var input = File.ReadAllText(@"inputs\\day3.txt");
        var result = _problem.Solve2(input);
        Assert.That(result, Is.EqualTo(2650));
    }

}