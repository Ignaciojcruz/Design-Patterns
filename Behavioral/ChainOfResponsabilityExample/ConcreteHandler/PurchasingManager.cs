using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsabilityExample.Handler;

namespace ChainOfResponsabilityExample.ConcreteHandler
{
    internal class PurchasingManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 2500)
            {
                Console.WriteLine("{0} approved purchase request #{1}",
                    this.GetType().Name, purchase.RequestNumber);
            }
            else if (Supervisor != null)
            {
                Supervisor.ProcessRequest(purchase);
            }
        }
    }
}
