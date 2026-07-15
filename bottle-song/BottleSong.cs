using System.Collections.Generic;

public static class BottleSong
{
    private static readonly Dictionary<int, string> numbers = new()
    {
        {0,"no"}, {1,"One"}, {2,"Two"}, {3,"Three"}, {4,"Four"}, {5,"Five"}, 
        {6,"Six"}, {7,"Seven"}, {8,"Eight"}, {9,"Nine"}, {10,"Ten"},
    };

    private static string StartLine(int startBottles) => 
        $"{numbers.GetValueOrDefault(startBottles)} green bottle{((startBottles > 1) ? "s" : "")} hanging on the wall,";

    private const string MiddleLine = "And if one green bottle should accidentally fall,";

    private static string EndLine(int startBottles) =>
        $"There'll be {numbers.GetValueOrDefault(startBottles - 1, "no").ToLower()} green bottle{((startBottles-1 == 1) ? "" : "s")} hanging on the wall.";

    public static IEnumerable<string> Recite(int startBottles, int takeDown)
    {
        List<string> result = new();

        for (int i = startBottles; i > startBottles - takeDown; i--)
        {
            result.Add(StartLine(i));
            result.Add(StartLine(i));
            result.Add(MiddleLine);
            result.Add(EndLine(i));
            result.Add("");
        }

        result.RemoveAt(result.Count - 1);
        return result;
    }
}
