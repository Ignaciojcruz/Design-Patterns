using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorExample.Mediator;

namespace MediatorExample.Colleague
{
    internal abstract class ConcessionStand
    {
        protected IMediator mediator;
        public ConcessionStand(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
