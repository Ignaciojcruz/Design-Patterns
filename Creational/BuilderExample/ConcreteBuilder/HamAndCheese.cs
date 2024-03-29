﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderExample.Builder;
using BuilderExample.Product;

namespace BuilderExample.ConcreteBuilder
{
    internal class HamAndCheese : SandwichBuilder
    {
        public HamAndCheese()
        {
            sandwich = new Sandwich("HamAndCheese");
        }

        public override void AddBread()
        {
            sandwich["bread"] = "White";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "American";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo";
        }

        public override void AddMeats()
        {
            sandwich["meat"] = "Ham";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "None";
        }
    }
}
