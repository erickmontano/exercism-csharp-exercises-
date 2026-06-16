static class AssemblyLine
{    
    private const int carProductionSpeedPerHour = 221;

    public static double SuccessRate(int speed)
    {
        switch (speed)
        {
            case 10:
                return 0.77d;
            case 9:
                return 0.8d;
            case int s when s >= 5 && s <= 8:
                return 0.9d;
            case int s when s >= 1 && s <= 4:
                return 1.0d;
            default:
                return 0;
        }
    }
    
    public static double ProductionRatePerHour(int speed) => carProductionSpeedPerHour * speed * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed) / 60);
}
