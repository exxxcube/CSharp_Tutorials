using CSharp_Tutorials.Class;
using CSharp_Tutorials.Exercises;
//using CSharp_Tutorials.Object_Oriented_Programming;
using CSharp_Tutorials.Object_Oriented_Programming.Holding_a_Class_Responsible;
using CSharp_Tutorials.Object_Oriented_Programming.Let_Me_Say_About_this;
using CSharp_Tutorials.Object_Oriented_Programming.We_Have_Our_Methods;
using InheritanceExample;
using System;
using System.Runtime.InteropServices;
using SimpleSavingsAccount;
using IS_A_And_HAS_A;
using InheritingAConstructor;
using PassingArgsNameSpace;
using ConstructorSavingsAccount;
using PolymorphicInheritance;
using AbstractInheritance;
using SortInterface;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using SimpleDelegateExample;
using CSharp_Tutorials.Exam_Code;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Drawing;

namespace MyNameSpace
{
    class MyClass
    {
        //This is where your program starts.
        static void Main(string[] args)
        {
            #region Testing a code region

            //string s = Console.ReadLine();
            //int.TryParse(s, out int x);
            //string t = Console.ReadLine();
            //int.TryParse(t, out int y);                                                      
            //char[] a = { 'a', 'b', 'c' };
            //Array.Reverse(a);
            //Console.WriteLine(a);
            //Grade12Examination.Exam6();

            var result = ArrayDiff(new int[] { 1, 2}, new int[] { 1 });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
            #endregion

            #region For Introduction Class Example
            //Collections.UsingReadOnlyCollection(new List<string> { "a", "b" });
            #endregion

            #region For KeyedArray Example
            //// Create an array with enough room.
            //KeyedArray ma = new KeyedArray(100);

            //// Save the ages of the Simpson kids.
            //ma["Bart"] = 8;
            //ma["Lisa"] = 10;
            //ma["Maggie"] = 2;            

            //// Look up the age of Lisa.
            //Console.WriteLine("Let’s find Lisa’s age");
            //int age = (int)ma["Maggie"];
            //Console.WriteLine("Lisa is {0}",age);

            //// Wait for user to acknowledge the results.
            //Console.WriteLine("Press Enter to terminate...");
            //Console.Read();
            #endregion

            #region For Object Oriented Programming
            //SimpleDelegateExampleProg.SimpleDelegateExampleMain(null);
            #endregion
        }

        public static int[] ArrayDiff1(int[] a, int[] b)
        {                 
            var result = a.ToList();
            foreach (var item in b.ToList())
            {
                result.RemoveAll(x => x == item);                
            }

            return result.ToArray();
        } // important solution

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(n => !b.Contains(n)).ToArray();

            //var result = from s in a
            //             where !b.Contains(s)
            //             select s;
            //return result.ToArray();
        } 

    }
}
