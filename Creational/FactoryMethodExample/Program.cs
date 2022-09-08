using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodExample.ConcreteCreator;
using FactoryMethodExample.Product;
using FactoryMethodExample.Creator;

namespace FactoryMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var turkeySandwich = new TurkeySandwich();
            var dagWood = new Dagwood();

            Console.WriteLine("listado de ingredientes de Turkey sandwich" );
            listaIngredientes(turkeySandwich);

            Console.WriteLine("listado de ingredientes de dagwood sandwich");
            listaIngredientes(dagWood);

            Console.ReadLine();
        }

        public static void listaIngredientes(Sandwich sand)
        {
            foreach (Ingredient ing in sand.Ingredients)
            {
                Console.WriteLine(ing.GetType().Name);
            }
        }
    }
}
