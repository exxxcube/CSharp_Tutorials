using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorials.Object_Oriented_Programming.Holding_a_Class_Responsible
{
    class ClassResponsibility
    {
        //A class must be held responsible for its actions.
        #region Defining Class Properties 
        int x = 0;
        public int AccountNumber   // No parentheses here.
        {
            get { return x; }  // The "read" part. Curly braces and semicolon.
            set { x = value; } // The "write" part. 'value' is a keyword.
        }
        #endregion
        #region New feature: Letting the compiler write properties for you
        private string _name; // An underlying data member for the property
        public string Name { get { return _name; } set { _name = value; } }
        // This code above is the same as the code below
        public string NewImproveName { get; set; }
        #endregion       
    }
    #region Constructor Example Code
    //public class ConstructorExample
    //{
    //    //C# requires the constructor to carry the name of the class. 
    //    public ConstructorExample() // This is a class constructor
    //    {
            
    //    }
    //    public static void ConstructorExampleMain()
    //    {
    //        #region  This invokes the constructor.
    //        MyObject localObjectinvokes = new MyObject(); //MyObject() invokes the constructor
    //        #endregion
    //        // First create an object.
    //        #region Default constructor
    //        MyObject localObject = new MyObject();
    //        //localObject use the default constructor that C# use to assign values in its members.
    //        #endregion
    //        Console.WriteLine("localObject.n is {0}",localObject.n);
    //        if (localObject.nextObject == null)
    //        {
    //            Console.WriteLine("“localObject.nextObject is null");
    //        }
    //        // Wait for user to acknowledge the results.
    //        Console.WriteLine("Press Enter to terminate...");
    //        Console.Read();
    //    }
    //}
    //public class MyObject
    //{
    //    internal int n;
    //    internal MyObject nextObject;
    //}
    #endregion
}
