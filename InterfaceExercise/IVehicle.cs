using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public bool FiveOrMoreSeats { get; set; }
        public bool AtLeastFourWheels { get; set; }
        public bool HeadLights { get; set; }

        public bool CanBeElectric { get; set; }

        public void VehicleStats();
    }
    
}

