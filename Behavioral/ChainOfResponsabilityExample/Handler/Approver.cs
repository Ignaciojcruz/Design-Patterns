using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityExample.Handler
{
    internal abstract class Approver
    {
        protected Approver Supervisor;

        public void SetSupervisor(Approver supervisor)
        {
            this.Supervisor = supervisor;
        }

        public abstract void ProcessRequest(PurchaseOrder purchase);
    }
}
