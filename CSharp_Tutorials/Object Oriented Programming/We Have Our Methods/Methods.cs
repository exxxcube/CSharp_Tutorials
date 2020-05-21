using CSharp_Tutorials.Class;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharp_Tutorials.Object_Oriented_Programming.We_Have_Our_Methods
{
    class Methods
    {
        public int anInt;               // Nonstatic
        public static int staticInt;    // Static
        #region Defining and Using a Method
        public void InstanceMethod() // This is a Nonstatic method
        {
            Console.WriteLine("this is an Instance method"); 
        }
        public static void ClassMethod() // Static
        {
            Console.WriteLine("this is a Class method");
        }
        #endregion
        #region Passing an argument to a method
        public static void Output(string someString)
        {
            Console.WriteLine("Output() was passed the argument: "+someString);
        }
        #endregion
        #region Passing multiple arguments to methods
        public static void AverageAndDisplayMain()
        {
            // Access the member method.
            AverageAndDisplayMethod("grade 1",3.5,"grade 2",4.0);
            Console.WriteLine();
            // Access the second version of the method.
            AverageAndDisplayMethod(3.5,4.0);
            // Wait for user to acknowledge.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
        public static void MethodsWithDefaultArgumentsMain()
        {
            // Access the member method.
            Console.WriteLine(DisplayRoundedDecimal(12.345678M,3));
            // Wait for user to acknowledge.
            Console.WriteLine("Press Enter to terminate ...");
            Console.Read();
        }
        // int numberOfSignificantDigits = 2 is an example of default value in the parameter
        private static string DisplayRoundedDecimal(decimal value, int numberOfSignificantDigits = 2)
        {
            
            // First round off the number to the specified number
            // of significant digits.
            decimal roundedValue = decimal.Round(value, numberOfSignificantDigits);
            // Convert that to a string.
            string s = roundedValue.ToString();
            return s;
        }
        //private static string DisplayRoundedDecimal(decimal value) 
        //{
        //    // Invoke DisplayRoundedDecimal(decimal, int) specifying
        //    // the default number of digits.
        //    string s = DisplayRoundedDecimal(value, 2);
        //    return s;
        //}
        // AverageAndDisplayMethod -- Average two numbers with their
        // labels and display the results.
        private static void AverageAndDisplayMethod(string s1, double d1, string s2, double d2) 
        {
            double average = (d1 + d2) / 2;
            Console.WriteLine("The average of " + s1 + 
                              " whose value is " + d1
                               + " and "        + s2
                               +" whose value "
                               +"is "           + d2
                               + " is "         + average);
        }
        //This is a AverageAndDisplayMethod Overloading method
        private static void AverageAndDisplayMethod(double d1, double d2)
        {
            double average = (d1 + d2) / 2;
            Console.WriteLine("The average of "+ d1
                + " and "                      + d2
                + " is "                       + average);
        }
        #endregion
        #region Returning Values
        public static void DisplayRation(double numerator, double denominator)
        {
            // If the denominator is zero . . .
            if (denominator == 0.0)
            {
                // . . .output an error message and . . .
                Console.WriteLine("The denominator of a ratio cannot be 0");
                // . . .return to the caller.
                return;
            }
            // This code is executed only if denominator is nonzero.
            double ratio = numerator / denominator;
            Console.WriteLine("The ratio of " + numerator
                               + " over " + denominator
                               + " is "+ ratio);
        }// If the denominator isn’t zero, the method exits here.
        private static double Average(double d1, double d2)
        {
            double average = (d1 + d2) / 2;
            // You need a return statement to return a value
            return average;
        }
        public static void AverageMain()
        {
            double v1 = 1.0;
            double v2 = 3.0;
            double averageValue = Average(v1,v2);
            Console.WriteLine("The average of " + v1 + " and "+ v2 + " is " + averageValue);           
            //This also works
            Console.WriteLine("The average of " + v1 + " and " + v2 + " is " + Average(v1,v2));
        }
        #endregion
    }
    class CalculateInterestTableWithMethods
    {
        public static void CalculateInterestTableWithMethodsMain()
        {
            // Section 1 -- Input the data you need to create the table.
            decimal principal = 0M;
            decimal interest = 0M;
            decimal duration = 0M;
            InputInterestData(ref principal,ref interest,ref duration);
            // Section 2 -- Verify the data by mirroring it back to the user.
            Console.WriteLine();
            Console.WriteLine("Principal        = "+ principal);
            Console.WriteLine("Interest         = " + interest +"%");
            Console.WriteLine("Duration         = " + duration+ "years");
            Console.WriteLine();
            // Section 3 -- Finally, output the interest table.
            OutputInterestTable(principal, interest, duration);
            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
        // InputInterestData -- Retrieve from the keyboard the
        // principal, interest, and duration information needed
        // to create the future value table. (Implements Section 1.)
        public static void InputInterestData(ref decimal principal,
                                             ref decimal interest,
                                             ref decimal duration)
        {
            // 1a -- Retrieve the principal.
            principal = InputPositiveDecimal("principal");
            // 1b -- Now enter the interest rate.
            interest = InputPositiveDecimal("interest");
            // 1c -- Finally, the duration
            duration = InputPositiveDecimal("duration");
        }
        // InputPositiveDecimal -- Return a positive decimal number
        // from the keyboard.
        public static decimal InputPositiveDecimal(string prompt)
        {
            // Keep trying until the user gets it right.
            while (true)
            {
                // Prompt the user for input.
                Console.Write("Enter " + prompt + ": ");
                // Retrieve a decimal value from the keyboard.
                string input = Console.ReadLine();
                decimal value = Convert.ToDecimal(input);
                // Exit the loop if the value that’s entered is correct.
                if (value > 0)
                {
                    // Return the valid decimal value entered by the user.
                    return value;
                }
                // Otherwise, generate an error on incorrect input.
                Console.WriteLine(prompt + " cannot be negative");
                Console.WriteLine("Try again");
                Console.WriteLine();
            }            
        }
        // OutputInterestTable -- Given the principal and interest,
        // generate a future value table for the number of periods
        // indicated in duration. (Implements Section 3.)
        public static void OutputInterestTable(decimal principal,
                                               decimal interest,
                                               decimal duration)
        {
            for (int year = 0; year <= duration; year++)
            {
                // Calculate the value of the principal plus interest.
                decimal interestPaid;
                interestPaid = principal * (interest / 100);
                // Now calculate the new principal by adding
                // the interest to the previous principal.
                principal = principal + interestPaid;
                // Round off the principal to the nearest cent.
                principal = decimal.Round(principal, 2);
                // Output the result.
                Console.WriteLine(year + "-" + principal);
            }
        }
    }
}
