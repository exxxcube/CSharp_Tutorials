using System;

namespace Mediator_pattern_console_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();

            // Concrete Mediators implement cooperative behavior by coordinating several
            // components.
            // meaning setter ni sya to know the instance of class that will communicate
            ConcreteMediator a = new ConcreteMediator(component1, component2); 

            Console.WriteLine("Client triggets operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();
        }
    }
}
