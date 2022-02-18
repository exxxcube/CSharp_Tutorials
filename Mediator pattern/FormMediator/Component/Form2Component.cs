using Mediator_pattern.FormMediator.BaseComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern.FormMediator.Component
{
    class Form2Component : Form2BaseComponent
    {
        public void OpenForm()
        {
            _mediator.Open(true);
        }
        public void CloseForm()
        {            
        }
    }
}
