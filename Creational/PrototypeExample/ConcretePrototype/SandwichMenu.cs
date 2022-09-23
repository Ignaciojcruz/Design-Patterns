using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeExample.Prototype;

namespace PrototypeExample.ConcretePrototype
{
    internal class SandwichMenu
    {
        private Dictionary<string, SandwichPrototype> _sandwiches
        = new Dictionary<string, SandwichPrototype>();

        public SandwichPrototype this[string name]
        {
            get { return _sandwiches[name]; }
            set { _sandwiches.Add(name, value); }
        }
                
    }
}
