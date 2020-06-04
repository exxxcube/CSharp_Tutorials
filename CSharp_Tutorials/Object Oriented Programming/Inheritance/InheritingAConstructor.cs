using System;
using System.Collections.Generic;
using System.Text;

namespace InheritingAConstructor
{
    // InheritingAConstructor -- Demonstrate that the base class
    // constructor is invoked automatically.
    public class InheritingAConstructorClass
    {
        public static void InheritingAConstructorMain()
        {
            Console.WriteLine("Creating a BaseClass object");
            BaseClass bc = new BaseClass();
            Console.WriteLine("\nnow creating a SubClass object");
            SubClass sc = new SubClass();
            // Wait for user to acknowledge.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Constructing BaseClass");
        }
    }
    public class SubClass : BaseClass
    {
        public SubClass()
        {
            Console.WriteLine("Constructing SubClass");
        }
    }
}
