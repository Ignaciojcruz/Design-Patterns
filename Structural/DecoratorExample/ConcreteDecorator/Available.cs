using DecoratorExample.Component;
using DecoratorExample.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.ConcreteDecorator
{
    internal class Available : Decorator.Decorator
    {
        public int NumAvailable { get; set; } //How many can we make?
        protected List<string> customers = new List<string>();
        public Available(RestaurantDish dish, int numAvailable) : base(dish)
        {
            NumAvailable = numAvailable;
        }

        public void OrderItem(string name)
        {
            if (NumAvailable > 0)
            {
                customers.Add(name);
                NumAvailable--;
            }
            else
            {
                Console.WriteLine("\nNot enough ingredients for " + name + "'s order!");
            }
        }

        public override void Display()
        {
            base.Display();

            foreach (var customer in customers)
            {
                Console.WriteLine("Ordered by " + customer);
            }
        }
    }
}
