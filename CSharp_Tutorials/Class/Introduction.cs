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
            ////How can you tell if a target string is empty(“”) or has the value null ?
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
            //  !a                        a is false (also known as the “not” operator).
            //  a & b                     a and b are true (also known as the “and” operator).
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
    #region Getting Into the Program FlowMyRegion
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
            Console.WriteLine("Interest      = "+ interest + "%");
            Console.WriteLine();
            Console.WriteLine("Interest paid = "+ interestPaid);
            Console.WriteLine("Total         = "+ total);
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
    }
    #endregion

}
