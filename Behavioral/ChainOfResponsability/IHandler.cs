﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    internal interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(object request);
    }
}
