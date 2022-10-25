using MediatorExample.Colleague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorExample.Mediator;

namespace MediatorExample.ConcreteColleague
{
    internal class SouthConcessionStand : ConcessionStand
    {
        public SouthConcessionStand(IMediator mediator) : base(mediator) { }

        public void Send(string message)
        {
            Console.WriteLine("South Concession Stand sends message: " + message);
            mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("South Concession Stand gets message: " + message);
        }
    }
}
