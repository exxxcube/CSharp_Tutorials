using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CSharp_Tutorials.Object_Oriented_Programming
{    
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
    #region Generating Static in Class Members
    public class Car
    {
        
        // However, some properties exist that all cars share.For example, the number
        // of cars built is a property of the class Car but not of any single object. These
        // class properties are flagged in C# with the keyword static:

        //This is a static member of Car Class
        public static int numberOfCars; // The number of cars built
        public string licensePlate;     // The license plate ID

    }
    #endregion
    #region Defining const and readonly Data Members
    class ConstAndReadOnly
    {
        // BIG LETTERS FOR READONLY VARIABLES 
        public readonly int EXAMPLE_READONLY_VARIABLE;
        ConstAndReadOnly()
        {
            EXAMPLE_READONLY_VARIABLE = 30;            
        }
        // BIG LETTERS FOR CONSTANT VARIABLES 
        public const int DAYS_IN_A_YEAR = 366; // Must have initializer.        
        public static void MainConstAndReadOnly(string[] args)
        {            
            // This is an array, covered later in this chapter.
            int[] maxTemperatures = new int[DAYS_IN_A_YEAR];
            for (int index = 0; index < DAYS_IN_A_YEAR; index++)
            {
                // . . .accumulate the maximum temperature for each
                // day of the year . . .
            }
        }
    }
    #endregion
    public class Vehicle
    {
        // Unofficial rule holds that
        // the name of a class starts with a Capital letter.
        public string model;            // Name of the model
        public string manufacturer;     // Ditto
        public int numOfDoors;          // The number of doors on the vehicle
        public int numOfWheels;         // The number of wheels on the vehicle
        // Combine other class (which is the Motor Class inside this class)
        public Motor motor;
    }
    // Motor Class is an Example in Vehicle Class
    public class Motor
    {
        public int power;               // Power [horsepower]
        public double displacement;     // Engine displacement [liter]
    }

    public class CarsFactory
    {
        public static void NewCar()
        {
            // Create a new object of class Car
            Car newCar = new Car();
            newCar.licensePlate = "ABC123";
            // Now increment the count of cars to reflect the new one
            Car.numberOfCars++;
        }
        public static void CreatingCars()
        {
            //First Create a motor
            Motor largeMotor = new Motor();
            largeMotor.power = 230;
            largeMotor.displacement = 4.0;
            //Creating Vehicle
            Vehicle friendsCar = new Vehicle();
            friendsCar.model = "Cherokee Sport";
            friendsCar.manufacturer = "Jeep";
            friendsCar.numOfDoors = 2;
            friendsCar.numOfWheels = 4;
            //Attach the motor to the car
            friendsCar.motor = largeMotor;
            Console.WriteLine("The motor displacement is "+ friendsCar.motor.displacement);
        }
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
