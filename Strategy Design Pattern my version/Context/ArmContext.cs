using Strategy_Design_Pattern_my_version.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_Pattern_my_version.Context
{
    class ArmContext
    {
        private IThrow _throw;

        // Set constructor empty so that we can inject
        // class without filling any parameters
        public ArmContext()
        {

        }
        public ArmContext(IThrow @throw)
        {
            _throw = @throw;
        }       
        public void SetStrategy(IThrow @throw)
        {
            _throw = @throw;
        }
        public void DoThrow()
        {
            Console.WriteLine("I throw something..");
            string throwWord = _throw.ThorwStringVersion();
            Console.WriteLine("I throw a {0}", throwWord);
        }
    }
}
