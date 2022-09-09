using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryExample.AbstractFactory;
using AbstractFactoryExample.AbstractProduct;
using AbstractFactoryExample.ConcreteProduct;

namespace AbstractFactoryExample.ConcreteFactory
{
    internal class AdultCusineFactory : RecipeFactory
    {
        public override Sandwich CreateSandwich()
        {
            return new BLT();
        }

        public override Dessert CreateDessert()
        {
            return new CremeBrulee();
        }
    }
}
