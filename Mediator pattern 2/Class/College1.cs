using Mediator_pattern_2.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern_2.Class
{
    // This is the class that will send a message to College2
    class College1
    {
        // Instantiate the IMediator to call the Message method
        private IMediator _mediator;
        public College1(IMediator mediator)
        {
            _mediator = mediator;
        }
        internal void Send()
        {
            _mediator.Message("Hello");// IMediator method called
        }
    }
}
