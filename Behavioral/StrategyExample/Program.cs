using StrategyExample.Context;
using StrategyExample.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CookingMethod method = new CookingMethod();

            Console.WriteLine("What food would you like to cook?");
            var food = Console.ReadLine();
            method.setFood(food);

            Console.WriteLine("What cooking strategy would you like to use (1-3)?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch (input)
            {
                case 1:
                    method.SetCookStrategy(new Grilling());
                    method.Cook();
                    break;

                case 2:
                    method.SetCookStrategy(new OvenBaking());
                    method.Cook();
                    break;
                    
                case 3:
                    method.SetCookStrategy(new DeepFrying());
                    method.Cook();
                    break;

                default:
                    Console.WriteLine("Invalid Selection!");
                    break;

            }

            Console.ReadKey();
        }
    }
}
