using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public interface IEmployeeRepository
    {
        IReadOnlyCollection<Employee> GetAllEmployee();
        Employee GetEmployeeById(string employeeId);
        Employee CreateEmployee(
            string firstName, string lastName, string patronym,
            Date birthDate, string place, string departmentId
            );
        bool UpdateEmployee(Employee employee);
        bool DeleteEmployee(string id);
    }
}
