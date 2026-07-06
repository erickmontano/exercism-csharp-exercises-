public static class SquareRoot
{
    private static int Square(int number) => number * number;

    public static int Root(int number)
    {
        for (int i = 0; i <= number; i++)
        {
            if (Square(i) == number)
                return i;
        }
        throw new ArgumentException("No perfect square found.");
    }
}
