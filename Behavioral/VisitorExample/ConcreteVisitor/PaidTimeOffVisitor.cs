using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorExample.ConcreteElement;
using VisitorExample.Visitor;

namespace VisitorExample.ConcreteVisitor
{
    internal class PaidTimeOffVisitor : IVisitor
    {
        public void Visit(Element.Element element)
        {
            Employee employee = element as Employee;

            employee.PaidTimeOffDays += 3;
            Console.WriteLine("{0} {1}'s new vacation days: {2}", employee.GetType().Name, employee.Name, employee.PaidTimeOffDays);
        }
    }
}
