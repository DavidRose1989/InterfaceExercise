using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //done - Create 2 Interfaces called IVehicle & ICompany

            //done - Create 3 classes called Car , Truck , & SUV

            //done - In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //done - In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //done - In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * done - Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car car1 = new Car();
            car1.Year = "2022";
            car1.Make = "Ferarri";
            car1.Model = "M8";
            car1.Convertable = true;
            car1.AtLeastFourWheels = true;
            car1.Color = "Red";
            car1.TwoSeater = true;
           
            SUV suv1= new SUV();
            suv1.Make = "Ford";
            suv1.Year = "2022";
            suv1.Model = "Explorer";
            suv1.Logo = "Ford";
            suv1.SevenSeater = true;
            suv1.HeadLights = true;
            suv1.Color = "Black";
            suv1.PilotSeats = true;
           
            Truck truck1 = new Truck();
            truck1.Make = "Ford";
            truck1.Year = "2022";
            truck1.Model = "F150";
            truck1.Logo = "Dodge";
            truck1.OffRoading   = true;
            truck1.Color = "Blue";
            truck1.HasFlatBed = true;
            truck1.CanBeElectric = true;

            

            List<IVehicle> vehicles = new List<IVehicle>(){car1, truck1, suv1}; //object initializer syntax
   
            
            foreach (var vehicle in vehicles)
            {
                vehicle.VehicleStats();
            }

           
            
        }
    }
}
