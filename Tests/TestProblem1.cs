using AoC22.Problem1;

namespace Tests;

public class TestProblem1
{
    private Problem1 _problem; 
    
    [SetUp]
    public void SetUp()
    {
        _problem = new Problem1();
    }

    [Test]
    public void TestPart1()
    {
        var output = _problem.Solve(@"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000");
        
        Assert.That(output, Is.EqualTo(24000));
    }
    
    [Test]
    public void SolvePart1()
    {
        var input = File.ReadAllText(@"Inputs\\day1.txt");
        var output = _problem.Solve(input);
        Console.WriteLine(output);
    }

    
    [Test]
    public void SolvePart2()
    {
        var input = File.ReadAllText(@"Inputs\\day1.txt");
        var output = _problem.Solve2(input);
        Console.WriteLine(output);
    }
}