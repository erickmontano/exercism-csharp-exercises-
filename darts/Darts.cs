public static class Darts
{
    private enum TargetArea
    {
        InnerCircle, MiddleCircle, OuterCircle, Outside
    }

    private static readonly Dictionary<TargetArea, int> AreaValues = new()
    {
        {TargetArea.InnerCircle, 10},
        {TargetArea.MiddleCircle, 5},
        {TargetArea.OuterCircle, 1},
        {TargetArea.Outside, 0},
    };

    private static TargetArea GetDartPosition(double x, double y)
    {
        switch (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)))
        {
            case <= 1:
                return TargetArea.InnerCircle;
            case <= 5:
                return TargetArea.MiddleCircle;
            case <= 10:
                return TargetArea.OuterCircle;
            default:
                return TargetArea.Outside;
        }
    }
    public static int Score(double x, double y) => AreaValues[GetDartPosition(x, y)];
}
