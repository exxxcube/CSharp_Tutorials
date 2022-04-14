using Mediator_pattern_2.Class;
using Mediator_pattern_2.Concrete_Mediator;
using Mediator_pattern_2.Mediator;
using System;

namespace Mediator_pattern_2
{
    class Program
    {        
        static void Main(string[] args)
        {
            IMediator mediator = new ConcreteMediator();
            College1 college1 = new College1(mediator);
            college1.Send();
        }
    }
}
