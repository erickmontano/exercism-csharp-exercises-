public static class DifferenceOfSquares
{
    // Formula: (n * (n + 1) / 2)² — square of the sum of 1 to n
    public static int CalculateSquareOfSum(int max) => (int)Math.Pow(max * (max + 1) / 2, 2);

    // Formula: n * (n + 1) * (2n + 1) / 6 — sum of squares of 1 to n
    public static int CalculateSumOfSquares(int max) => max * (max + 1) * (2 * max + 1) / 6;

    // Difference between the two results
    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}