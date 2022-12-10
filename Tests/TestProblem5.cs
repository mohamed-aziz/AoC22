using AoC22.Problem5;

namespace Tests;

[TestFixture]
public class TestProblem5
{
    private Problem5 _problem;

    [SetUp]
    public void SetUp()
    {
        _problem = new Problem5();
    }

    [Test]
    public void TestPart1()
    {
        var result = _problem.Solve(@"    [D]    
[N] [C]    
[Z] [M] [P]
 1   2   3 

move 1 from 2 to 1
move 3 from 1 to 3
move 2 from 2 to 1
move 1 from 1 to 2");
        _problem.Solve(result);
    }

}