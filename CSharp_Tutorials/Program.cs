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

namespace MyNameSpace
{
    class MyClass
    {
        //This is where your program starts.
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            //int.TryParse(s, out int x);
            //string t = Console.ReadLine();
            //int.TryParse(t, out int y);                                          
            Console.WriteLine(CodeExecises.Capitalize("tkudxahsywbpzabngsq", new List<int> { 1,2,100,10000 }));
            //char[] a = { 'a', 'b', 'c' };
            //Array.Reverse(a);
            //Console.WriteLine(a);

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
            //SortInterfaceProg.SortInterfaceMain();
            #endregion
        } 
    }
}
