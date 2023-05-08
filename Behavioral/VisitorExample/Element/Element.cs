using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorExample.Visitor;

namespace VisitorExample.Element
{
    internal abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
