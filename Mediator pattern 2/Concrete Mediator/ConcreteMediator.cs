using Mediator_pattern_2.Class;
using Mediator_pattern_2.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern_2.Concrete_Mediator
{
    class ConcreteMediator : IMediator
    {
        //In order to receive the message of College1
        //College2 must be initialize in this ConcreteClass  
        College2 college2 = new College2();

        //This is the IMediator Message method body
        public void Message(string message)
        {
            //To receive the message from College1 we need to 
            //call the method of the receiver which is the method PublishMessage()
            college2.PublishMessage(message);
        }
    }
}
