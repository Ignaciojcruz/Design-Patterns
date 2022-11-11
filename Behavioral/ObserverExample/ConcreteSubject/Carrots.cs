using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverExample.Subject;

namespace ObserverExample.ConcreteSubject
{
    internal class Carrots : Veggies
    {
        public Carrots(double price) : base(price) { }
    }
}
