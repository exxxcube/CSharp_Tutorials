using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorials.Object_Oriented_Programming.Holding_a_Class_Responsible
{
    class ClassResponsibility
    {
        //A class must be held responsible for its actions.
        #region Defining Class Properties 
        int x = 0;
        public int AccountNumber   // No parentheses here.
        {
            get { return x; }  // The "read" part. Curly braces and semicolon.
            set { x = value; } // The "write" part. 'value' is a keyword.
        }
        #endregion
    }
}
