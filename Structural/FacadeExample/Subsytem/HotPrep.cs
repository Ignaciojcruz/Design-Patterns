﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample.Subsytem
{
    internal class HotPrep : IKitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go prep the hot entree
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }
}
