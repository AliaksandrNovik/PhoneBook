using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.EmployeeService
{
    public class DepartmentID
    { }

    public class Employee
    { }

    public interface IReadOnlyEmployeeService
    {
        IReadOnlyCollection<Employee> Employees
        { get; }

        Employee GetEmployeeById(EmployeeID id);
    }
}
