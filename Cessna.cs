using System;

namespace Inheritance {
	public class Cessna : GasVehicle { // Propellor light aircraft
		
		public override void Drive () {
            Console.WriteLine("Zoom!");
        }
	}
}
