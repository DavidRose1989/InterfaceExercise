using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany 
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasFlatBed { get; set; }

        public bool OffRoading { get; set; }
        public bool FiveOrMoreSeats { get; set; }
        public bool AtLeastFourWheels { get; set; }
        public bool HeadLights { get; set; }
        public bool CanBeElectric { get; set; }
        public string Logo { get; set; }
        public string Color { get; set; }

        public void VehicleStats()                                      //The only properties I wanted the VehicleStats method to call was Year, Make, Model.
        {                                                               //That's why when calling it to the console I string interpulated Year, Make, Model.
            Console.WriteLine("When you want to haul things.");
            Console.WriteLine($"{Year}, {Make}, {Model}");
            Console.WriteLine();
        }
    }
}
