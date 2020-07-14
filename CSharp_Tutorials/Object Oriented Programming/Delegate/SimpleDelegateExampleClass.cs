using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
// SimpleDelegateExample -- Demonstrate a simple delegate callback.
namespace SimpleDelegateExample
{
    class SimpleDelegateExampleProg
    {
        delegate int MyDelType(string name);    // Inside class or inside namespace
        public static void SimpleDelegateExampleMain(string[] args)
        {
            // Create a delegate instance pointing to the CallBackMethod below.
            // Note that the callback method is static, so you prefix the name
            // with the class name, Program.
            MyDelType del = new MyDelType(SimpleDelegateExampleProg.CallBackMethod);
            // Call a method that will invoke the delegate.
            UseTheDel(del, "hello");
            // Wait for user to acknowledge results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
        // UseTheDel -- A “workhorse” method that takes a MyDelType delegate
        // argument and invokes the delegate. arg is a string I want to pass
        // to the delegate invocation.
        private static void UseTheDel(MyDelType del, string arg)
        {
            if (del == null) return;  // Don’t invoke a null delegate!
            // Here’s where you invoke the delegate.
            // What’s written here? A number representing the length of arg.
            Console.WriteLine("UseTheDel writes {0}",del(arg));
        }
        public static int CallBackMethod(string stringPassed)
        {
            // Leave tracks to show you were here.
            // What’s written here? stringPassed.
            Console.WriteLine("CallBackMethod writes: {0}",stringPassed);
            // Return an int.
            return stringPassed.Length;     // Delegate requires an int return.
        }
    }
}
