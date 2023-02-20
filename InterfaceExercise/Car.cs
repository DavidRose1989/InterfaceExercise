using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany  //conforming interfaces this is how you do it
    {
        public string Year { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public bool Convertable { get; set; }
        public bool TwoSeater { get; set; }
        public bool FiveOrMoreSeats { get; set; }
        public bool AtLeastFourWheels { get; set; }
        public bool HeadLights { get; set; }
        public bool CanBeElectric { get; set; }
        public string Logo { get; set; }
        public string Color { get; set; }

        public void VehicleStats()
        {
            Console.WriteLine("0 to 60 in 3 seconds");
            Console.WriteLine($"{Year} {Make} {Model}");
            Console.WriteLine();
        }

       
    }
}
