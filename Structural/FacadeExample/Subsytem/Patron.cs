using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample.Subsytem
{
    internal class Patron
    {
        private string _name;

        public Patron(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
