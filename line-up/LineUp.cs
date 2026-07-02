public static class LineUp
{
    public static string Format(string name, int number) => $"{name}, you are the {number}{GetOrdinalNumber(number)} customer we serve today. Thank you!";

    private static string GetOrdinalNumber(int number)
    {
        if (number > 999 || number <= 0)
            throw new ArgumentOutOfRangeException($"The number '{number}' is invalid.");

        switch (number % 100)  // check last two digits first
        {
            case 11:
            case 12:
            case 13:
                return "th";
            default:
                return (number % 10) switch  // then check last digit
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
        }
    }

}