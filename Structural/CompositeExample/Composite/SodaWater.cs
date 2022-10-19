using CompositeExample.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample.Composite
{
    internal class SodaWater : SoftDrink
    {
        public SodaWater(int calories) : base(calories) { }
    }
}
