class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0, 2, 5, 3, 7, 8, 4];

    public int Today() => birdsPerDay.Last();

    public void IncrementTodaysCount() => birdsPerDay[birdsPerDay.Length - 1] += 1;

    public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;

        if (numberOfDays > 7 || numberOfDays < 0)
            throw new ArgumentException();

        for (int i = 0; i < numberOfDays; i++)
        {
            count += birdsPerDay[i];
        }

        return count;
    }

    public int BusyDays() => birdsPerDay.Count(v => v >= 5);

}