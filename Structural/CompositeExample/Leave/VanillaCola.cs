using CompositeExample.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample.Leave
{
    internal class VanillaCola : SoftDrink
    {
        public VanillaCola(int calories) : base(calories) { }
    }
}
