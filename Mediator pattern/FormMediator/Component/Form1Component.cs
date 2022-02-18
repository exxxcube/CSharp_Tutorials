using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediator_pattern.FormMediator.BaseComponent;
using Mediator_pattern.FormMediator.Mediator;

namespace Mediator_pattern.FormMediator.Component
{
    class Form1Component : Form1BaseComponent
    {       
        public void Example()
        {
            
        }
        public void OpenForm()
        {
            _mediator.Open(true);
        }
        public void CloseForm()
        {
            _mediator.Close(true);
        }
    }
}
