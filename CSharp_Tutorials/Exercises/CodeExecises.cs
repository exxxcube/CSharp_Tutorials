using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharp_Tutorials.Exercises
{
    class CodeExecises
    {
        public static void Hello()
        {
            string name = "Exxxcube";
            Console.WriteLine("Hello " +name);
        }
        public static void ResultOfTwoNumbers(int i, int j)
        {            
            Console.WriteLine("Sum: {0} "                 , i + j);
            Console.WriteLine("Subtract: {0} "            , i - j);
            Console.WriteLine("SumMultiplication: {0} "   , i * j);
            Console.WriteLine("Divide: {0} "              , i / j);
        }
        public static void ResultOfTheSpecifiedOperations()
        {
            int i = -1 + 4 * 6;
            int j = (35 + 5) % 7;
            int x = 14 + -4 * 6 / 11;
            int y = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public static void ProgramToSwap()
        {
            //Write a C# Sharp program to swap two numbers.
            Console.WriteLine("Input the First Number: ");
            string s = Console.ReadLine();
            Console.WriteLine("Input the Second Number: ");
            string v = Console.ReadLine();
            Console.WriteLine("After Swapping");
            Console.WriteLine("First Number: "+v);
            Console.WriteLine("Second Number: "+s);
        }
        public static void OutputOfMultiplication()
        {
            //Write a C# Sharp program to print the output of multiplication of
            //three numbers which will be entered by the user.
            string x = Console.ReadLine();
            char[] separator = { ' ', '\n', '\t' };           
            string[] split = x.Split(separator);
            split = split.Where(c => !string.IsNullOrEmpty(c)).ToArray();
            Console.WriteLine(Multiply(split));
        }        
        public static void PrintOperatorResult()
        {
            //Write a C# Sharp program to print on screen the output of adding,
            //subtracting, multiplying and dividing of two numbers which will
            //be entered by the user.
            Console.WriteLine("Input the first number:");
            string s = Console.ReadLine();
            int x; int.TryParse(s, out x);
            Console.WriteLine("Input the second number:");
            string v = Console.ReadLine();
            int y; int.TryParse(v, out y);
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            Console.WriteLine("{0} % {1} = {2}", x, y, x % y);
        }
        public static void MultiplicationTable(int n)
        {
            //Write a C# Sharp program that takes a number as input and print
            //its multiplication table.
            const int y = 10;
            Console.WriteLine("Multiplication of {0}", n);
            for (int i = 0; i <= y; i++)
            {                
                Console.WriteLine("{0} * {1} = {2}",n,i,n*i);
            }
        }
        public static void AverageOfFourInputs()
        {
            //Write a C# Sharp program that takes four numbers a
            //input to calculate and print the average.            
            double temp = 0;
            int[] arryNum = new int[4];
            Console.WriteLine("Enter the First number: ");
            string x = Console.ReadLine();
            int.TryParse(x, out arryNum[0]);
            Console.WriteLine("Enter the Second number: ");
            string y = Console.ReadLine();
            int.TryParse(y, out arryNum[1]);
            Console.WriteLine("Enter the Third number: ");
            string s = Console.ReadLine();
            int.TryParse(s, out arryNum[2]);
            Console.WriteLine("Enter the Forth number: ");
            string str = Console.ReadLine();
            int.TryParse(str, out arryNum[3]);
            for (int inner = 0; inner < arryNum.Length; inner++)
            {
                temp += arryNum[inner];
            }            
            Console.WriteLine("The average of {0} , {1} , {2} , {3} is: {4}",
                arryNum[0], arryNum[1],arryNum[2], arryNum[3], temp / arryNum.Length);
        }
        public static void ThreeNumbers()
        {
            // Write a C# Sharp program to that takes three numbers(x,y,z)
            // as input and print the output of (x+y).z and x.y + y.z.
            int[] arrNum = new int[3];
            Console.Write("Enter first number: ");
            string s = Console.ReadLine();
            int.TryParse(s, out arrNum[0]);
            Console.Write("Enter second number: ");
            string v = Console.ReadLine();
            int.TryParse(v, out arrNum[1]);
            Console.Write("Enter third number: ");
            string str = Console.ReadLine();
            int.TryParse(str, out arrNum[2]);
            Console.WriteLine("Result of specified numbers {0}"+
                              ", {1}, and {2}, ({0} + {1}).{2} is {3} and "+
                              "{0} . {1} + {1} . {2} is {4}",arrNum[0], arrNum[1],
                              arrNum[2],(arrNum[0]+ arrNum[1])* arrNum[2],
                              arrNum[0]* arrNum[1]+ arrNum[1]* arrNum[2]);
        }
        public static void YouLookOlder()
        {
            //Write a C# Sharp program that takes an age (for example 20) as
            //input and prints something as "You look older than 20".
            Console.Write("Enter your age: ");
            string x = Console.ReadLine();
            Console.WriteLine("You look older than {0}",x);
        }
        public static void FourTimesInARow(int n)
        {
            //Write a C# program to that takes a number as input
            //and display it four times in a row (separated by blank spaces)
            //and then four times in the next row, with no separation.
            //You should do it two times:
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    Console.Write(n + " ");                    
                }
                Console.WriteLine();
                for (int k = 0; k <= 4; k++)
                {
                    Console.Write(n);                    
                }
                Console.WriteLine();
            }
        }
        public static void RectangleMadeOfNumbers()
        {
            //Write a C# program that takes a number as input and then display
            //a rectangle of 3 columns wide and 5 rows tall using that digit.
            Console.Write("Enter a number: ");
            string s = Console.ReadLine();
            int col = 3;            

            for (int i = 0; i < col; i++)
                Console.Write(s);
            Console.WriteLine();
            for (int i = 0; i < col; i++)
                Console.WriteLine(s.PadRight(col - 1)+s);
            for (int i = 0; i < col; i++)
                Console.Write(s);
        }
        public static void TemperatureConverter()
        {
            //Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
            Console.Write("Enter amount of celsius: ");
            string s = Console.ReadLine();
            double i; double.TryParse(s,out i);
            Console.WriteLine("Kelvin = {0}",CelsiusToKelvin(i));
            Console.WriteLine("Fahrenheit = {0}",CelsiusToFahrenheit(i));            
        }
        public static string LetterRemover(char c)
        {
            //Write a C# program remove specified a character from
            //a non-empty string using index of a character.
            string stringExample = "w3resource";
            StringBuilder s = new StringBuilder(stringExample);
            int indexOfString = stringExample.IndexOf(c);
            s.Remove(indexOfString, 1);
            return s.ToString();
        }
        
        #region UsefulMethods
        public static double CelsiusToFahrenheit(double celsius)
        {
            double rslt = (celsius * 1.8) + 32;
            return rslt;
        }
        public static double CelsiusToKelvin(double celsius)
        {
            const double f = 273.15;
            return celsius + f;
        }
        public static double FahrenheitToKelvin(double fahrenheit)
        {
            double rslt = (fahrenheit - 32) * 0.56 + 273.15;
            return rslt;
        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double rslt = (fahrenheit - 32) * 0.56;
            return rslt;
        }
        public static double KelvinToCelsius(double kelvin)
        {
            double rslt = kelvin - 273.15;
            return rslt;
        }
        public static double KelvinToFarenheit(double kelvin)
        {
            double rslt = (kelvin - 273.15) * (9 / 5) + 32;
            return rslt;
        }       
        public static int Multiply(string[] n)
        {
            int rslt = 1;
            for (int i = 0; i < n.Length; i++)
            {
                rslt *= Convert.ToInt32(n[i]);
            }
            return rslt;
        }
        #endregion
    }
}
