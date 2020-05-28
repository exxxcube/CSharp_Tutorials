using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorials.Object_Oriented_Programming.Holding_a_Class_Responsible
{
    // DemonstrateCustomConstructor -- Demonstrate how you can replace the
    // C# default constructor with your own, custom constructor.
    // Creates a class with a constructor and then steps through a few scenarios.

    // MyObject -- Create a class with a noisy custom constructor
    // and an internal data object.
    public class DemonstrateCustomConstructor
    {
        public static void DemonstrateCustomConstructorProg()
        {
            Console.WriteLine("Main() starting");
            Console.WriteLine("Creating a local MyObject in Main():");
            MyObject localObject = new MyObject();
            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
    public class MyObject
    {
        // This data member is a property of the class (it’s static).  
        private static MyOtherObject _staticObj = new MyOtherObject();
        // This data member is a property of each instance.
        private MyOtherObject _dynamicObj;
        // Constructor (a real chatterbox)
        public MyObject()
        {
            Console.WriteLine("MyObject constructor starting");
            Console.WriteLine("(Static data member constructed before this constructor)");
            Console.WriteLine("Now create nonstatic data member dynamically:");
            _dynamicObj = new MyOtherObject();
            Console.WriteLine("MyObject constructor ending");
        }
    }
    // MyOtherObject -- This class also has a noisy constructor but
    // no internal members.
    public class MyOtherObject
    {
        public MyOtherObject()
        {
            Console.WriteLine("MyOtherObject constructing");
        }
    }
    class Major
    {
        #region Initialization with something that looks suspiciously like a constructor
        Student newStudent = new Student()
        {
            // This is an initializer
            Name = "Exxxcube",
            Address = "Aincrad",
            GradePointAverage = 1.0
        };
        #endregion
    }
}
