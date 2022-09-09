using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderExample.Builder;
using BuilderExample.Product;


namespace BuilderExample.ConcreteBuilder
{
    internal class BLT : SandwichBuilder
    {
        public BLT()
        {
            sandwich = new Sandwich("BLT");
        }

        public override void AddBread()
        {
            sandwich["bread"] = "Wheat";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "None";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo, Mustard";
        }

        public override void AddMeats()
        {
            sandwich["meat"] = "Bacon";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "Lettuce, Tomato";
        }
    }
}
