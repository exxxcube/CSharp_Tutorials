using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace PolymorphismDifferentclassDifferentmethod
{
    public class MyClass
    {
        public static void AMethod1()
        { 
        }
        public void AMethod2()
        {            
        }
    }
    public class UrClass
    {
        public static void AMethod1()
        {
        }
        public void AMethod2()
        {
        }
    }
    public class MyClassProg
    {
        public static void MyClassMain()
        {
            UrClass.AMethod1();  // Call static method.
            // Invoke the MyClass.AMethod2() instance method:
            MyClass mcObject = new MyClass();
            mcObject.AMethod2();
        }
    }
}
