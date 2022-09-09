using AbstractFactoryExample.AbstractFactory;
using AbstractFactoryExample.AbstractProduct;
using AbstractFactoryExample.ConcreteProduct;

namespace AbstractFactoryExample.ConcreteFactory
{
    internal class ChildCusineFactory : RecipeFactory
    {
        public override Sandwich CreateSandwich()
        {
            return new GrilledChesse();
        }

        public override Dessert CreateDessert()
        {
            return new IceCreamSundae();
        }
    }
}
