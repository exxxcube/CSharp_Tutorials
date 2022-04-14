using Strategy_Design_Pattern_my_version.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_Pattern_my_version.Class
{
    class Class2 : IThrow
    {
        public string ThorwStringVersion()
        {
            return "Wood";
        }
    }
}
