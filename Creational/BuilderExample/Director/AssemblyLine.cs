using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderExample.Builder;

namespace BuilderExample.Director
{
    internal class AssemblyLine
    {
        public void Assemble(SandwichBuilder sandwichBuilder)
        {
            sandwichBuilder.AddBread();
            sandwichBuilder.AddMeats();
            sandwichBuilder.AddCheese();
            sandwichBuilder.AddVeggies();
            sandwichBuilder.AddCondiments();

        }
    }
}
