using StrategyExample.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Context
{
    internal class CookingMethod
    {
        private string food;
        private CookStrategy cookStrategy;

        public void SetCookStrategy(CookStrategy cookStrategy)
        {
            this.cookStrategy = cookStrategy;
        }

        public void setFood(string name)
        {
            this.food = name;
        }

        public void Cook()
        {
            cookStrategy.Cook(food);
            Console.WriteLine();
        }
    }
}
