using System;
using System.Collections.Generic;
using System.Text;

// AbstractInheritance -- The BankAccount class is abstract because
// there is no single implementation for Withdraw.
namespace AbstractInheritance
{
    // AbstractBaseClass -- Create an abstract base class with nothing
    // but an Output() method. You can also say “public abstract.”
    abstract public class AbstractBaseClass // This is an example of abstract class
    {
        // Output -- Abstract method that outputs a string
        abstract public void Output(string outputString);
    }
    // SubClass1 -- One concrete implementation of AbstractBaseClass
     class SubClass1 : AbstractBaseClass // The AbstractBaseClass must be inherit
    {
        public override void Output(string source) // to override the method Output()
        {
            string s = source.ToUpper();
            Console.WriteLine("Call to SubClass1.Output() from within {0}", s);
        }
    }
    // SubClass2 -- Another concrete implementation of AbstractBaseClass
    class SubClass2 : AbstractBaseClass
    {
        public override void Output(string source)
        {
            string s = source.ToUpper();
            Console.WriteLine("Call to SubClass2.Output() from within {0}", s);
        }
    }
    class AbstractInheritanceProg
    {
        private static void Test(AbstractBaseClass ba)
        {
            ba.Output("Test");
        }
        public static void AbstractInheritanceMain()
        {
            // You can’t create an AbstractBaseClass object because it’s
            // abstract -- duh. C# generates a compile-time error if you
            // uncomment the following line.
            // AbstractBaseClass ba = new AbstractBaseClass();
            // Now repeat the experiment with Subclass1.
            Console.WriteLine("\ncreating a SubClass1 object");
            SubClass1 sc1 = new SubClass1();
            Test(sc1);
            // And, finally, a Subclass2 object
            Console.WriteLine("\ncreating a SubClass2 object");
            SubClass2 sc2 = new SubClass2();
            Test(sc2);
            // Wait for user to acknowledge.
            Console.WriteLine("Press Enter to terminate... ");
            Console.Read();
        }
    }
}
