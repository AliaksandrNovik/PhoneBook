using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;

namespace UI.AdminUI
{
    class EmployeeWrapperItem
    {
        public EmployeeWrapperItem(Employee employee)
        {
            this.Employee = Employee;
        }

        public Employee Employee
        { get; set; }

        public string Name
        {
            get
            {
                return this.Employee.FirstName + " " + this.Employee.LastName + " " + this.Employee.Patronym;
            }
        }
    }
}
