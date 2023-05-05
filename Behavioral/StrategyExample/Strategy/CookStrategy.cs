﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Strategy
{
    internal abstract class CookStrategy
    {
        public abstract void Cook(string food);
    }
}
