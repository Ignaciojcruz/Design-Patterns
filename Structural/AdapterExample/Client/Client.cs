using AdapterExample.Adapter;
using AdapterExample.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample.Client
{
    internal class Client
    {
        public static void MainClient()
        {
            //Non-adapted
            Meat unknown = new Meat("Beef");
            unknown.LoadData();

            //Adapted
            MeatDetails beef = new MeatDetails("Beef");
            beef.LoadData();

            MeatDetails turkey = new MeatDetails("Turkey");
            turkey.LoadData();

            MeatDetails chicken = new MeatDetails("Chicken");
            chicken.LoadData();

            Console.ReadKey();
        }
    }
}
