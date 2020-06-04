using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PassingArgsNameSpace
{
    #region PassingArgs but no base keyword
    //public class PassingArgs
    //{
    //    public static void PassingArgsMain()
    //    {
    //        Console.WriteLine("Invoking SubClass() default");
    //        SubClass sc1 = new SubClass();
    //        Console.WriteLine("\nInvoking SubClass(int)");
    //        SubClass sc2 = new SubClass(0);
    //        // Wait for user to acknowledge.
    //        Console.WriteLine("Press Enter to terminate...");
    //        Console.Read();
    //    }
    //}
    //public class BaseClass
    //{
    //    public BaseClass()
    //    {
    //        Console.WriteLine("Constructing BaseClass(default)");
    //    }
    //    public BaseClass(int i)
    //    {
    //        Console.WriteLine("Constructing BaseClass(int)");
    //    }
    //}
    //public class SubClass : BaseClass
    //{
    //    public SubClass()
    //    {
    //        Console.WriteLine("Constructing SubClass(default)");
    //    }
    //    public SubClass(int i)
    //    {
    //        Console.WriteLine("Constructing SubClass(int)");
    //    }
    //}
    #endregion
    #region MyRegion
    public class PassingArgsWithbase
    {
        public static void PassingArgsMain()
        {
            Console.WriteLine("Invoking SubClass()");
            SubClass sc1 = new SubClass();
            Console.WriteLine("\ninvoking SubClass(1, 2)");
            SubClass sc2 = new SubClass(1,2);
            // Wait for user to acknowledge.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Constructing BaseClass(default)");
        }
        public BaseClass(int i)
        {
            Console.WriteLine("Constructing BaseClass({0})",i);
        }
    }
    public class SubClass : BaseClass
    {
        public SubClass()
        {
            Console.WriteLine("Constructing SubClass(default)");
        }
        public SubClass(int i1, int i2) : base(i1)
        {
            Console.WriteLine("Constructing SubClass({0}, {1})",i1,i2);
        }
    }
    #endregion
}
