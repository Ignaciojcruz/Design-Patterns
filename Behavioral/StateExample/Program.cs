using StateExample.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Let's cook a steak!
            Steak account = new Steak("T-Bone");

            // Apply temperature changes
            account.AddTemp(120);
            account.AddTemp(15);
            account.AddTemp(15);
            account.RemoveTemp(10); //Yes I know cooking doesn't work this way, bear with me.
            account.RemoveTemp(15);
            account.AddTemp(20);
            account.AddTemp(20);
            account.AddTemp(20);

            Console.ReadKey();
        }
    }
}
