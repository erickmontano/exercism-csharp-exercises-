class Lasagna
{
    const int EXPECTED_MINUTES_IN_OVEN = 40;
    const int PREPARATION_TIME_PER_LAYER = 2;

    public int ExpectedMinutesInOven() => EXPECTED_MINUTES_IN_OVEN;
    
    public int RemainingMinutesInOven(int actualMinutesInOven) => ExpectedMinutesInOven() - actualMinutesInOven;

    public int PreparationTimeInMinutes(int numberOfLayers) => PREPARATION_TIME_PER_LAYER * numberOfLayers;

    public int ElapsedTimeInMinutes(int numberOfLayers, int minutesInOven) => PreparationTimeInMinutes(numberOfLayers) + minutesInOven;
}
