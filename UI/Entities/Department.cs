using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Entities
{
    public interface Department
    {
        string DepartmentID
        { get; }

        string Name
        { get; set; }

        IReadOnlyCollection<Department> SubrotdinateDepartments
        { get; }

        IReadOnlyCollection<Employee> Employees
        { get; }

        IReadOnlyCollection<Phone> Phones
        { get; }
    }
}
