using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderExample.Product;

namespace BuilderExample.Builder
{
    internal abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public Sandwich SandWich
        {
            get { return sandwich; }
        }

        public abstract void AddBread();
        public abstract void AddMeats();
        public abstract void AddCheese();
        public abstract void AddVeggies();
        public abstract void AddCondiments();
    }
}
