using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            foreach (string part in _parts)
            {
                str += part + ", ";
            }

            str = str.Remove(str.Length - 2);

            return "Product parts: " + str;
        }
    }
}
