using AoC22.Problem6;

namespace Tests;

[TestFixture]
public class TestProblem6
{
    private Problem6 _problem;
    [SetUp]
    public void SetUp()
    {
        _problem = new Problem6();
    }

    [Test]
    public void TestPart1()
    {
        Assert.That(_problem.Solve("bvwbjplbgvbhsrlpgdmjqwftvncz"), Is.EqualTo(5));
        Assert.That(_problem.Solve("nppdvjthqldpwncqszvftbrmjlhg"), Is.EqualTo(6));
        Assert.That(_problem.Solve("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg"), Is.EqualTo(10));
        Assert.That(_problem.Solve("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw"), Is.EqualTo(11));
    }

    [Test]
    public void SolvePart1()
    {
        Assert.That(_problem.Solve(File.ReadAllText(@"Inputs\\day6.txt")), Is.EqualTo(1093));
    }
    
    [Test]
    public void SolvePart2()
    {
        Assert.That(_problem.Solve2(File.ReadAllText(@"Inputs\\day6.txt")), Is.EqualTo(3534));
    }
}