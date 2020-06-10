using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
using CSharp_Tutorials.Class;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Security;
using System.Net.Mail;
using System.Data;

namespace CSharp_Tutorials.Exercises
{
    public class CodeExecises
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
        public static string NewString(string s)
        {
            //16. Write a C# program to create a new 
            //string from a given string where the first and last
            //characters will change their positions.
            char temp = s[s.Length-1];
            char firstChar = s[0];            
            return temp + s.Substring(1, s.Length - 2) + firstChar;
        }
        public static string OneCharacterFromFirstToLast(string s)
        {
            //Write a C# program to create a new string from a given string (length 1 or more )
            //with the first character added at the front and back.
            char temp = s[0];
            return temp + s + temp;
        }
        public static bool NegativeAndPositive(int x, int y)
        {
            // 18.Write a C# program to check two given integers and
            // return true if one is negative and one is positive
            if ((x > 0 && y < 0) || (x < 0 && y > 0))
                return true;

            return false;
        }
        public static int TripleSum(int x, int y)
        {
            // 19.Write a C# program to compute the sum of two given integers,
            // if two values are equal then return the triple of their sum.
            int temp;
            if (x == y)
                temp = (x + y) * 3;
            else
                temp = x + y;

            return temp;
        }
        public static int GreaterThanSecondNumber(int x, int y)
        {
            // 20. Write a C# program to get the absolute value of the difference
            // between two given numbers. Return double the absolute value of the
            // difference if the first number is greater than second number.
            int temp;
            if (x > y)
            {
                temp = (x - y) * 2;
                if(temp < 0)
                    return temp * -1;
                return temp;
            }
            else
                return (x - y) * -1;            
        }
        public static bool IfTwenty(int x, int y)
        {
            // 21. Write a C# program to check the sum of the two given integers and
            // return true if one of the integer is 20 or if their sum is 20.
            if (x == 20 || y == 20)
                return true;
            if ((x + y) == 20)
                return true;

            return false;
        }
        public static bool WithinTwentyOfOneHunderd(int n)
        {
            //22. Write a C# program to check if an given integer is within 20 of 100 or 200.
            int checkIn100 = n - 100;
            int checkIn200 = n - 200;

            if ((checkIn100 * -1) <= 20 || (checkIn200 * -1) <= 20)          
                return true;
            return false;
        }
        public static string LowerCase(string s)
        {
            //23. Write a C# program to convert a given string into lowercase.
            return s.ToLower();
        }
        public static string LongestWord(string s)
        {
            //24. Write a C# program to find the longest word in a string.
            char[] arrayOfSeparators = { '\t', ' ', '\n' };
            string[] arr = s.Split(arrayOfSeparators);
            int startingPoint = 0;
            int temp = 0;
            foreach (string item in arr)
            {
                if (item.Length > startingPoint)
                {
                    temp = Array.IndexOf(arr,item);
                    startingPoint = item.Length;
                }
            }
            //int i = 0;
            //for (int inner = 0; inner < arr.Length; inner++)
            //{
            //    for (int outter = 0; outter < arr.Length; outter++)
            //    {
            //        if (arr[inner].Count() > arr[outter].Count())
            //            i = inner;
            //    }
            //}            
            return arr[temp];
        }
        public static void OddNumbers(int n)
        {
            //25. Write a C# program to print the odd numbers from 1 to 99.
            //Prints one number per line.
            for (int i = 1; i <= n; i++)
            {
                if((i % 2) == 1)
                    Console.WriteLine(i);
            }
        }
        public static void First500PrimeNumbers()
        {
            //26.Write a C# program to compute the sum of the first 500 prime numbers.
            long temp = 0;
            int starting = 2;
            int ctrl = 0;
            while (ctrl < 500)
            {
                if (isPrime(starting))
                {
                    temp += starting;
                    ctrl++;
                }
                starting++;
            }
            Console.WriteLine(temp);
        }
        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));
            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; i++)
            {
                if ((n % i) == 0) return false;
            }
            return true;
        }
        public static int DigitsOfAnInteger(int n)
        {
            //27. Write a C# program and compute the sum of the digits of an integer.
            string s = n.ToString();
            int temp = 0;
            for (int i = 0; i < s.Length; i++)
            {
                temp += Convert.ToInt32(s[i].ToString());
            }
            return temp;
        }
        public static void ReverseAString(string s)
        {
            //28. Write a C# program to reverse the words of a sentence.            
            char[] arr = { '\t', ' ', '\n' };
            string[] temp = s.Split(arr);
            Array.Reverse(temp);
            foreach (var item in temp)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();
        }
        public static long SpecifiedFile(string s)
        {
            //29. Write a C# program to find the size of a specified file in bytes.
            FileInfo f = new FileInfo(s);                        
            return f.Length;
        }
        public static int HexToDec(string s)
        {
            //30. Write a C# program to convert a hexadecimal number to decimal number.
            #region Manual Computation
            //char[] arr = s.ToArray();
            //int max = s.Length;
            //int temp = 0;
            //int x = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    switch (arr[i])
            //    {
            //        case 'A':
            //            x = 10;
            //            break;
            //        case 'B':
            //            x = 11;
            //            break;
            //        case 'C':
            //            x = 12;
            //            break;
            //        case 'D':
            //            x = 13;
            //            break;
            //        case 'E':
            //            x = 14;
            //            break;
            //        case 'F':
            //            x = 15;
            //            break;
            //        default:
            //            x = Convert.ToInt32(arr[i].ToString());
            //            break;
            //    }
            //    temp += (x * (int)Math.Pow(16, max - 1));
            //    max--;
            //}
            #endregion
            #region Simplied Computation
            int temp = int.Parse(s, System.Globalization.NumberStyles.HexNumber);
            #endregion

            return temp;
        }
        public static int[] MultiplyElements(int[] x, int[] y)
        {
            //31. Write a C# program to multiply corresponding elements of two arrays of integers.
            int max = x.Length;
            if (x.Length < y.Length) // Check who has the greater length
                max = y.Length;
            int[] temp = new int[max];
            for (int i = 0; i < max; i++)
            {
                temp[i] = x[i] * y[i];
            }
            return temp;
        }
        public static string FourCopiesString(string s)
        {
            // 32. Write a C# program to create a new string of four copies,
            // taking last four characters from a given string.
            // If the length of the given string is less than 4 return the original one.
            if (s.Length < 4)
                return s;
            string temp = s.Substring(s.Length - 4, 4);
            return String.Format(temp + temp + temp + temp);
        }
        public static bool MultipleOfTheeOrSeven(int i)
        {
            // 33.Write a C# program to check if a given positive number
            // is a multiple of 3 or a multiple of 7.
            if ((i % 3) == 0 || (i % 7) == 0)
                return true;
            return false;   
        }
        public static bool SpecifiedWord(string sentence,string firstword)
        {
            // 34. Write a C# program to check if a string starts with a specified word.
            string temp = sentence.Substring(0, firstword.Length);
            if (temp == firstword)
                return true;
            return false;
        }
        public static bool TwoGivinNumbers(int i, int j)
        {
            //35.Write a C# program to check two given numbers
            //where one is less than 100 and other is greater than 200.
            if ((i < 100) && (j > 200))
                return true;
            return false;
        }
        public static bool ChekingInteger(int i, int j)
        {
            // 36.Write a C# program to check if an integer (from the two given integers)
            // is in the range -10 to 10.
            if ((i >= -10 && i <= 10) && (j >= -10 && j <= 10))
                return true;
            return false;
        }
        public static string CheckForHP(string s)
        {
            // 37. Write a C# program to check if "HP"
            // appears at second position in a string and returns the string without "HP".
            if (s.Substring(1, 2) == "HP")
                return String.Format(s.Remove(1,2));
            return null;
        }
        public static string NewStringofTwoCharacters(string s)
        {
            // 38.Write a C# program to get a new string of two characters
            // from a given string. The first and second character of the
            // given string must be "P" and "H", so PHP will be "PH".
            if (s.Substring(0, 2) == "PH")
                return String.Format(s.Substring(0, 2));
            return null;
        }
        public static string LargestandLowest(int i, int j, int x)
        {
            // 39. Write a C# program to find the largest
            // and lowest values from three integer values.
            int[] arr = { i, j, x}; //Pwede di ay ni HEHEHEHEHE!!
            Array.Reverse(arr);
            return String.Format("The Largest is {0} and the lowest is {1}", arr[0], arr[arr.Length - 1]);
        }
        public static int CheckNearestValueof20(int i, int j)
        {
            // 40. Write a C# program to check the nearest
            // value of 20 of two given integers and return 0
            // if two numbers are same.
            if (i == j)
                return 0;
            else
            {
                if (i <= 20 && j <= 20)
                {
                    int[] arr = { i, j };
                    arr.Reverse();
                    return arr[0];
                }
            }
            return 0;
        }
        public static bool ContainsLetterW(string s)
        {
            // 41. Write a C# program to check if a given string
            // contains ‘w’ character between 1 and 3 times.
            int count = 0;
            foreach (var item in s)
            {
                if (s.Contains('w'))
                    count++;
            }
            if (count == 1 || count == 3)
                return true;
            return false;
        }
        public static string FourLowerCase(string s)
        {
            // 42. Write a C# program to create a new string where the first 4
            // characters will be in lower case. If the string is less than 4
            // characters then make the whole string in upper case.

            // Good practice means avoiding modifying an input parameter.
            // Modify a copy.
            string temp = s;
            if (temp.Length < 4)
                return temp.ToUpper();
            return String.Format(temp.Substring(0, 4).ToLower() + temp.Substring(4, temp.Length-4).ToUpper());
        }
        public static bool StringStartsWithw(string s)
        {
            //43. Write a C# program to check if a given string
            //starts with "w" and immediately followed by two "ww".
            if (s.Substring(0, 1) == "w")
            {
                if (s.Substring(0, 2) == "ww")
                    return true;
            }
            return false;
        } //Galibug ko ani
        public static string OddPosition(string s)
        {
            // 44. Write a C# program to create a new string of
            // every other character (odd position) from the first position of a given string.
            char[] stemp = s.ToArray();
            string rslt = "";
            int count = 0;
            while (true)
            {
                rslt += stemp[count].ToString();
                count += 2;
                if (count == stemp.Length)
                    break;
            }
            return rslt;
        }
        public static int CountNumbers(int i, int[] listonumbers)
        {
            //45. Write a C# program to count a specified number in a given array of integers.
            int itemp = i;
            int[] arrtemp = listonumbers;
            int count = 0;
            foreach (var item in arrtemp)
            {
                if (item == itemp)
                    count++;
            }
            return count;
        }
        public static bool AppearsInTheList(int i, int[] listofnumbers)
        {
            // 46. Write a C# program to check if a number appears as either the first or
            // last element of an array of integers and the length is 1 or more.
            string itemp = i.ToString();
            int[] arrtemp = listofnumbers;
            if (itemp.ToCharArray().Length > 1)
            {
                if ((arrtemp[arrtemp.Length - 1] == Convert.ToInt32(itemp)) 
                    || (arrtemp[0].ToString() == itemp))
                    return true;
            }
            return false;
        }
        public static int SumOfAllTheArray(int[] iarr)
        {
            //47. Write a C# program to compute the sum of all the elements of an array of integers.
            int[] arrtemp = iarr;
            int sumofallarr = 0;
            foreach (var item in arrtemp)
                sumofallarr += item;
            return sumofallarr;
        }
        public static bool AppearsInFirstAndLast(int i, int[] iarr)
        {
            // 48. Write a C# program to check if the first element
            // and the last element are equal of an array of integers and the length is 1 or more.
            string itemp = i.ToString();
            int[] arrtemp = iarr;
            if (itemp.ToCharArray().Length >= 1)
            {
                if ((arrtemp[arrtemp.Length - 1] == Convert.ToInt32(itemp))
                    && (arrtemp[0].ToString() == itemp))
                    return true;
            }
            return false;
        }
        public static bool CheckTheTwoArrFirstAndLast(int[] i, int[] j)
        {
            // 49. Write a C# program to check if the first element
            // or the last element of the two arrays ( length 1 or more) are equal.
            int[] iarrtemp = i;
            int[] jarrtemp = j;
            if (i.Length < 1 || j.Length < 1)
                return false;
            if (iarrtemp[iarrtemp.Length - 1] == jarrtemp[jarrtemp.Length - 1] ||
               iarrtemp[0] == jarrtemp[0])
                return true;
            return false;
        }
        public static int[] Rotate_an_Array(int[] i)
        {
            // 50. Write a C# program to rotate an array (length 3) of integers in left direction.
            int[] itemp = i;
            int temp = 0;
            for (int inner = 0; inner < itemp.Length-1; inner++)
            {
                temp = itemp[inner];
                itemp[inner] = itemp[inner + 1];
                itemp[inner + 1] = temp;
            }            
            return itemp;
        }
        public static int BetweenTheFirstAndTheLast(int[] arri)
        {
            // 51. Write a C# program to get the larger value between first
            // and last element of an array (length 3) of integers.
            int[] itemp = arri;
            int i = itemp[0]; int j = itemp[itemp.Length - 1];
            if (i <= j)
                return j;
            return i;
        }
        public static int[] MiddleArrays(int[] arri,int[] arry,int[] arrz)
        {
            // 52. Write a C# program to create a new array of length containing
            // the middle elements of three arrays (each length 3) of integers.
            int middle1 = ((1 + arri.Length) / 2) - 1 ; int middle2 = ((1 + arry.Length) / 2) - 1;
            int middle3 = ((1 + arrz.Length) / 2)- 1;
            int[] temp = { arri[middle1], arry[middle2], arrz[middle3] };

            return temp;
        }
        public static bool ContainsOddNumber(int[] arri)
        {
            //53. Write a C# program to check if an array contains an odd number.
            int[] temp = arri;
            foreach (var item in temp)
            {
                if (item % 2 != 0)
                    return true;
            }
            return false;
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
