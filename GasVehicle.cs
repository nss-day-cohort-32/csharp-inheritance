using System;

namespace Inheritance
{   
    public class GasVehicle : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank () 
        {
            Console.WriteLine("Tank is now full");
        }
    }
}
