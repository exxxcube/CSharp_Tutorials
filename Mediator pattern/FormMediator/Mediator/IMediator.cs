using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator_pattern.FormMediator.Mediator
{
    interface IMediator
    {
        void Open(bool sender);
        void Close(bool sender);
    }
}
