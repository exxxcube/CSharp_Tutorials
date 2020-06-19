using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_or_concrete_When_to_use_an_abstract
{
    interface IPropulsion
    {
        void Movement(int direction, int speed);
    }
    public class Robot
    {
        // A concrete class is a class that you can instantiate.It lacks the
        // abstract keyword, and it implements all methods.

        IPropulsion _propel; //<--Notice the interface type here.
        // Somehow, you supply a concrete propulsion object at runtime ...
        // Other stuff and then:
        public void Move(int speed, int direction)
        {
            // Use whatever concrete propulsion device is installed in _propel.
            _propel.Movement(direction, speed); // Delegate to its methods.
        }
    }
}
