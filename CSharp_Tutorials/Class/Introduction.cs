using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorials.Class
{
    class Introduction
    {
        public void intro()
        {
            // Prompt user to enter a name.
            Console.WriteLine("Enter your name, please:");
            // Now read the name entered.
            string name = Console.ReadLine();
            // Greet the user with the name that was entered.
            Console.WriteLine("Hello, " + name);
            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }

        // Types of integers
        public void Integers()
        {
            //sbyte, 1 byte, range to –128 to 127
            sbyte sb = 12;
            Console.WriteLine(sb);

            //byte, 1 byte, range to 0 to 255
            byte b = 255;
            Console.WriteLine(b);

            //short, 2 bytes, range to –32,768 to 32,767
            short sh = 12345;
            Console.WriteLine(sh);

            //ushort, 2 bytes, 0 to 65,535 no negative numbers
            ushort ush = 62345;
            Console.WriteLine(ush);

            //int, 4 bytes, range to –2 billion to 2 billion
            int n = 1234567890;
            Console.WriteLine(n);

            //uint, 4 bytes, 0 to 4 billion (exact values
            //listed in the Cheat Sheet on
            //this book’s Web site)
            uint un = 3234567890U;
            Console.WriteLine(un);

            //long, 8 bytes, –10^20 to 10^20 — “a whole lot”
            long l = 123456789012L;
            Console.WriteLine(l);

            //Ulong, 8 bytes, 0 to 2 × 1020
            ulong ul = 123456789012UL;
            Console.WriteLine(ul);
        }

        //Types of floats
        public void Float()
        {
            //float 8 bytes, range 1.5 * 10^–45 to 3.4 * 10^38
            float f = 1.120f;
            Console.WriteLine(f);

            //double 16 bytes, range 5.0 * 10^–324 to 1.7 * 10^308
            double d = 1.20;
            Console.WriteLine(d);
            
            //decimal, range 10^-28 to 10^28
            decimal m1 = 100; // Good, 100 is an int and C# will convert it to decimal, since the datatype of m1 is decimal
            decimal m2 = 100M; // Better because theres no need for convertion.
            Console.WriteLine("Needs to convert to decimal "+ m1);
            Console.WriteLine("No need to convert "+m2);
        }

    }
}
