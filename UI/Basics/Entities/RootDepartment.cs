using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Basics
{
    public class RootDepartment : Department
    {
        public RootDepartment(
            string name, Employee head,
            List<Employee> employees, List<Department> subDepartments, List<Phone> phones,
            List<Employee> unattachedEmployees, List<Phone> unattachedPhones) :
                base(name, head, employees, subDepartments, phones)
        {
            this.UnattachedEmployee = unattachedEmployees;
            this.UnattachedPhones = unattachedPhones;
        }

        public List<Employee> UnattachedEmployee
        { get; set; }

        public List<Phone> UnattachedPhones
        { get; set; }
    }
}
