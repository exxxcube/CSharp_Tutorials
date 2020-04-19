using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorials.Class
{
    #region Data Types Example
    class Introduction
    {
       

        
        public void Intro()
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
            Console.WriteLine("Needs to convert to decimal " + m1);
            Console.WriteLine("No need to convert " + m2);
        }
        //Bool
        public void Bool()
        {
            //bool data type example
            bool thisIsABool = true;
            Console.WriteLine(thisIsABool);
        }
        #endregion
    #region Characters and Strings
        //Character Types
        //character as 'char'
        public void CharactersAndSpecialCharacters()
        {
            //This is an example of character
            char c = 'a';
            //Examples of Special Characters
            Console.WriteLine("This is\n newline"); // \n is New line
            Console.WriteLine("This is \ttab"); // \t is Tab
            Console.WriteLine("This is a \0 null character"); // \0 is a null character
            Console.WriteLine("This \ris a Carriage return "); // \r is a Carriage return
            Console.WriteLine("This is a backslash \\"); // \\ is a backslash 
        }
        //Strings
        public void StringsExample()
        {
            //Declaring now, initialize later
            string someString1;
            someString1 = "this is a string";
            //Or initialize when declared - preferable
            string someString2 = "this is a string";

            string someString3 = "This is a line\nand so is this";
            Console.WriteLine(someString3);

            string EmptyString = String.Empty; // This is an Empty string, safe from misinterpretation
        }
        #endregion
    #region Declaring Numeric Constants
        //Table 2-4 Common Constants Declared along with Their Types
        //Constant Type
        //1 int
        //1U unsigned int
        //1L long int (avoid lowercase l; it’s too much like the digit 1)
        //1.0 double
        //1.0F float
        //1M decimal
        //true bool
        //false bool
        //‘a’ char
        //‘\n’ char (the character newline)
        //‘\x123’ char (the character whose numeric value is hex 123)1
        //“a string” string
        //“” string (an empty string); same as String.Empty
        #endregion
    #region Changing Types: The Cast
        public void TheCast()
        {
            //int intValue = 10;
            //long longValue;
            //longValue = intValue; // This is ok and this is called implicit type convertion

            long longValue = 10;
            int intValue;
            //intValue = longValue; // This is illegal.
            intValue = (int)longValue; // But you can do a cast like this example.
        }
        #endregion
    #region Letting the C# Compiler Infer Data Types
        public void VarExample()
        {
            var i = 5;
            var s = "Hello C# 4.0";
            var d = 1.0;
            Console.WriteLine("{0},{1},{2}", i, s, d);
            //Now the compiler infers the data type for you — it looks at the stuff on the
            //right side of the assignment to see what type the left side is.
        }
        #endregion
    #region Pulling Strings
        public void PullingStrings()
        {
            String s1 = "abcd"; // Assign a string literal to a String obj.
            string s2 = s1;     // Assign a String obj to a string variable.
        }
        public void StringClassExample()
        {
            // Create a student object.
            Student s1 = new Student();
            s1.Name = "Jenny";
            // Now make a new object with the same name.
            Student s2 = new Student();
            s2.Name = s1.Name;
            // “Changing” the name in the s1 object does not
            // change the object itself because ToUpper() returns
            // a new string without modifying the original.
            s2.Name = s1.Name.ToUpper();
            Console.WriteLine("s1 - " +s1.Name + ", s2 - " +s2.Name);
            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
            //Among the string-related tasks I cover here are the ones described in this list:
            // ✦ Comparing strings — for equality or for tasks like alphabetizing
            // ✦ Changing and converting strings in various ways: replacing part of a
            //string, changing case, and converting between strings and other things
            // ✦ Accessing the individual characters in a string
            // ✦ Finding characters or substrings inside a string
            //✦ Handling input from the command line
            //✦ Managing formatted output
            //✦ Working efficiently with strings using the StringBuilder
   
}
    class Student // this class is for String Example
    {
        public String Name;
    }
    #endregion
    #region Comparing Strings, Looping with Strings
    class StringCom
    {
        public void StringCompare()
        {
            string a = "programming";
            string b = "Programming";
            if(a != b)
                Console.WriteLine("True");
        }
        public void Equalityforallstrings()
        {
            string a = "programming";
            string b = "Programming";
            int rslt = String.Compare(a, b);
            Console.WriteLine(rslt);
        }
        public void ConvertionStrings()
        {
            string lowcase = "armadillo";
            string upcare = lowcase.ToUpper(); // Use ToUpper to convert the string to UPPERCASE
            Console.WriteLine(upcare);
        }
        public void ConvertingFirstCharacter()
        {
            //What if you want to convert just the first character in a string to uppercase?

            string name = "chuck";
            string propername =
            char.ToUpper(name[0]).ToString() + name.Substring(1, name.Length - 1);
            Console.WriteLine(propername);
            //string samplename = name[0].ToString(); // use this code if you want to use only the first
            // letter of the string
            //Console.WriteLine(samplename);

        }
        public void LoopingWithStrings()
        {
            // use foreach if you want to print the string chartacters one by one.
            string favoriteFood = "cheeseburgers";
            foreach(var item in favoriteFood)
                Console.WriteLine(item);
        }
    }
    #endregion

}
