using System;

namespace Inheritance
{   
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive () {
            Console.WriteLine("Vrooom!");
        }
    }
}
