public class ControlCar
{
    private int speed;
    private int distanceDrive = 0;
    private int battery;
    private int fullbattery = 100;
    public ControlCar(int speed, int battery)
    {
        this.speed = speed;
        this.battery = battery;
    }
    public void Drive()
    {
        distanceDrive += speed;
        fullbattery -= battery;
    }
    public int DistanceDriven()
    {
        return distanceDrive;
    }

    public bool BatteryDrained()
    {
      if (fullbattery > 0) {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static ControlCar Nitro()
    {
        return new ControlCar(50, 4);
    }
    
}
