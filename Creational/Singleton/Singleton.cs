﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal sealed class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;        
        }

        public void someBussinessLogic()
        {
            Console.WriteLine("some Bussiness logic");
        }

    }
}
