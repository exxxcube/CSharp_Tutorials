using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorials.Exam_Code
{
    class Grade12Examination
    {
        internal static void Exam1()
        {
            int x = 1 + 2 * 8 / 4 - 10;
            Console.WriteLine(x);
        }
        internal static void Exam2()
        {
            int x = 23 + 4 * 56 * 56 / 10;
            Console.WriteLine(x);
        }
        internal static void Exam3()
        {
            int x = 23 + 4 * 56 * 56 / 10;
            x = 12 + 4 - 6 * 24 / 10;
            Console.WriteLine(x);
        }
        internal static void Exam4()
        {
            int[] arr = { 1, 34, 56, 8, 90, 23, 18 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 18)
                {
                    Console.WriteLine("You're {0} years of age" +
                                      "and you're eligible to vote!",arr[i]);
                }
            }
        }
        internal static void Exam6()
        {
            int[] arr = { 19, 29, 34, 56, 78, 34, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] % 10) == 9 )
                {
                    Console.WriteLine("Lucky 9!");
                }
                else
                {
                    Console.WriteLine("Busted!");
                }
            }
        }
    }
    class Grade11Examination
    {
        internal static void Exam1()
        {
            int x = 1 + 2 * 8 / 4 - 10;
            Console.WriteLine(x);
        }
        internal static void Exam2()
        {
            int x = 1 + 2 * 8 / 4 - 10;
            Console.WriteLine(x);
        }
    }
}
