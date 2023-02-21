using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle                             //When you create an interface class you have to start the name with a capital I. 
    {                                                       //You cannot instantiate an abstract class which is why you cannot instantiate a Interface. 
        public bool FiveOrMoreSeats { get; set; }
        public bool AtLeastFourWheels { get; set; }
        public bool HeadLights { get; set; }

        public bool CanBeElectric { get; set; }

        public void VehicleStats();                         //The method is built in the Ivehicle Interface so that when the methodd is called the Interface and it's properties can be referenced.
    }
    
}

