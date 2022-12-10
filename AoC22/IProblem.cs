namespace AoC22
{
    internal interface IProblem<out T>
    {
        T Solve(String input);
        T Solve2(String input);
    }
}
