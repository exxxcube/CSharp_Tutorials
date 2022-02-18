using Mediator_pattern.FormMediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern.FormMediator.BaseComponent
{
    class Form2BaseComponent
    {
        protected IForm2Mediator _mediator;
        public Form2BaseComponent(IForm2Mediator mediator = null)
        {
            this._mediator = mediator;
        }
        public void SetMediator(IForm2Mediator mediator)
        {
            this._mediator = mediator;
        }
    }
}
