class RemoteControlCar
{
    private int _totalDistance;
    private int _batteryCharge;

    public RemoteControlCar()
    {
        _totalDistance = 0;
        _batteryCharge = 100;
    }
    public static RemoteControlCar Buy() => new();
    
    public string DistanceDisplay() => $"Driven {_totalDistance} meters";

    public string BatteryDisplay() => (_batteryCharge != 0) ? $"Battery at {_batteryCharge}%" : "Battery empty";

    public void Drive()
    {
        if (_batteryCharge > 0)
        {
            _totalDistance += 20;
            _batteryCharge -= 1;
        }
    }
}
