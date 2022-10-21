using IteratorExample.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample.Aggregate
{
    internal interface ICandyCollection
    {
        IJellyBeanIterator CreateIterator();
    }
}
