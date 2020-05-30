using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

// InheritanceExample -- Provide the simplest possible
// demonstration of inheritance.
namespace InheritanceExample
{
	class BaseClass
	{
		public int _dataMember;
		public void SomeMethod()
		{
			Console.WriteLine("SomeMethod()");
		}
	}
	class SubClass : BaseClass // This is an exaple of inheritance.
	{                          // means the SubClass inherit the BaseClass
		public void SomeOtherMethod()
		{
			Console.WriteLine("SomeOtherMethod()");
		}
	}
	class AnotherSubclass : BaseClass
	{
		public void AnotherSomeMethod()
		{
			Console.WriteLine("AnotherSomeMethod()");
		}
	}
	public class InheritanceExampleClass
	{
		public static void InheritanceExampleMain()
		{
			// Create a base class object.
			Console.WriteLine("Exercising a base class object:");
			BaseClass bc = new BaseClass();
			bc._dataMember = 1;
			bc.SomeMethod();
			// Now create a subclass object.
			Console.WriteLine("Exercising a subclass object:");
			SubClass sc = new SubClass();
			sc._dataMember = 2;
			sc.SomeMethod();
			sc.SomeOtherMethod();
			// Wait for user to acknowledge the results.
			Console.WriteLine("Press Enter to terminate...");
			Console.Read();
		}
	}
}
