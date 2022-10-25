using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorExample.Colleague;

namespace MediatorExample.Mediator
{
    internal interface IMediator
    {
        void SendMessage(string message, ConcessionStand concessionStand);
    }
}
