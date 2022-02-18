using Mediator_pattern.FormMediator.Component;
using Mediator_pattern.FormMediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern.FormMediator.ConcreteMediator
{
    class Form2ConcreteMediator: IForm2Mediator
    {
        Form2 a;
        Form2Component _form2Component;
        public Form2ConcreteMediator(Form2Component form2Component)
        {
            _form2Component = form2Component;
            _form2Component.SetMediator(this);
        }

        public void Open(bool sender)
        {
            if (sender)
            {
                a = new Form2();
                a.ShowDialog();
            }
        }
        public void Close(bool sender)
        {
            if (sender)
            {
                a = new Form2();
                a.Close();
            }
        }
    }
}
