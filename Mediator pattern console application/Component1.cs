﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern_console_application
{
    // Concrete Components implement various functionality. They don't depend on
    // other components. They also don't depend on any concrete mediator
    // classes.
    class Component1 : BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Component 1 does A.");
            this._mediator.Notify(this, "A");
        }
        public void DoB()
        {
            Console.WriteLine("Component 1 does B.");
            this._mediator.Notify(this, "B");
        }
    }
}
