using AoC22.Problem7;

namespace Tests;

[TestFixture]
public class TestProblem7
{
    private Problem7 _problem;
    [SetUp]
    public void SetUp()
    {
        _problem = new Problem7();
    }

    [Test]
    public void TestPart1()
    {
        var input = @"$ cd /
$ ls
dir a
14848514 b.txt
8504156 c.dat
dir d
$ cd a
$ ls
dir e
29116 f
2557 g
62596 h.lst
$ cd e
$ ls
584 i
$ cd ..
$ cd ..
$ cd d
$ ls
4060174 j
8033020 d.log
5626152 d.ext
7214296 k";
        
        var result = _problem.Solve(input);
        Assert.That(result, Is.EqualTo(95437));
    }

    [Test]
    public void SolvePart1()
    {
        var input = File.ReadAllText(@"Inputs\\day7.txt");
        var result = _problem.Solve(input);
        Assert.That(result, Is.EqualTo(1297683));
    }
    

    [Test]
    public void TestPart2()
    {
        var input = @"$ cd /
$ ls
dir a
14848514 b.txt
8504156 c.dat
dir d
$ cd a
$ ls
dir e
29116 f
2557 g
62596 h.lst
$ cd e
$ ls
584 i
$ cd ..
$ cd ..
$ cd d
$ ls
4060174 j
8033020 d.log
5626152 d.ext
7214296 k";
        
        var result = _problem.Solve2(input);
        Assert.That(result, Is.EqualTo(24933642));
    }

    [Test]
    public void SolvePart2()
    {
        var input = File.ReadAllText(@"Inputs\\day7.txt");
        var result = _problem.Solve2(input);
        Assert.That(result, Is.EqualTo(5756764));
    }

}