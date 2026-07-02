public static class LineUp
{
    public static string Format(string name, int number) => $"{name}, you are the {number}{GetOrdinalNumber(number)} customer we serve today. Thank you!";

    private static string GetOrdinalNumber(int number)
    {
        if (number > 999 || number <= 0)
            throw new ArgumentOutOfRangeException($"The number '{number}' is invalid.");

        return (number % 10) switch
        {
            1 when number % 100 != 11 => "st",
            2 when number % 100 != 12 => "nd",
            3 when number % 100 != 13 => "rd",
            _ => "th",
        };
    }
}