using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CSharp_Tutorials.Object_Oriented_Programming
{
    public class Vehicle
    {
        // Unofficial rule holds that
        // the name of a class starts with a Capital letter.
        public string model;            // Name of the model
        public string manufacturer;     // Ditto
        public int numOfDoors;          // The number of doors on the vehicle
        public int numOfWheels;         // The number of wheels on the vehicle
    }

    class ClassProperties
    {
        public static void ClassPropertiesExamples()
        {
            #region Creating An Object of a Class
            //(Yes, a class is a type, and all C# objects are defined as classes.) 
            //The first line declares a variable myCar of type Vehicle
            Vehicle myCar;
            // The new Vehicle() command creates a specific object of type Vehicle
            // and stores the location into the variable myCar.
            // The new operator creates a new block of memory in which your
            // program can store the properties of myCar.
            myCar = new Vehicle();
            #endregion
            #region Accessing the Members of an Object
            // Each object of class Vehicle has its own set of members.The following
            // expression stores the number 1 into the numberOfDoors member of the
            // object referenced by myCar:
            myCar.numOfDoors = 1;
            myCar.manufacturer = "BMW";
            myCar.model = "Isetta";
            #endregion
            #region Reference
            //// Create a null reference.
            //Vehicle yourCar;
            //// Assign the reference a value.
            //yourCar = new Vehicle();
            //// Use dot to access a member.
            //yourCar.manufacturer = "Rambler";
            //// Create a new reference and point it to the same object.
            //Vehicle yourSpousalCar = yourCar;

            //// Build your car.
            //Vehicle yourCar = new Vehicle();
            //yourCar.model = "Kaiser";
            //// It also belongs to your spouse.
            //Vehicle yourSpousalCar = yourCar;
            //// Changing one changes the other.
            //yourSpousalCar.model = "Henry J";
            //Console.WriteLine("Your car is a " + yourCar.model);

            // Build your car.
            Vehicle yourCar = new Vehicle();
            yourCar.model = "Kaiser";
            // It also belongs to your spouse.
            Vehicle yourSpouseCar = yourCar;
            // When your spouse takes your car away . . .
            yourCar = null;     // yourCar now references the “null object.”
            // . . .yourSpousalCar still references the same vehicle
            Console.WriteLine("your car was a "+ yourSpouseCar.model);
            #endregion
        }
    }

    public class VehicleDataOnly
    {
        public static void VehicleDataOnlyMain()
        {
            // Prompt user to enter her name.
            Console.WriteLine("Enter the properties of your vehicle");
            // Create an instance of Vehicle.
            Vehicle myCar = new Vehicle();
            // Populate a data member via a temporary variable.
            Console.Write("Model name = ");
            string s = Console.ReadLine();
            myCar.model = s;
            // Or you can populate the data member directly.
            Console.Write("Manufacturer name = ");
            myCar.manufacturer = Console.ReadLine();
            // Enter the remainder of the data.
            // A temp is useful for reading ints.
            Console.Write("Number of doors = ");
            s = Console.ReadLine();
            myCar.numOfDoors = Convert.ToInt32(s);
            Console.Write("Number of wheels = ");
            s = Console.ReadLine();
            myCar.numOfWheels = Convert.ToInt32(s);
            // Now display the results.
            Console.WriteLine("\nYour vehicle is a ");
            Console.WriteLine(myCar.manufacturer + " "+ myCar.model);
            Console.WriteLine("with "+ myCar.numOfDoors + " doors, "
                              +"riding on " + myCar.numOfWheels
                              + " wheels.");
            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
