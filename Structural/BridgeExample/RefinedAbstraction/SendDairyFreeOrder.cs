using BridgeExample.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample.RefinedAbstraction
{
    internal class SendDairyFreeOrder : SendOrder
    {
        public override void Send()
        {
            _restaurant.Place("Dairy-Free Order");
        }
    }
}
