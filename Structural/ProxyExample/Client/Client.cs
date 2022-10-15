using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyExample.RealSubject;
using ProxyExample.Proxy;

namespace ProxyExample.Client
{
    internal class Client
    {
        public static void ClientMain()
        {
            string order = "Orden de churrascos.";
            string payment = "Pago";
            
            Server _server = new Server();
            _server.TakeOrder(order);
            _server.DeliverOrder();
            _server.ProcessPayment(payment);

            NewServerProxy _newServerProxy = new NewServerProxy();
            _newServerProxy.TakeOrder(order);
            _newServerProxy.DeliverOrder();
            _newServerProxy.ProcessPayment(payment);



        }
    }
}
