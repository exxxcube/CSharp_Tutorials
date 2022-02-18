using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator_pattern.FormMediator.Mediator;

namespace Mediator_pattern.FormMediator.BaseComponent
{
    class Form1BaseComponent
    {
        protected IMediator _mediator;        
        public Form1BaseComponent(IMediator mediator = null)
        {
            this._mediator = mediator;
        }
        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }        

    }
}
