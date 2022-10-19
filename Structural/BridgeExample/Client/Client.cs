using BridgeExample.Abstraction;
using BridgeExample.ConcreteImplementor;
using BridgeExample.RefinedAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample.Client
{
    internal class Client
    {
        public static void ClientMain()
        {
            SendOrder _sendOrder = new SendDairyFreeOrder();
            _sendOrder._restaurant = new DinerOrders();
            _sendOrder.Send();

            _sendOrder._restaurant = new FancyRestaurantOrders();
            _sendOrder.Send();

            _sendOrder = new SendGlutenFreeOrder();
            _sendOrder._restaurant = new DinerOrders();
            _sendOrder.Send();

            _sendOrder._restaurant = new FancyRestaurantOrders();
            _sendOrder.Send();

            Console.ReadKey();
        }
    }
}
