class RemoteControlCar
{
    public int BatteryDrain { get; init; }
    private int Battery
    {
        get { return _battery; }
        set{ if (value >= 0) _battery = value; }
    }
    private int _battery;
    public int Speed { get; init; }//Speed in Meters
    private int DistanceTraveled { get; set; }//Distance Traveled in Meters

    public RemoteControlCar(int speed, int batteryDrain, int battery = 100)
    {
        BatteryDrain = batteryDrain;
        Speed = speed;
        Battery = battery;
        DistanceTraveled = 0;
    }

    public bool BatteryDrained() => Battery < BatteryDrain;

    public int DistanceDriven() => DistanceTraveled;

    public void Drive()
    {
        if (!BatteryDrained())
        {
            DistanceTraveled += Speed;
            Battery -= BatteryDrain;
        }
    }
    public static RemoteControlCar Nitro() => new RemoteControlCar(speed: 50, batteryDrain: 4);
}

class RaceTrack
{
    public int TrackDistance { get; init; }
    public RaceTrack(int distance)
    {
        TrackDistance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
            if (car.DistanceDriven() >= TrackDistance)
                return true;
        };
        return false;
    }
}