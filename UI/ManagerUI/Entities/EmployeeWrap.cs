using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Basics;

namespace UI.ManagerUI
{
    public class EmployeeWrap
    {
        public EmployeeWrap(Employee employee, Department department)
        {
            this.Employee = employee;
            this.Department = department;
        }

        public string Name
        {
            get
            {
                return this.Employee?.GetFullName();
            }
        }

        public string Birthday
        {
            get
            {
                return this.Employee?.BirthDay?.ToString();
            }
        }

        public string DepartmentName
        {
            get
            {
                return this.Department?.Name;
            }
        }

        public string Place
        {
            get
            {
                return this.Employee?.Place;
            }
        }

        public Employee Employee
        { get; private set; }

        public Department Department
        { get; private set; }
    }
}
