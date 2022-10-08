using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample.Subsytem
{
    internal class Order
    {
        public FoodItem Appetizer { get; set; }
        public FoodItem Entree { get; set; }
        public FoodItem Drink { get; set; }
    }
}
