using FacadeExample.Facade;
using FacadeExample.Subsytem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample.Client
{
    internal class Client
    {
        public static void MainCLient()
        {
            Server server = new Server();

            Console.WriteLine("Hello!  I'll be your server today. What is your name?");
            var name = Console.ReadLine();

            Patron patron = new Patron(name);

            Console.WriteLine("Hello " + patron.Name
                      + ". What appetizer would you like? (1-15):");
            var appID = int.Parse(Console.ReadLine());

            Console.WriteLine("That's a good one.  What entree would you like? (1-20):");
            var entreeID = int.Parse(Console.ReadLine());

            Console.WriteLine("A great choice!  Finally, what drink would you like? (1-60):");
            var drinkID = int.Parse(Console.ReadLine());

            Console.WriteLine("I'll get that order in right away.");

            //Here's what the Facade simplifies
            server.PlaceOrder(patron, appID, entreeID, drinkID);

            Console.ReadKey();
        }
    }
}
