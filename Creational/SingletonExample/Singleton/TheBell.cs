using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample.Singleton
{
    internal sealed class TheBell
    {
        private static TheBell bellConnection;
        private static object syncRoot = new object();

        private TheBell() { }

        public static TheBell Instance
        {
            get
            {
                lock(syncRoot)
                {
                    if(bellConnection == null)
                    {
                        bellConnection = new TheBell();
                    }
                }

                return bellConnection;
            }
        }

        public void Ring()
        {
            Console.WriteLine("Ding! Order Up!");
        }
    }
}
