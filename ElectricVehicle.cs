using System;

namespace Inheritance
{   
    public class ElectricVehicle : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery () 
        {
            Console.WriteLine("Battery charging...");
        }

        public override void Drive () {
            Console.WriteLine("...");
        }
    }
}
