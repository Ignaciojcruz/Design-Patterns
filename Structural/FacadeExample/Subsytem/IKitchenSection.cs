using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample.Subsytem
{
    internal interface IKitchenSection
    {
        FoodItem PrepDish(int DishID);
    }
}
