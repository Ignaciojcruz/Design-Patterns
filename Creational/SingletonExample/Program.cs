using SingletonExample.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TheBell b1 = TheBell.Instance;
            TheBell b2 = TheBell.Instance;

            if (b1 == b2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            b1.Ring();

            Console.ReadKey();
        }
    }
}
