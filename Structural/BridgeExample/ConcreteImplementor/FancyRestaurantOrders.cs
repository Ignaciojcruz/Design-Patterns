using BridgeExample.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample.ConcreteImplementor
{
    internal class FancyRestaurantOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine("Placing order for "
                              + order + " at the Fancy Restaurant.");
        }
    }
}
