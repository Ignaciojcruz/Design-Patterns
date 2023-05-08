using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorExample.Visitor;

namespace VisitorExample.ConcreteElement
{
    internal class Employee : Element.Element
    {
        public string Name { get; set; }
        public double AnnualSalary { get; set; }
        public int PaidTimeOffDays { get; set; }


        public Employee(string name, double salary, int paidTime) 
        {
            Name = name;
            AnnualSalary = salary;
            PaidTimeOffDays = paidTime;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
