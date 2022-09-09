using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderExample.Builder;
using BuilderExample.Director;
using BuilderExample.ConcreteBuilder;

namespace BuilderExample.Client
{
    internal class Client
    {
        public static void MainClient()
        {
            SandwichBuilder builder;

            AssemblyLine shop = new AssemblyLine();

            builder = new HamAndCheese();
            shop.Assemble(builder);
            builder.SandWich.Show();

            builder = new BLT();
            shop.Assemble(builder);
            builder.SandWich.Show();

            builder = new TurkeyClub();
            shop.Assemble(builder);
            builder.SandWich.Show();

            Console.ReadKey();
        }
    }
}
