using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.CompanyStructure.Entities
{
    public class Department
    {
        public Department(
            string name, Employee head,
            List<Employee> employees, List<Department> subDepartments, List<Phone> phones)
        {
            this.Name = name;
            this.Head = head;
            this.SubordinateDepartments = subDepartments;
            this.Phones = phones;
        }

        public string Name
        { get; set; }

        public Employee Head
        { get; set; }

        public List<Employee> Employees
        { get; set; }

        public List<Department> SubordinateDepartments
        { get; set; }

        public List<Phone> Phones
        { get; set; }
    }
}
