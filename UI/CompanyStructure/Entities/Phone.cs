using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.CompanyStructure.Entities
{
    public class Phone
    {
        public Phone(string number, Department department = null, Employee employee = null)
        { }

        public string Number
        { get; }

        public Department Department
        { get; }

        public Employee Employee
        { get; }
    }
}
