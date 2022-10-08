using FacadeExample.Subsytem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample.Facade
{
    internal class Server
    {
        private ColdPrep _coldPrep = new ColdPrep();
        private Bar _bar = new Bar();
        private HotPrep _hotPrep = new HotPrep();

        public Order PlaceOrder(Patron patron,
                            int coldAppID,
                            int hotEntreeID,
                            int drinkID)
        {
            Console.WriteLine("{0} places order for cold app #"
                              + coldAppID.ToString()
                              + ", hot entree #" + hotEntreeID.ToString()
                              + ", and drink #" + drinkID.ToString() + ".");

            Order order = new Order();

            order.Appetizer = _coldPrep.PrepDish(coldAppID);
            order.Entree = _hotPrep.PrepDish(hotEntreeID);
            order.Drink = _bar.PrepDish(drinkID);

            return order;
        }
    }
}
