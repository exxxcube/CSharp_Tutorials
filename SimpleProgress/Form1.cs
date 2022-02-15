using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleProgress
{
    public partial class Form1 : Form
    {
        // Declare the delegate. This one is void.
        delegate void UpdateUpdateProgressCallback();
        public Form1()
        {
            InitializeComponent();
        }
        // DoSomethingLengthy -- My workhorse method takes a delegate.
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();   // ‘this’ refers to the Form1 class.
        }
        private void DoUpdate()
        {
            progressBar1.PerformStep();  // Tells progress bar to update itself
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            //UpdateProgressCallback callback = UpdateProgressCallback(this.DoUpdate);
            //// Do something that needs periodic progress reports.
            //// This passes a delegate instance that knows how to update the bar.
            //DoSomethingLengthy(callback);
            //// Clear the bar so that it can be used again.
            //progressBar1.Value = 0;
        }
    }
}
