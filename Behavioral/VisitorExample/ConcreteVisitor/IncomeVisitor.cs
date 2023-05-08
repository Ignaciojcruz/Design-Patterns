using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorExample.ConcreteElement;
using VisitorExample.Visitor;

namespace VisitorExample.ConcreteVisitor
{
    internal class IncomeVisitor : IVisitor
    {
        public void Visit(Element.Element element)
        {
            Employee employee = element as Employee;

            employee.AnnualSalary *= 1.10;
            Console.WriteLine("{0} {1}'s new income: {2:C}", employee.GetType().Name, employee.Name, employee.AnnualSalary);
        }
    }
}
