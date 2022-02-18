using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern.FormMediator.Mediator
{
    interface IForm2Mediator
    {
        void Open(bool sender);
        void Close(bool sender);
    }
}
