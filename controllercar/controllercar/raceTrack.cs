using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controllercar
{
    public class raceTrack
    {
        private int distance;
        public raceTrack(int distance)
        {
            this.distance = distance;
        }
        
        public bool TryFinishTrack(ControlCar car)
        {
            while (car.DistanceDriven() <= distance)
            {
                if (car.BatteryDrained())
                {
                    return false;

                }
                car.Drive();
            }
            return true;
        }
    }

}
    
