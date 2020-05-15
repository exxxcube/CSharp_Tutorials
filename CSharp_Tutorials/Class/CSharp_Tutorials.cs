using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace CSharp_Tutorials.Class
{
    #region Data Types Example
    class CSharp_Tutorials
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

            //long, 8 bytes, –10^20 to 10^20 — "a whole lot”
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
        //"a string” string
        //"” string (an empty string); same as String.Empty
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
            // "Changing” the name in the s1 object does not
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
        public void IsAllUpper()
        {
            string favoriteFood = "aaa";
            bool isUppercase = true;
            foreach (char c in favoriteFood)
            {
                if (!char.IsUpper(c)) // check if the letter is not upper case
                {
                    isUppercase = false;
                    break;
                }
                else
                {
                    Console.WriteLine("aaa");
                }
            }
        }
        public void SearchStrings() 
        {
            string favoriteFood = "cheeseburgers";
            #region IndexOf
            //IndexOf example
            //int indexOfLetters = favoriteFood.IndexOf('s');
            //Console.WriteLine(indexOfLetters);
            #endregion
            #region IndexOfAny
            ////✦ IndexOfAny() takes an array of chars and searches the string for any
            ////of them, returning the index of the first one found.
            //char[] charsToLookFor = { 'a','b','c' };
            //int indexOfFirstFound = favoriteFood.IndexOfAny(charsToLookFor);
            //Console.WriteLine(indexOfFirstFound);
            ////or you can use this example below
            //int index = favoriteFood.IndexOfAny(new char[] { 'a', 'b', 'c' });
            #endregion
            #region LastIndexOf
            ////LastIndexOf() finds not the first occurrence of a character but the last.
            //int index = favoriteFood.LastIndexOf('s'); // the answer is 12
            //Console.WriteLine(index);
            #endregion
            #region LastIndexOfAny
            ////LastIndexOfAny() works like IndexOfAny(), but starting at the end
            ////of the string.
            //int index = favoriteFood.LastIndexOfAny(new char[] { 'a','b','c'});
            //Console.WriteLine(index);
            #endregion
            #region Contains
            ////Contains() returns true if a given substring can be found within the
            ////target string:            
            //Console.WriteLine(favoriteFood.Contains('c').ToString());
            #endregion
            #region Substring
            //string sub = favoriteFood.Substring(6, favoriteFood.Length - 6);
            //Console.WriteLine(sub);
            #endregion
            #region IsNullOrEmpty
            ////How can you tell if a target string is empty("”) or has the value null ?
            ////(null means that no value has been assigned yet, not even to the empty
            ////string.) Use the IsNullOrEmpty() method, like this:
            //bool notThere = string.IsNullOrEmpty(favoriteFood);
            //Console.WriteLine(notThere);
            ////Or you can do this also
            ////string name = "";                     
            //string name = string.Empty;
            #endregion
        }
    }
    #endregion
    #region Getting Input from the Command Line
    class GettingInput
    {
        public void TrimmingWhiteSpace()
        {
            string example = "asdlkad alskhd";
            // Get rid of any extra spaces on either end of the string.
            string rslt = example.Trim();
            Console.WriteLine(rslt);
        }
        public void ParsingNumericInput()
        {
            string s = Console.ReadLine(); // Keyboard input is string data
            int n = Convert.ToInt32(s); // but you know it’s meant to be a number.
                                        // this is called Parsing.
        }
        // IsAllDigits -- Return true if all characters
        // in the string are digits.
        public static bool IsAllDigits(string raw)
        {
            // First get rid of any benign characters at either end;
            // if there’s nothing left, you don’t have a number.
            string s = raw.Trim(); // Ignore white space on either side.
            if (s.Length == 0) return false;
            // Loop through the string.
            for (int index = 0; index < s.Length; index++)
            {
                // A nondigit indicates that the string probably isn’t a number.
                if (char.IsDigit(s[index]) == false) return false;
            }
            // No nondigits found; it’s probably okay.
            return true;
        }
        public static void CheckAndPrintIsAllDigits()
        {
            // Input a string from the keyboard.
            Console.WriteLine("Enter an integer number");
            string s = Console.ReadLine();
            // First check to see if this could be a number.
            if (!IsAllDigits(s)) // Call the special method.
            {
                Console.WriteLine("Hey! That isn’t a number");
            }
            else
            {
                // Convert the string into an integer.
                int n = Int32.Parse(s);
                //int n;
                //Int32.TryParse(s, out n);
                // Now write out the number times 2.
                Console.WriteLine("2 * " + n + ", = " + (2 * n));
            }
            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
        public void TryCatch_IsNumber()
        {
            while (true)
            {
                try
                {
                    string s = Console.ReadLine();
                    int n = Convert.ToInt32(s);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.Clear();
                }
            }
        }
        public static void Split()
        {
            string input = "e,x,a,m,p,l,e";
            string[] rslt = input.Split(',');// string will split if it has , on it.
            foreach (var item in rslt)
                Console.WriteLine(item);
        }
        public static void HandlingSeriesOfNumbers_Split()
        {
            // Prompt the user to input a sequence of numbers.
            Console.WriteLine("Input a series of numbers separated by commas:");
            // Read a line of text.
            string input = Console.ReadLine();
            Console.WriteLine();
            // Now convert the line into individual segments
            // based upon either commas or spaces.
            char[] dividers = { ',', ' ' };
            string[] segments = input.Split(dividers);
            // Convert each segment into a number.
            int sum = 0;
            foreach (string s in segments)
            {
                // Skip any empty segments.
                if (s.Length > 0)
                {
                    // Skip strings that aren’t numbers.
                    if (IsAllDigits(s))
                    {
                        // Convert the string into a 32-bit int.
                        int num = 0;
                        if (Int32.TryParse(s, out num))
                        {
                            Console.WriteLine("Next number = {0}", num);
                            // Add this number into the sum.
                            sum += num;
                        }
                        // If parse fails, move on to next number.
                    }
                }
            }
            // Output the sum.
            Console.WriteLine("Sum = {0}", sum);
            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
        public static void JoiningStrings()
        {
            string[] brothers = { "Chuck", "Bob", "Steve", "Mike" };
            string theBrothers = string.Join(":", brothers);
            Console.WriteLine(theBrothers);
        }
        public static void PadRight()
        {
            string name = "example";
            Console.WriteLine(name.PadRight(10) + "hello");
        }
        public static void UsingTrimAndPadMethods()
        {
            List<string> names = new List<string> { "Christa ",
                                                    " Sarah",
                                                    "Jonathan",
                                                    "Sam",
                                                    " Schmekowitz" };
            //First output the names as they start out.
            Console.WriteLine("The following names are of "
                               + "different lengths");
            foreach (string s in names)
            {
                Console.WriteLine("This is the name'" + s + "' before");
            }
            Console.WriteLine();

            //This time, fix the strings so they are
            //left justified and all the same length.
            //First, copy the source array into an array thay you can manipulate.
            List<string> stringsToAlign = new List<string>();
            //At the same time, remove any unnecessary space from either end 
            //of the names.
            for (int i = 0; i < names.Count; i++)
            {
                string trimmedName = names[i].Trim(); // You can use name[index] to access individual strings
                stringsToAlign.Add(trimmedName);
            }
            //Now find the length of the longest string so that
            //all other strings line up with that string.
            int maxLength = 0;
            foreach (string s in stringsToAlign)
            {
                if (s.Length > maxLength)
                {
                    maxLength = s.Length;
                }
            }
            // Now justify all the strings to the length of the maximum string.
            for (int i = 0; i < stringsToAlign.Count; i++)
            {
                stringsToAlign[i] = stringsToAlign[i].PadRight(maxLength + 1);
            }
            // Finally output the resulting padded, justified strings.
            Console.WriteLine("The following are the same names"
                                + " normalized to the same length");
            foreach (string s in stringsToAlign)
            {
                Console.WriteLine("This is the name '" + s + "' afterwards");
            }
            // Wait for user to acknowledge.
            Console.WriteLine("\nPress Enter to terminate...");
            Console.Read();
        }
        public static void ReplaceMethod()
        {
            string s = "Danger NoSmoking";            
            s = s.Replace(' ', '!');
            Console.WriteLine(s);
        }
        public static void RemoveWhiteSpace()
        {
            // Define the white space characters.
            char[] whiteSpace = { ' ', '\n','\t'};
            // Start with a string embedded with whitespace.
            string s = " this is a\nstring"; // Contains spaces & newline.
            Console.WriteLine("before:" +s);
            // Output the string with the whitespace missing.
            Console.WriteLine("after:");
            // Start looking for the white space characters.
            for (; ; )
            {
                // Find the offset of the character; exit the loop
                // if there are no more.
                int offset = s.IndexOfAny(whiteSpace);
                if (offset == -1)
                {
                    break;
                }
                // Break the string into the part prior to the
                // character and the part after the character.
                string before = s.Substring(0, offset);
                string after = s.Substring(offset + 1);
                // Now put the two substrings back together with the
                // character in the middle missing.
                s = string.Concat(before, after);
                // Loop back up to find next whitespace char in
                // this modified s.
                Console.WriteLine(s);
                // Wait for user to acknowledge the results.
                Console.WriteLine("Press Enter to terminate...");
                Console.Read();
            }
        }
        public static string RemoveWhiteSpaceWithSplit(string input, char[] targets)
        {
            // Split the input string up using the target
            // characters as the delimiters.
            string[] subStrings = input.Split(targets);

            // output will contain the eventual output information.
            string output = "";

            // Loop through the substrings originating from the split.
            foreach (string subString in subStrings)
            {
                output = String.Concat(output, subString);
            }

            return output;
        }
        #region Formatting Your Strings Precisely
        public static void StringFormat()
        {
            //Example of Format in String
            //string myString = String.Format("{0} times {1} equals {2}", 2, 5, 2 * 5);
            //Console.WriteLine(myString);

            //Format Specifiers Using String.Format()
            //C — currency
            //string myString = String.Format("{0:C}",123.456);
            //Console.WriteLine(myString);
            //D — decimal {0:D5} of 123 00123 Integers only
            //E — exponential { 0:E} of 123.45 1.2345E+002 Also known as scientific notation.
            //F — fixed {0:F2} of 123.4567, 123.45,  The number after the F indicates 
            //the number of digits after the decimal point.
            //N — number    { 0:N} of 123456.789 123,456.79 Adds commas and rounds off to nearest 100th.
            //              {0:N1} of 123456.789 123,456.8 Controls the number of digits after the decimal point.
            //              {0:N0} of 123456.789 123,457
            //X — hexadecimal   { 0:X} of 123 0x7B 7B hex = 123 decimal(integers only).
            //                  {0:0...} {0:000.00} of 12.3 012.30 Forces a 0 if a digit is not
            //                                                     already present.
            //                  {0:#...} {0:###.##} of 12.3 12.3 Forces the space to be left blank; 
            //                                                   no other field can encroach on the three
            //                                                   digits to the left and two digits after
            //                                                   the decimal point
            //                                                   (useful for maintaining decimalpoint
            //                                                    alignment).
            //{0:##0.0#} of 0 0.0 Combining the # and zeros forces space to be
            //                    allocated by the #s and forces at least one
            //                    digit to appear, even if the number is 0.
            //{0:# or 0 %} {0:#00.#%} of .1234 12.3%, The % displays the number as a percentage
            //                                        (multiplies by 100 and adds the % sign).

        }
        public static void StringFormatOutput(string s)
        {
            decimal val;
            int i;
            if (decimal.TryParse(s, out val))
            {
                Console.WriteLine("Currency ---> " + String.Format("{0:C}", val));
                Console.WriteLine("Exponent ---> " + String.Format("{0:E}", val));
                Console.WriteLine("Fix ---> " + String.Format("{0:F2}", val));
                Console.WriteLine("Number ---> " + String.Format("{0:N}", val));
                Console.WriteLine("Number ---> " + String.Format("{0:N1}", val));
                Console.WriteLine("Number ---> " + String.Format("{0:N0}", val));
                Console.WriteLine("Number ---> " + String.Format("{0:000.00}", val));
                Console.WriteLine("Number ---> " + String.Format("{0:###.##}", val));
                Console.WriteLine("Number ---> " + String.Format("{0:##0.0#}", val));
                Console.WriteLine("Percent ---> " + String.Format("{0:#00.#%}", val));
            }
            if (int.TryParse(s, out i))
            {
                Console.WriteLine("Decimal ---> " + String.Format("{0:D5}", i));
                Console.WriteLine("Hexadecimal ---> " + String.Format("{0:X}", i));
            }            
        }
        #endregion
        #region StringBuilder: Manipulating Strings More Efficiently
        public static void StringBuilder()
        {
            //StringBuilder builder = new StringBuilder("012");  // Defaults to 16 characters
            //StringBuilder otherbuilder = new StringBuilder(256);  // 256 characters.
            //builder.Append("34");
            //builder.Append("56");
            //string result = builder.ToString();  // result = 0123456
            //Console.WriteLine(result);                        
        }
        #endregion
    }
    #endregion
    #endregion
    #region Smooth Operators
    class Operators
    {
        public static void SimpleOperators(int n, int i)
        {
            //  Operator                  What It Means
            //------------------------------------------------
            //  – (unary)                 Take the negative of
            //  *                         Multiply
            //  /                         Divide
            //  +                         Add
            //  - (binary)                Subtract
            //  %                         Modulo
            //------------------------------------------------
            //int n = (7 % 3) * (4 + (6 / 3));
            //Console.WriteLine(n);            
            int rslt;
            Console.WriteLine("Add: {0}", rslt = n + i);
            Console.WriteLine("Subtract: {0}", rslt = n - i);
            Console.WriteLine("Multiply: {0}", rslt = n * i);
            Console.WriteLine("Divide: {0}", rslt = n / i);
            Console.WriteLine("Modulo: {0}", rslt = n % i);
        }
        public static void Assignment(int n)
        {
            int rslt = n;
            //Assignment
            //int i = 0; // = is an assignment
            Console.WriteLine("{0}", rslt += 1);
            Console.WriteLine("{0}", rslt -= 1);
            Console.WriteLine("{0}", rslt *= 1);
            Console.WriteLine("{0}", rslt /= 1);
            Console.WriteLine("{0}", rslt %= 1);
            Console.WriteLine("{0}", rslt &= 1);
            Console.WriteLine("{0}", rslt |= 1);
            Console.WriteLine("{0}", rslt ^= 1);
        }
        public static void Increment()
        {
            //Increment
            int j = 0;
            j = j + 1;  // Increment Example
            j += 1;     // Increment Example
            j++;        // PostIncrement Example
            ++j;        // PreIncrement Example
        }
        public static void LogicalComparisonsOperators()
        {
            //  Operator              Operator Is True If
            //
            //  a == b                a has the same value as b
            //  a > b                 a is greater than b
            //  a >= b                a is greater than or equal to b
            //  a < b                 a is less than b
            //  a <= b                a is less than or equal to b
            //  a != b                a is not equal to b

            int a = 1, b = 2;
            Console.WriteLine("The numbers are {0} and {1}", a, b);
            Console.WriteLine("Is a equal than b?            {0}", a == b);
            Console.WriteLine("Is a greater than b?          {0}", a > b);
            Console.WriteLine("Is a greater than equal to b? {0}", a >= b);
            Console.WriteLine("Is a less than b?             {0}", a < b);
            Console.WriteLine("Is a less than equal to b?    {0}", a <= b);
            Console.WriteLine("Is a not equal to b?          {0}", a != b);
        }
        public static void CompoundLogicalOperators()
        {
            //  Operator                  Operator Is True If
            //  !a                        a is false (also known as the "not” operator).
            //  a & b                     a and b are true (also known as the "and” operator).
            //  a | b                     Either a or b or else both are true (also known as a and/or b).
            //  a ^ b                     a is true or b is true but not both (also known as a xor b).
            //  a && b                    a is true and b is true with short-circuit evaluation.
            //  a || b                    a is true or b is true with short-circuit evaluation.
            bool a = true, b = true;
            Console.WriteLine("{0}", !a);
            Console.WriteLine("{0}", a & b);
            Console.WriteLine("{0}", a | b);
            Console.WriteLine("{0}", a ^ b);
            Console.WriteLine("{0}", a && b);
            Console.WriteLine("{0}", a || b);
        }
        public static void ExplicitCasting()
        {
            int n1 = 10;
            int n2 = (int)(5.0 * n1); //demote to int while compute the variables as double * double
        }
    }
    #endregion
    #region Getting Into the Program Flow
    class ProgramFlow
    {
        //A Program Without condition
        public static void Prog()
        {
            // Prompt user to enter a name.      
            Console.WriteLine("Enter your name, please:");
            // Now read the name entered.      
            string name = Console.ReadLine();
            // Greet the user with the entered name.      
            Console.WriteLine("Hello, " + name);
            // Wait for user to acknowledge the results.      
            Console.WriteLine("Press Enter to terminate . . . ");
            Console.Read();
        }
        public static void CalculateInterest()
        {
            // Prompt user to enter source principal.
            Console.WriteLine("Enter principal: ");
            string principalInput = Console.ReadLine();
            decimal principal = Convert.ToDecimal(principalInput);
            // Make sure that the principal is not negative.
            if (principal < 0)
            {
                Console.WriteLine("Principal cannot be negative");
                principal = 0;
            }
            // Enter the interest rate.
            Console.WriteLine("Enter interest: ");
            string interestInput = Console.ReadLine();
            decimal interest = Convert.ToDecimal(interestInput);
            // Make sure that the interest is not negative either.
            if (interest < 0)
            {
                Console.WriteLine("Interest cannot be negative");
                interest = 0;
            }
            // Calculate the value of the principal plus interest.
            decimal interestPaid = principal * (interest / 100);
            // Now calculate the total.
            decimal total = principal + interestPaid;
            // Output the result.
            Console.WriteLine(); // Skip a line
            Console.WriteLine("Principal     = " + principal);
            Console.WriteLine("Interest      = " + interest + "%");
            Console.WriteLine();
            Console.WriteLine("Interest paid = " + interestPaid);
            Console.WriteLine("Total         = " + total);
            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
        public static void ElseStatement()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0) Console.WriteLine("n is Positive");
            else Console.WriteLine("n is negative"); // This is the Else Example
        }
        public static void TernaryOperator()
        {
            bool informal = true;
            string name = informal ? "Chuck" : "Charles";
        }
        public static void NestedIf()
        {
            if (true)
            {
                if (true)
                {

                }
                else
                {

                }
            }
            else
            {

            }
        }
        public static void SwitchStatement()
        {
            #region SimpleSwitchStatement
            const string a = "Davis";
            string s = "Davis";
            switch (s)
            {
                case a:
                    Console.WriteLine("Correct");
                    break;
                case "John":
                    Console.WriteLine("Wrong");
                    break;
                case "Exxxcube":
                    Console.WriteLine("Wrong");
                    break;
                case "Keneth":
                    Console.WriteLine("Wrong");
                    break;
            }
            #endregion
            #region SwitchStatement: Two case lead to the same actions
            string l = "David";
            switch (l)
            {
                case "David":
                case "John":
                    Console.WriteLine("Correct");
                    break;
                case "":
                    Console.WriteLine("Wrong");
                    break;
            }
            #endregion
        }
        public static void Loops()
        {
            //While Syntax
            //while (bool-expression)
            //{
            //code here
            //}

            //Do While
            //do
            //{

            //} while (true);

            //For 
            //for (initExpression; condition; incrementExpression)
            //{    // . . . body of code . . .}
            //}

            //Nesting Loops
            //for ( . . .some condition. . .)
            //{
            //    for ( . . .some other condition. . .)
            //    {
            //        // . . . do whatever . . .
            //    }
            //}
        }
        public static void GotoStatement()
        {
            int i = 0,j = 1;
            if (i > j)
            {
                // . . . control passes unconditionally from the goto to the label.
                goto exitLabel;
            }
            // . . . whatever other code goes here . . .

            exitLabel:
            Console.WriteLine("Here...");
            // Control continues here.
        }
        public static void CalculateInterestTable()
        {
            // Define a maximum interest rate.
            int maximumInterest = 50;
            // Prompt user to enter source principal.
            Console.WriteLine("Enter principal: ");
            string principalInput = Console.ReadLine();
            decimal principal = Convert.ToDecimal(principalInput);
            // If the principal is negative . . .
            if (principal < 0)
            {
                // . . . generate an error message . . .
                Console.WriteLine("Principal cannot be negative");
            }
            else // Go here only if principal was > 0: thus valid.
            {
                //  . . . otherwise, enter the interest rate.
                Console.WriteLine("Enter interest: ");
                string interestInput = Console.ReadLine();
                decimal interest = Convert.ToDecimal(interestInput);
                // If the interest is negative or too large . . .
                if (interest < 0 || interest > maximumInterest)
                {
                    //  . . . generate an error message as well.
                    Console.WriteLine("Interest cannot be negative " +
                                       "or greater than " + maximumInterest);
                    interest = 0;
                }
                else // Reach this point only if all is well.
                {
                    // Both the principal and the interest appear to be
                    // legal; finally, input the number of years.
                    Console.WriteLine("Enter number of years: ");
                    string durationInput = Console.ReadLine();
                    int duration = Convert.ToInt32(durationInput);
                    // Verify the input.
                    Console.WriteLine(); // Skip a line
                    Console.WriteLine("Principal        = "+principal);
                    Console.WriteLine("Interest         = " + interest+ "%");
                    Console.WriteLine("Duration         = " + duration + " years");
                    Console.WriteLine();

                    // Now loop through the specified number of years.
                    int year = 1;
                    while (year <= duration)
                    {
                        // Calculate the value of the principal plus interest.
                        decimal interestPaid;
                        interestPaid = principal * (interest / 100);
                        // Now calculate the new principal by adding
                        // the interest to the previous principal amount.
                        principal = principal + interestPaid;
                        // Round off the principal to the nearest cent.
                        principal = decimal.Round(principal, 2);
                        // Output the result.
                        Console.WriteLine(year + "-" + principal);
                        // Skip over to next year.
                        year = year + 1;
                    }
                }
            }
            // Wait for user to acknowledge the results.
            Console.WriteLine("\nPress Enter to terminate. . .");
            Console.ReadLine();
        }
        public static void CalculateInterestTableWithBreakAndContinue()
        {
            // Define a maximum interest rate.
            int maximumInterest = 50;
            // Prompt user to enter source principal.
            // until the correct value is entered.
            decimal principal;
            while (true)
            {
                Console.WriteLine("Enter principal: ");
                string principalInput = Console.ReadLine();
                principal = Convert.ToDecimal(principalInput);
                // Exit if the value entered is correct.
                if (principal >= 0)
                {
                    break;
                }
                // Generate an error on incorrect input.
                Console.WriteLine("Principal cannot be nagative");
                Console.WriteLine("Try again");
                Console.WriteLine();
            }
            // Now enter the interest rate.
            decimal interest;
            while (true)
            {
                Console.WriteLine("Enter interest: ");
                string interestInput = Console.ReadLine();
                interest = Convert.ToDecimal(interestInput);
                // Don’t accept interest that is negative or too large . . .
                if (interest >= 0 && interest <= maximumInterest)
                {
                    break;
                }
                //  . . . generate an error message as well.
                Console.WriteLine("Interest cannot be negative " + 
                                    "or greater than " + maximumInterest);
                Console.WriteLine("Try again");
                Console.WriteLine();
            }
            // Both the principal and the interest appear to be
            // legal; finally, input the number of years.
            Console.WriteLine("Enter number of years: ");
            string durationInput = Console.ReadLine();
            int duration = Convert.ToInt32(durationInput);
            // Verify the input.
            Console.WriteLine(); // Skip a line
            Console.WriteLine("Principal        = " + principal);
            Console.WriteLine("Interest         = " + interest + "%");
            Console.WriteLine("Duration         = " + duration + " years");
            Console.WriteLine();
            // Now loop through the specified number of years.
            int year = 1;
            while (year <= duration)
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
                Console.WriteLine(year + "-"+ principal);
                // Skip over to next year.
                year = year + 1;
            }
            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate . . .");
            Console.Read();
        }
    }
    #endregion
    #region Lining Up Your Ducks with Collections
    class Collections
    {
        public static void CSharpArray()
        {
            ////Fixed-value array
            //double[] doublesArray = { 5, 2, 7, 3.5, 6.5, 8, 1, 9, 1, 3 };

            ////Empty array without initializing
            //double[] doublesEmptyArray = new double[6];

            //The following lines show an array with its initializer
            //and then one that allocates space but doesn’t initialize the 
            //elements’ values:
            double[] fixedLengthArray = { 5, 2, 7, 3.5, 6.5, 8, 1, 9, 1, 3 };
            double[] variableLengthArray = new double[10];
            //or you can do both
            double[] fixedLengthArrayBoth = new double[10] { 5, 2, 7, 3.5, 6.5, 8, 1, 9, 1, 3 };
        }
        public static void FixedArrayAverage()
        {
            double[] doublesArray = { 5, 2, 7, 3.5, 6.5, 8, 1, 9, 1, 3 };
            // Accumulate the values in the array into the variable sum.
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + doublesArray[i];
            }
            // Now calculate the average.
            double average = sum / 10;
            Console.WriteLine(average);
            Console.WriteLine("Press Enter to terminate ...");
            Console.Read();
        }
        public static void VariableArrayAverage()
        {
            // First read in the number of doubles the user intends to enter.
            Console.Write("Enter the number of values to average: ");
            string numElementsInput = Console.ReadLine();
            int numElements = Convert.ToInt32(numElementsInput);
            Console.WriteLine();
            // Now declare an array of that size.
            double[] doublesArray = new double[numElements];
            // Accumulate the values into an array.
            for (int i = 0; i < numElements; i++)
            {
                // Prompt the user for another double.
                Console.WriteLine("enter double #"+ (i+1) +": ");
                string val = Console.ReadLine();
                double value = Convert.ToDouble(val);
                // Add this to the array using bracket notation.
                doublesArray[i] = value;
            }
            // Accumulate ‘numElements’ values from
            // the array in the variable sum.
            double sum = 0;
            for (int i = 0; i < numElements; i++)
            {
                sum = sum + doublesArray[i];
            }
            // Now calculate the average.
            double average = sum / numElements;
            // Output the results in an attractive format.
            Console.WriteLine();
            Console.Write(average+ " is the average of (");
            for (int i = 0; i < numElements; i++)
            {
                Console.Write(doublesArray[i]+ "+");
            }
            Console.WriteLine(") / "+ numElements);
            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to ternimate...");
            Console.WriteLine();
        }
        public static void ForeachExample()
        {
            int[] arrayOfItems = { 1,2,3,4,5,6,7,8,9,10 };
            foreach (var item in arrayOfItems)
            {
                Console.WriteLine(item); // print the elements of the array.
            }
        }       
        public static void ArraySortMethodExample()
        {
            // BubbleSortArray -- Given a list of planets, sort their
            // names: first, in alphabetical order.
            // Second, by the length of their names, shortest to longest.
            // Third, from longest to shortest.
            // This demonstrates using and sorting arrays, working with
            // them by array index. Two sort algorithms are used:
            // 1. The Sort algorithm used by class Array’s Sort() method.
            // 2. The classic Bubble Sort algorithm.
            Console.WriteLine("The 5 planets closest to the sun, in order: ");
            string[] planets = 
                        new string[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter" };
            foreach (string planet in planets)
            {
                // Use the special char \t to insert a tab in the printed line.
                Console.WriteLine("\t",planet);
            }
            Console.WriteLine("\nNow listed alphabetically: ");
            // Array.Sort() is a method on the Array class.
            // Array.Sort() does its work in-place in the planets array,
            // which leaves you without a copy of the original array. The
            // solution is to copy the old array to a new one and sort it.
            string[] sortedNames = planets;
            Array.Sort(sortedNames);
            // This demonstrates that (a) sortedNames contains the same
            // strings as planets and (b) that they’re now sorted.
            foreach (string planet in sortedNames)
            {
                Console.WriteLine("\t"+planet);
            }            
        }
        public static void BubbleSortExample()
        {
            Console.WriteLine("\nList by name length - shortest first: ");
            // This algorithm is called "Bubble Sort”: It’s the simplest
            // but worst-performing sort. The Array.Sort() method is much
            // more efficient, but I couldn’t use it directly to sort the
            // planets in order of name length because it sorts strings,
            // not their lengths.
            string[] planets =
                        new string[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter" };
            int outer; // Index of the outer loop
            int inner; // Index of the inner loop
            // Loop DOWN from last index to first: planets[4] to planets[0].
            for (outer = planets.Length - 1; outer >= 0 ; outer--)
            {
                // On each outer loop, loop through all elements BEYOND the
                // current outer element. This loop goes up, from planets[1]
                // to planets[4]. Using the for loop, you can traverse the
                // array in either direction.
                for (inner = 1; inner <= outer; inner++)
                {
                    // Compare adjacent elements. If the earlier one is longer
                    // than the later one, swap them. This shows how you can
                    // swap one array element with another when they’re out of order.
                    if (planets[inner - 1].Length > planets[inner].Length)
                    {
                        // Temporarily store one planet.
                        string temp = planets[inner - 1];
                        // Now overwrite that planet with the other one.
                        planets[inner - 1] = planets[inner];
                        // Finally, reclaim the planet stored in temp and put
                        // it in place of the other.
                        planets[inner] = temp;
                    }
                }                
            }
            foreach (string planet in planets)
            {
                Console.WriteLine("\t"+planet);
            }
            Console.WriteLine("\nNow listed longest first: ");
            // That is, just loop down through the sorted planets.
            for (int i = planets.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("\t"+planets[i]);                
            }
            Console.WriteLine("\nPress Enter to terminate...");
            Console.Read();
        }
        public static void VarExample()
        {
            // myArray is an int[] with 6 elements.
            var myArray = new[] { 2, 3, 5, 7, 11, 13 }; // Initializer required!
        }
        public static void CollectionListOfExamples()
        {
            //  Class                         Description
            //
            //  List<T>                       This dynamic array contains objects of type T.
            //  LinkedList<T>                 This is a linked list of objects of type T.
            //  Queue<T>                      Start at the back end of the line and
            //                                end up at the front.
            //  Stack<T>                      Always add or delete items at the
            //                                "top” of the list,
            //                                like a stack of cafeteria trays.
            //  Dictionary<TKey,TValue >      This structure works like a dictionary.
            //                                Look up a key (a word, for example)
            //                                and retrieve its corresponding value
            //                                (for example, definition).
            // HashSet<T>                     This structure resembles a mathematical set,
            //                                with no duplicate items. It works much like a
            //                                list but provides mathematical set operations,
            //                                such as union and intersection.

            //Figuring out <T>
            List<int> intList = new List<int>();  // Instantiating for int
            //Instantiate is geekspeak for "Create an object (instance) of this type.”
        }
        public static void UsingList()
        {
            //List<MP3> myMP3s = new List<MP3>();   // An empty list
            //myMP3s.Add(new MP3("Avril Lavigne”)); // Call the list’s Add() method to add.
            // ... and so on.

            //// List<T>: note angle brackets plus parentheses in
            //// List<T> declaration; T is a "type parameter”,
            //// List<T> is a "parameterized type.”
            //// Instantiate for string type.
            //List<string> nameList = new List<string>();
            //nameList.Add("one");
            List<int> intList = new List<int>();
            intList.Add(3);                         // Fine.
            intList.Add(4);
            Console.WriteLine("Printing intList: ");
            foreach (int i in intList)              // foreach just works for all collections.
            {
                Console.WriteLine("int i = "+ i);
            }
        }
        public static void UsingListWithClassStudentsList()
        {
            List<StudentsList> studentList = new List<StudentsList>();
            StudentsList student1 = new StudentsList("Virgil");
            StudentsList student2 = new StudentsList("Finch");
            studentList.Add(student1);
            studentList.Add(student2);
            StudentsList[] anotherStudents = { new StudentsList("Mox"), new StudentsList("Fox") };
            studentList.AddRange(anotherStudents);   // Add whole array to List.
            Console.WriteLine("Num students in studentList = "+ studentList.Count);

            // Search with IndexOf().
            Console.WriteLine("Student2 at "+ studentList.IndexOf(student2));
            string name = studentList[3].Name;
            if (studentList.Contains(student1))
            {
                Console.WriteLine(student1.Name +" contained in list");
            }
            //Console.WriteLine("This is sorted");
            //studentList.Sort();            
            studentList.Insert(3, new StudentsList("Ross")); // Inserted new value in index 3.
            studentList.RemoveAt(3); // Deletes the third element.
            Console.WriteLine("removed "+ name); // Name defined above
        }
        public static void DictionaryExample()
        {
            //Example of Dictionary
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("C#", "cool");
            dict.Add("C++", "like writing Sanskrit poetry in Morse code");
            dict.Add("VB", "a simple but wordy language");
            dict.Add("Java", "good, but not C#");
            dict.Add("Fortran", "ANCNT"); // 6-letters-max variable name for "ancient.”
            dict.Add("Cobol", "even more wordy, or is it wordier, and verbose than VB");
            //The ContainsKey() method tells you whether the dictionary contains a
            //particular key. There’s a corresponding ContainsValue() method too:
            // See if the dictionary contains a particular key.
            Console.WriteLine("Using ContainsKey Method: ");
            Console.WriteLine("Contains key C# " + dict.ContainsKey("C#"));
            Console.WriteLine("Contains key Ruby " + dict.ContainsKey("Ruby"));
            // Iterate the dictionary’s contents with foreach.
            // Note that you’re iterating pairs of keys and values.
            Console.WriteLine("Contents of the dictionary: ");
            foreach (KeyValuePair<string, string> pair in dict)
            {
                // Because the key happens to be a string,
                // we can call string methods on it.
                Console.WriteLine("Key: " + pair.Key.PadRight(8) + "Value: " + pair.Value);
            }
            // List the keys, which are in no particular order.
            Console.WriteLine("\nJust the keys:");
            // Dictionary<TKey, TValue>.KeyCollection is a collection of just the keys,
            // in this case strings. So here’s how to retrieve the keys:
            Dictionary<string, string>.KeyCollection keys = dict.Keys;
            foreach (string key in keys)
            {
                Console.WriteLine("Key: " + key);
            }
            // List the values, which are in same order as key collection above.
            Console.WriteLine("\nJust the values: ");
            Dictionary<string, string>.ValueCollection values = dict.Values;
            foreach (string value in values)
            {
                Console.WriteLine("Values: " + value);
            }
            Console.WriteLine("\nNumber of items in the dictionary: " + dict.Count);
        }
        public static void ArrayAndCollectionInitializers()
        {
            //Initializing arrays
            int[] numbers = { 1, 2, 3 };     // Shorter form -- can’t use var.
            var newNumbers = new[] { 1, 2, 3 }; // Full initializer mandatory with var.

            //Initializing collections
            List<int> numList = new List<int> { 1, 2, 3, 4, 5 };

            //Initializing collections using var data type
            var list = new List<string> { "Head", "Heart", "Hands", "Health" };

            //Initializing collections using dynamic data type
            dynamic dynamicList = new List<string> { "Head", "Heart", "Hands", "Health" };

            //Initializing dictionaries with the new syntax looks like this:
            Dictionary<int, string> dict = new Dictionary<int, string>
                                            { { 1,"Sam"} , { 2, "Joe"} };
        }
        public static void UsingSets()
        {
            //Initializing sets is much like initializing lists:
            //HashSet<int> biggerPrimes = new HashSet<int> { 19, 23, 29, 31, 37, 41 };
            //C# 3.0 added the new collection type HashSet<T>.
            //A set is an unordered collection with no duplicate items.

            //To create a HashSet<T>, you can do this:
            HashSet<int> smallPrimeNumbers = new HashSet<int>();
            smallPrimeNumbers.Add(2);
            smallPrimeNumbers.Add(3);
            //Or, more conveniently, you can use a collection initializer:
            HashSet<int> anotherSmallPrimeNumbers = new HashSet<int>
                                    { 2, 3, 5, 7, 11, 13 };
            //Or create the set from an existing
            //collection of any list-like kind, including
            //arrays:
            List<int> intList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
            HashSet<int> numbers = new HashSet<int>(intList);
            //the compiler doesn’t treat the duplication as an error(and doesn’t change the
            //hash set, which can’t have duplicates).Actually, Add() returns true if the
            //addition occurred and false if it didn’t.You don’t have to use that fact, but it
            //can be useful if you want to do something when an attempt is made to add a
            //duplicate:
            bool successful = smallPrimeNumbers.Add(2);
            if (successful)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        public static void HashSetExample()
        {
            Console.WriteLine("Combining two collections with no duplicates:");
            List<string> colors = new List<string> {  "red", "orange", "yellow" };
            string[] moreColors = {  "orange", "yellow", "green", "blue", "violet" };
            // Want to combine but without any duplicates.
            // Following is just the first stage ...
            HashSet<string> combined = new HashSet<string>(colors);
            // ... now for the second stage.
            // UnionWith() collects items in both lists that aren’t duplicated,
            // resulting in a combined collection whose members are all unique.
            combined.UnionWith(moreColors);
            foreach (string color in combined)
            {
                Console.WriteLine(color);
            }
            //Add it to a List
            Console.WriteLine("\nConverting the combined set to a list:");
            // Initialize a new List from the combined set above.
            List<string> spectrum = new List<string>(combined);
            foreach (string color in spectrum)
            {
                Console.WriteLine(color);
            }
        }
        public static void OverlappingList()
        {
            Console.WriteLine("Finding the overlap in two lists:");
            List<string> presidentialCandidates =
                new List<string> { "Clinton", "Edwards", "Giuliani", "McCain", "Obama",
                                   "Romney"};
            List<string> senators = new List<string> { "Alexander", "Boxer", "Clinton",
                                   "McCain", "Obama", "Snowe"};
            HashSet<string> senatorsRunning = new HashSet<string>(presidentialCandidates);
            // IntersectWith() collects items that appear in both lists, eliminates others.
            senatorsRunning.IntersectWith(senators);
            foreach (string senator in senatorsRunning)
            {
                Console.WriteLine(senator);
            }
        }
        public static void ExceptWithExample()
        {
            Console.WriteLine("Excluding items from a list:");
            Queue<int> queue =
                new Queue<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 17 });
            HashSet<int> unique = new HashSet<int> { 1, 3, 5, 7, 9, 11, 13, 15 };
            // ExceptWith() removes items in unique that are also in queue: 1, 3, 5, 7.
            unique.ExceptWith(queue);
            foreach (int n in unique)
            {
                Console.WriteLine(n.ToString());
            }
        }
        public static void SymmetricExceptWith()
        {
            Console.WriteLine("Finding just the non-overlapping items in two lists: ");
            Stack<int> stackOne = new Stack<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            Stack<int> stackTwo = new Stack<int>(new int[] { 2, 4, 6, 7, 8, 12,10 });
            HashSet<int> nonoverlapping = new HashSet<int>(stackOne);
            // SymmetricExceptWith() collects items that are in one collection but not
            // the other: the items that don’t overlap.
            nonoverlapping.SymmetricExceptWith(stackTwo);
            foreach (int n in nonoverlapping)
            {
                Console.WriteLine(n.ToString());
            }
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }        
    }
    class StudentsList
    {
        public string Name;

        public StudentsList(string v)
        {
            this.Name = v;
        }
    } //This class is for UsingListWithClassStudentsList()
    #endregion
    #region Stepping through Collections
    class MoreCollectionExample
    {
        public static void IteratingThroughADirectoryOfFiles(string[] args)
        {
            // LoopThroughFiles -- Loop through all files contained in a directory;
            // this time perform a hex dump, though it could have been anything.

            // If no directory name provided...
            string directoryName;
            if (args.Length == 0)
            {
                // ...get the name of the current directory...
                directoryName = Directory.GetCurrentDirectory();
            }
            else
            {
                // ...otherwise, assume that the first argument
                // is the name of the directory to use.
                directoryName = args[0];
            }
            Console.WriteLine(directoryName);

            // Get a list of all files in that directory.
            FileInfo[] files = GetFileList(directoryName);

            // Now iterate through the files in that list,
            // performing a hex dump of each file.
            foreach (FileInfo file in files)
            {
                // Write out the name of the file.
                Console.WriteLine("\n\nhex dump of file {0}: ",file.FullName);

                // Now "dump” the file to the console.
                DumpHex(file);

                // Wait before outputting next file.
                Console.WriteLine("\nenter return to continue to next file");
                Console.ReadLine();
            }
            // That’s it!
            Console.WriteLine("\nno files left");

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
        // GetFileList -- Get a list of all files in a specified directory.
        public static FileInfo[] GetFileList(string directoryName)
        {
            // Start with an empty list.
            FileInfo[] files = new FileInfo[0];
            try
            {
                // Get directory information.
                DirectoryInfo di = new DirectoryInfo(directoryName);

                // That information object has a list of the contents.
                files = di.GetFiles();
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory \"{0}\" invalid",directoryName);
                Console.WriteLine(e.Message);
            }
            return files;
        }
        public static void DumpHex(FileInfo file)
        {
            // Open the file.
            FileStream fs;
            BinaryReader reader;
            try
            {
                fs = file.OpenRead();
                // Wrap the file stream in a BinaryReader.
                reader = new BinaryReader(fs);
            }
            catch (Exception e)
            {
                Console.WriteLine("\ncan’t read from \"{0}\"",file.FullName);
                Console.WriteLine(e.Message);
                return;
            }
            // Iterate through the contents of the file one line at a time.
            for (int line = 1; true; line++)
            {
                // Read another 10 bytes across (all that will fit on a single
                // line) -- return when no data remains.
                byte[] buffer = new byte[10];
                // Use the BinaryReader to read bytes.
                // Note: Using the bare FileStream would have been just as easy in this case.
                int numBytes = reader.Read(buffer, 0, buffer.Length);
                if (numBytes == 0)
                {
                    return;
                }
                // Write out the data just read, in a single line preceded by line number.
                Console.Write("{0:D3} - ",line);
                DumpBuffer(buffer, numBytes);

                // Stop every 20 lines so that the data doesn’t scroll
                // off the top of the Console screen.
                if ((line % 20) == 0)
                {
                    Console.WriteLine("Enter return to continue another 20 lines");
                    Console.ReadLine();
                }
            }
        }
        public static void DumpBuffer(byte[] buffer, int numBytes)
        {
            for (int index = 0; index < numBytes; index++)
            {
                byte b = buffer[index];
                Console.Write("{0:X2},",b);
            }
            Console.WriteLine();
        }
        public static void IEnumerableAndIEnumerator()
        {
            // IEnumerable<T> looks like this:
            // interface IEnumerable<T>
            // {
            //   IEnumerator<T> GetEnumerator();
            // }

            // while IEnumerator<T> looks like this:
            // interface IEnumerator<T>
            // {
            //    bool MoveNext();
            //    T Current { get; }
            // }

        }        
    }
    #region Iteration and yield return
    // This Class Example is Accessing Arrays using String Indexers 
    public class KeyedArray
    {
        // The following string provides the "key” into the array --
        // the key is the string used to identify an element.
        private string[] _keys;

        // The object is the actual data associated with that key.
        private object[] _arrayElements;

        // KeyedArray -- Create a fixed-size KeyedArray.
        public KeyedArray(int size)
        {
            _keys = new string[size];
            _arrayElements = new object[size];
        }

        // Find -- Find the index of the element corresponding to the
        // string targetKey (return a negative if it can’t be found).
        private int Find(string targetKey)
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                if (String.Compare(_keys[i], targetKey) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        // FindEmpty -- Find room in the array for a new entry.
        private int FindEmpty()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                if (_keys[i] == null)
                {
                    return i;
                }
            }
            throw new Exception("Array is full");
        }
        // Look up contents by string key -- this is the indexer.
        public object this[string key]
        {
            set
            {
                // See if the string is already there.
                int index = Find(key);
                if (index < 0)
                {
                    // It isn’t -- find a new spot.
                    index = FindEmpty();
                    _keys[index] = key;
                }
                // Save the object in the corresponding spot.
                _arrayElements[index] = value;
            }
            get
            {
                int index = Find(key);
                if (index < 0)
                {
                    return null;
                }
                return _arrayElements[index];
            }
        }
    }
    public class IteratorBlocks
    {
        // IteratorBlocks -- Demonstrates using the C# 2.0 iterator
        // block approach to writing collection iterators
        public static void MainIteratorBlocks(string[] args)
        {
            // Instantiate a MonthDays "collection” class.
            MonthDays md = new MonthDays();
            // Iterate it.
            Console.WriteLine("Stream of months:\n");
            foreach (string month in md)
            {
                Console.WriteLine(month);
            }

            // Instantiate a StringChunks “collection” class.
            StringChunks sc = new StringChunks();
            // Iterate it: prints pieces of text.
            // This iteration puts each chunk on its own line.
            Console.WriteLine("\nstream of string chunks:\n");
            foreach (string chunk in sc)
            {
                Console.WriteLine(chunk);
            }
            // And this iteration puts it all on one line.
            Console.WriteLine("\nstream of string chunks on one line:\n");
            foreach (string chunk in sc)
            {
                Console.Write(chunk);
            }
            Console.WriteLine();

            // Instantiate a YieldBreakEx “collection” class.
            YieldBreakEx yb = new YieldBreakEx();
            // Iterate it, but stop after 13.
            Console.WriteLine("\nstream of primes:\n");
            foreach (int prime in yb)
            {
                Console.WriteLine(prime);
            }

            // Instantiate an EvenNumbers “collection” class.
            EvenNumbers en = new EvenNumbers();
            // Iterate it: prints even numbers from 10 down to 4.
            Console.WriteLine("\nstream of descending evens :\n");
            foreach (int even in en.DescendingEvens(11, 3))
            {
                Console.WriteLine(even);
            }

            // Instantiate a PropertyIterator “collection” class.
            PropertyIterator prop = new PropertyIterator();
            // Iterate it: produces one double at a time.
            Console.WriteLine("\nstream of double values:\n");
            foreach (double db in prop.DoubleProp)
            {
                Console.WriteLine(db);
            }

            // Wait for the user to acknowledge.
            Console.WriteLine("Press enter to terminate...");
            Console.Read();
        }
    }
    // MonthDays -- Define an iterator that returns the months
    // and their lengths in days -- sort of a "collection” class.
    class MonthDays
    {
        // Here’s the "collection.”
        string[] months = {  "January 31", "February 28", "March 31",
                             "April 30", "May 31", "June 30", "July 31",
                             "August 31", "September 30", "October 31",
                             "November 30", "December 31" };
        // GetEnumerator -- Here’s the iterator. See how it’s invoked
        // in Main() with foreach.
        public System.Collections.IEnumerator GetEnumerator()
        {
            foreach (string month in months)
            {
                // Return one month per iteration.
                yield return month;
            }
        }
    }
    // StringChunks -- Define an iterator that returns chunks of text,
    // one per iteration -- another oddball “collection” class.
    class StringChunks
    {
        // GetEnumerator -- This is an iterator; see how it’s invoked
        // (twice) in Main.
        public System.Collections.IEnumerator GetEnumerator()
        {
            // Return a different chunk of text on each iteration.
            yield return "Using iterator ";
            yield return "blocks ";
            yield return "isn’t all ";
            yield return "that hard";
            yield return ".";
        }
    }
    //YieldBreakEx -- Another example of the yield break keyword
    class YieldBreakEx
    {
        int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
        //GetEnumerator -- Returns a sequence of prime numbers
        // Demonstrates yield return and yield break
        public System.Collections.IEnumerator GetEnumerator()
        {
            foreach (int prime in primes)
            {
                if (prime > 13) yield break;
                yield return prime;
            }
        }
    }
    //EvenNumbers -- Define a named iterator that returns even numbers
    // from the “top” value you pass in DOWN to the “stop” value.
    // Another oddball “collection” class
    class EvenNumbers
    {
        //DescendingEvens -- This is a “named iterator.”
        // Also demonstrates the yield break keyword.
        // See how it’s invoked in Main() with foreach.
        public System.Collections.IEnumerable DescendingEvens(int top, int stop)
        {
            // Start top at nearest lower even number.
            if (top % 2 != 0) // If remainder after top / 2 isn’t 0.
                top -= 1;
            // Iterate from top down to nearest even above stop.
            for (int i = top; i >= stop; i -= 2)
            {
                if (i < stop)
                    yield break;
                // Return the next even number on each iteration.
                yield return i;
            }
        }
    }
    //PropertyIterator -- Demonstrate implementing a class
    // property’s get accessor as an iterator block.
    class PropertyIterator
    {
        double[] doubles = { 1.0, 2.0, 3.5, 4.67 };
        // DoubleProp -- A “get” property with an iterator block
        public System.Collections.IEnumerable DoubleProp
        {
            get
            {
                foreach (double db in doubles)
                {
                    yield return db;
                }
            }
        }
    }
    #endregion
    #region IteratorBlockIteratorMyRegion
    // IteratorBlockIterator -- Implements a separate iterator object as a
    // companion to a collection class, a la LinkedList, but
    // implements the actual iterator with an iterator block
    class IteratorBlockIterator
    {
        // Create a collection and use two iterator objects to iterate
        // it independently (each using an iterator block).
        public static void IteratorBlockIteratorMain()
        {
            string[] strs = new string[] { "Joe", "Bob", "Tony", "Fred" };
            MyCollection mc = new MyCollection(strs);
            // Create the first iterator and start the iteration.
            MyCollectionIterator mci1 = mc.GetEnumerator();
            foreach (string s1 in mci1) // Uses the first iterator object
            {
                // Do some useful work with each string.
                Console.WriteLine(s1);
                // Find Tony’s boss.
                if (s1 == "Tony")
                {
                    // In the middle of that iteration, start a new one, using
                    // a second iterator, repeated for each outer loop pass.
                    MyCollectionIterator mci2 = mc.GetEnumerator();
                    foreach (string s2 in mci2) // Uses the second iterator object
                    {
                        // Do some useful work with each string.
                        if (s2 == "Bob")
                        {
                            Console.WriteLine("\t{0} is {1}’s boss",s2,s1);
                        }
                    }
                }
            }
            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
    class MyCollection
    {
        // Implement collection with an old-fashioned ArrayList.
        // Internal, so separate iterator object can access the strings.
        internal ArrayList _list = new ArrayList();
        public MyCollection(string[] strs)
        {
            foreach (string s in strs)
            {
                _list.Add(s);
            }
        }
        // GetEnumerator -- As in LinkedList, returns one of your
        // iterator objects.
        public MyCollectionIterator GetEnumerator()
        {
            return new MyCollectionIterator(this);
        }
    }
    // MyCollectionIterator -- The iterator class for MyCollection
    // (MyCollection is in a separate file.)
    class MyCollectionIterator
    {
        // Store a reference to the collection.
        private MyCollection _mc;
        public MyCollectionIterator(MyCollection mc)
        {
            this._mc = mc;
        }
        // GetEnumerator -- This is the iterator block, which carries
        // out the actual iteration for the iterator object.
        public System.Collections.IEnumerator GetEnumerator()
        {
            // Iterate the associated collection’s underlying list,
            // which is accessible because it’s declared internal.
            foreach (string s in _mc._list)
            {
                yield return s;
            }
        }
    }
    #endregion
    #endregion
    #region Buying Generic
    class BuyingGeneric
    {
        public static void WhyNotGenericsNotSafe()
        {
            StudentsExample studentexample = new StudentsExample();
            ArrayList aList = new ArrayList();
            aList.Add("a string");
            aList.Add(3);
            aList.Add(studentexample);

            if (aList[2] is StudentsExample) // Is the object there a StudentsExample?
            {
                //then code here
            }
        }
      
    }
    class StudentsExample
    {
        public int i;
        public string s;
        public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
    #region PriorityQueue
    class PriorityQueue
    {
        // Main -- Fill the priority queue with packages, then
        // remove a random number of them.
        public static void PriorityQueueMain()
        {
            Console.WriteLine("Create a priority queue:");
            PriorityQueue<Package> pq = new PriorityQueue<Package>();
            Console.WriteLine("Add a random number (0 - 20) of random packages to queue:");
            Package pack;
            PackageFactory fact = new PackageFactory();
            // You want a random number less than 20.
            Random rand = new Random();
            int numToCreate = rand.Next(20);  // Random int from 0 - 20
            Console.WriteLine("“\tCreating {0} packages: ",numToCreate);
            for (int i = 0; i < numToCreate; i++)
            {
                Console.WriteLine("\t\tGenerating and adding random package {0}",i);
                pack = fact.CreatePackage();
                Console.WriteLine(" with priority {0}",pack.Priority);
                pq.Enqueue(pack);
            }
            Console.WriteLine("See what we got:");
            int total = pq.Count;
            Console.WriteLine("Packages received: {0}",total);

            Console.WriteLine("Remove a random number of packages (0-20): ");
            int numToRemove = rand.Next(20);
            for (int i = 0; i < numToRemove; i++)
            {
                pack = pq.Dequeue();
                if (pack != null)
                {
                    Console.WriteLine("\t\tShipped package with priority {0}",pack.Priority);
                }
            }
            // See how many were “shipped.”
            Console.WriteLine("Shipped {0} packages",total - pq.Count);

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
    // Priority enumeration -- Defines a set of priorities
    // instead of priorities like 1, 2, 3, ... these have names.
    // For information on enumerations,
    // see the article “Enumerating the Charms of the Enum”
    // on csharp102.info.
    enum Priority
    {
        Low, Meduim, High
    }

    // IPrioritizable interface -- Defines ability to prioritize.
    // Define a custom interface: Classes that can be added to
    // PriorityQueue must implement this interface.
    interface IPrioritizable
    {
        Priority Priority { get; }  // Example of a property in an interface
    }

    //PriorityQueue -- A generic priority queue class
    // Types to be added to the queue *must* implement IPrioritizable interface.
    class PriorityQueue<T> where T : IPrioritizable
    {
        //Queues -- the three underlying queues: all generic!
        private Queue<T> _queueHigh = new Queue<T>();
        private Queue<T> _queueMedium = new Queue<T>();
        private Queue<T> _queueLow = new Queue<T>();

        //Enqueue -- Prioritize T and add it to correct queue; an item of type T.
        // The item must know its own priority.
        public void Enqueue(T item)
        {
            switch (item.Priority)
            {
                case Priority.High:
                    _queueHigh.Enqueue(item);
                    break;
                case Priority.Meduim:
                    _queueMedium.Enqueue(item);
                    break;
                case Priority.Low:
                    _queueLow.Enqueue(item);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(
                        item.Priority.ToString(), "bad priority in PriorityQueue.Enqueue");                    
            }
        }
        //Dequeue -- Get T from highest-priority queue available.
        public T Dequeue()
        {
            // Find highest-priority queue with items.
            Queue<T> queueTop = TopQueue();
            // If a non-empty queue is found.
            if (queueTop != null & queueTop.Count > 10)
            {
                return queueTop.Dequeue(); // Return its front item.
            }
            // If all queues empty, return null (you could throw exception).
            return default(T);  // What’s this? See discussion.
        }
        //TopQueue -- What’s the highest-priority underlying queue with items?
        private Queue<T> TopQueue()
        {
            if (_queueHigh.Count > 0)    // Anything in high-priority queue?
                return _queueHigh;
            if (_queueMedium.Count > 0)  // Anything in medium-priority queue?
                return _queueMedium;
            if (_queueLow.Count > 0)     // Anything in low-priority queue?
                return _queueLow;
            return _queueLow;           // All empty, so return an empty queue.
        }
        //IsEmpty -- Check whether there’s anything to deqeue.
        public bool IsEmpty()
        {
            // True if all queues are empty
            return (_queueHigh.Count == 0) & (_queueMedium.Count == 0) &
                (_queueLow.Count == 0);
        }
        //Count -- How many items are in all queues combined?
        public int Count // Implement this one as a read-only property.
        {
            get { return _queueHigh.Count + _queueMedium.Count + _queueLow.Count; }
        }
    }
    //Package -- An example of a prioritizable class that can be stored in
    // the priority queue; any class that implements
    // IPrioritizable would look something like Package.
    class Package : IPrioritizable
    {
        private Priority _priority;
        //Constructor
        public Package(Priority priority)
        {
            this._priority = priority;
        }

        //Priority -- Return package priority -- read-only.
        public Priority Priority
        {
            get { return _priority; }
        }
        // Plus ToAddress, FromAddress, Insurance, etc.
    }
    //PackageFactory -- You need a class that knows how to create a new
    // package of any desired type on demand; such a class
    // is a factory class.
    class PackageFactory
    {
        //A random-number generator
        Random _randGen = new Random();

        //CreatePackage -- The factory method selects a random priority,
        // then creates a package with that priority.
        // Could implement this as iterator block.
        public Package CreatePackage()
        {
            // Return a randomly selected package priority.
            // Need a 0, 1, or 2 (values less than 3).
            int rand = _randGen.Next(3);
            // Use that to generate a new package.
            // Casting int to enum is clunky, but it saves
            // having to use ifs or a switch statement.
            return new Package((Priority)rand);
        }
    }
    #endregion
    #endregion
    #region Some Exceptional Exceptions
    class ExceptionsTopic
    {
        public static void ErrorReportingMechanism()
        {
            // Using an Exceptional Error-Reporting Mechanism
            // This mechanism is based on the keywords try,
            // catch, throw, and finally.
            try
            {

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                
            }            
        }
        public static void CreatingExceptions()
        {
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());                
            }
            catch 
            {
                throw new ArgumentException("This is an Exception");
            }
        }
    }
    class MyMathFunctions
    {
        // MyMathFunctions -- A collection of mathematical functions
        // we created (it’s not much to look at yet)

        // Factorial -- Return the factorial of the provided value.
        public static int Factorial(int value)
        {
            // Don’t allow negative numbers.
            if (value < 0)
            {
                // Report negative argument.
                string s = String.Format("Illegal negative argument to +" +
                                         " Factorial {0}", value);
                throw new ArgumentException(s);
            }

            // Begin with an “accumulator” of 1.
            int factorial = 1;

            // Loop from value down to 1, each time multiplying
            // the previous accumulator value by the result.
            do
            {
                factorial *= value;
            } while (--value > 1);

            // Return the accumulated value.
            return factorial;
        }
        public static void MyMathFunctionsMain()
        {
            // Here’s the exception handler.
            try
            {                
                // Call factorial in a loop from 6 down to -6.
                for (int i = 6; i > -6; i--)
                {
                    // Calculate the factorial of the number.
                    int factorial = MyMathFunctions.Factorial(i);
                    // Display the result of each pass.
                    Console.WriteLine("i = {0}, factorial = {1}", i, factorial);
                }
            }
            catch (ArgumentException e)
            {
                // This is a “last-chance” exception handler -- the buck stops at Main().
                // Probably all you can do here is alert the user before quitting.
                Console.WriteLine("Fatal error:");
                // When you’re ready to release the program, change this
                // output to something in plain English, preferably with guide-
                // lines for what to do about the problem.
                Console.WriteLine(e.ToString());
            }
            // Wait for user to acknowledge.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
    #endregion


}
