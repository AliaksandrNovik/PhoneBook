using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.CompanyStructure.Entities
{
    class Department
    {
        public IReadOnlyCollection<Employee> Employees
        { get; set; }

        public IReadOnlyCollection<Department> SubordinateDepartments
        { get; set; }

        public IReadOnlyCollection<Phone> Phones
        { get; set; }
    }
}
