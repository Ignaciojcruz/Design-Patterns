using BridgeExample.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample.Abstraction
{
    public abstract class SendOrder
    {
        //Reference to the Implementor
        public IOrderingSystem _restaurant;

        public abstract void Send();
    }
}
