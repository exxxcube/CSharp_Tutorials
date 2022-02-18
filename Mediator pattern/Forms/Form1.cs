using Mediator_pattern.FormMediator.Component;
using Mediator_pattern.FormMediator.ConcreteMediator;
using Mediator_pattern.Mediator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator_pattern
{
    public partial class Form1 : Form
    {
        private Form2Component a;
        private Form2ConcreteMediator concrete;
        private Form1Component b;
        private FormConcreteMediator concrete2;
        
        public Form1()
        {            
            InitializeComponent();            
        }

        private void OpenForm2()
        {
            a = new Form2Component();
            concrete = new Form2ConcreteMediator(a);
            a.OpenForm();
        }
        private void CloseForm1()
        {
            b = new Form1Component();
            concrete2 = new FormConcreteMediator(b);
            b.CloseForm();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            OpenForm2();
            Close();
        }
    }
}
