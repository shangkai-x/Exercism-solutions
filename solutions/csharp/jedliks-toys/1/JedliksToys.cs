class RemoteControlCar
{

    private int _DistanceDriven = 0;
    private int _CarBattery = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_DistanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (_CarBattery == 0 )
        {
            return("Battery empty");
        }
        return $"Battery at {_CarBattery}%";
    }

    public void Drive()
    {
        if (_CarBattery > 0)
        {
            _DistanceDriven  += 20;
            _CarBattery -= 1;
        }
        
    }
}
