using CompositeExample.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample.Composite
{
    internal class RootBeer : SoftDrink
    {
        public RootBeer(int calories) : base(calories) { }
    }
}
