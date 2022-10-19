using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample.Subsytem
{
    internal class Bar : IKitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go mix the drink
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }
}
