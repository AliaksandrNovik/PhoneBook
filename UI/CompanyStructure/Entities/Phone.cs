using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.CompanyStructure.Entities
{
    class Phone
    {
        public Phone(string number, Department department = null, Employee employee = null)
        { }

        public string Number
        { get; set; }

        public Department Department
        { get; set; }

        public Employee Employee
        { get; set; }
    }
}
