using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryExample.AbstractFactory;
using AbstractFactoryExample.ConcreteFactory;

namespace AbstractFactoryExample.Client
{
    internal class Client
    {
        public static void MainClient()
        {
            Console.WriteLine("Who are you? (A)dult or (C)hild?");
            char input = Console.ReadKey().KeyChar;

            RecipeFactory factory;

            switch (input)
            {
                case 'A':
                    factory = new AdultCusineFactory();
                    break;

                case 'C':
                    factory = new ChildCusineFactory();
                    break;
                    
                default:
                    throw new NotImplementedException();
            }

            var sandwich = factory.CreateSandwich();
            var dessert = factory.CreateDessert();

            Console.WriteLine("\nSandwich: " + sandwich.GetType().Name);
            Console.WriteLine("Dessert: " + dessert.GetType().Name);

            Console.ReadKey();

        }
    }
}
