using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediator_pattern.FormMediator.Component;
using Mediator_pattern.FormMediator.Mediator;


namespace Mediator_pattern.Mediator
{
    class FormConcreteMediator : IMediator
    {
        Form1 a;
        Form1Component _form1Component;
        public FormConcreteMediator(Form1Component form1Component)
        {
            _form1Component = form1Component;
            _form1Component.SetMediator(this);
        }
        
        public void Open(bool sender)
        {
            if (sender)
            {
                a = new Form1();
                a.Show();
            }
        }
        public void Close(bool sender)
        {
            if (sender)
            {
                a = new Form1();
                a.Close();
            }
        }
    }
}
