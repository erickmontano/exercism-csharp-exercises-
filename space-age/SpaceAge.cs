public class SpaceAge
{
    public double Seconds { get; init; }

    private const int EarthYearsInSeconds = 31557600;

    private enum Planet
    {
        Mercury, Venus, Mars, Jupiter, Saturn, Uranus, Neptune
    }

    private static readonly Dictionary<Planet, double> OrbitalPeriodInEarthYears = new()
    {             
        { Planet.Mercury, 0.2408467 },
        { Planet.Venus, 0.61519726 },
        { Planet.Mars, 1.8808158 },
        { Planet.Jupiter, 11.862615 },
        { Planet.Saturn, 29.447498 },
        { Planet.Uranus, 84.016846 },
        { Planet.Neptune, 164.79132 },
    };

    public SpaceAge(int seconds) => Seconds = seconds;

    private double CalculateAge(Planet planet) => OnEarth() / OrbitalPeriodInEarthYears[planet];

    public double OnEarth() => Seconds / EarthYearsInSeconds;
    public double OnMercury() => CalculateAge(Planet.Mercury);
    public double OnVenus() => CalculateAge(Planet.Venus);
    public double OnMars() => CalculateAge(Planet.Mars);
    public double OnJupiter() => CalculateAge(Planet.Jupiter);
    public double OnSaturn() => CalculateAge(Planet.Saturn);
    public double OnUranus() => CalculateAge(Planet.Uranus);
    public double OnNeptune() => CalculateAge(Planet.Neptune);
}