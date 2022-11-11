using ObserverExample.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample.Observer
{
    internal interface IRestaurant
    {
        void Update(Veggies veggies);
    }
}
