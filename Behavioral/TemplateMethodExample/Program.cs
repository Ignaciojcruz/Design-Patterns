using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodExample.ConcreteClass;

namespace TemplateMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sourdough sourdough = new Sourdough();
            sourdough.Make();

            TwelveGrain twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            WholeWheat wheat = new WholeWheat();
            wheat.Make();

            Console.ReadKey();
        }
    }
}
