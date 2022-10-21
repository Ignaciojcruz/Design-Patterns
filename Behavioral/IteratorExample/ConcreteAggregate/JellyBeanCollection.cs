using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorExample.Aggregate;
using IteratorExample.ConcreteIterator;


namespace IteratorExample.ConcreteAggregate
{
    internal class JellyBeanCollection : ICandyCollection
    {
        private ArrayList _items = new ArrayList();

        public JellyBeanIterator CreateIterator()
        {
            return new JellyBeanIterator(this);
        }

        // Gets jelly bean count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
