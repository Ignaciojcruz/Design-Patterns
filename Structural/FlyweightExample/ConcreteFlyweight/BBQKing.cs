using FlyweightExample.Flyweight;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlyweightExample.ConcreteFlyweight
{
    internal class BBQKing : Slider
    {
        public BBQKing()
        {
            Name = "BBQ King";
            Cheese = "American";
            Toppings = "Onion rings, lettuce, and BBQ sauce";
            Price = 2.49m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": "
                              + Name + " - topped with "
            + Cheese + " cheese and "
                              + Toppings + "! $" + Price.ToString());
        }
    }
}
