using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorExample.Element;

namespace VisitorExample.Visitor
{
    internal interface IVisitor
    {
        void Visit(Element.Element element);
    }
}
