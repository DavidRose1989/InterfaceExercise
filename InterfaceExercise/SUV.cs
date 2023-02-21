using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany    //When you conform a Interface you use a comma and the name has to start with a I.  
    {
        public string Year { get; set; }       //This is how you get your property and give it features. 

        public string Make { get; set; }
        public string Model { get; set; }
        public bool SevenSeater { get; set; }

        public bool PilotSeats { get; set; }
        public bool FiveOrMoreSeats { get ; set ; }
        public bool AtLeastFourWheels { get ; set ; }
        public bool HeadLights { get ; set ; }
        public bool CanBeElectric { get ; set ; }
        public string Logo { get ; set ; }
        public string Color { get ; set ; }

        public void VehicleStats()
        {
            Console.WriteLine("This is for your family");
            Console.WriteLine($"{Year}, {Make}, {Model}");
            Console.WriteLine();
        }
    }
}
