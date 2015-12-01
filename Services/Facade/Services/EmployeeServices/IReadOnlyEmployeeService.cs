using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    //TODO async
    public delegate void EmployeePassDelegate(Employee employee);
    public delegate void PassEmployeeId(String employeeId);

    public interface IReadOnlyEmployeeService
    {
        Employee GetEmployeeById(String id);
        IReadOnlyCollection<Employee> GetAll();
        IReadOnlyCollection<Employee> GetByDepartmentId(String departmentId);
        Employee GetByUserId(String id);

        //notifications
        event EmployeePassDelegate EmployeeCreated;
        event EmployeePassDelegate EmployeeUpdated;
        event PassEmployeeId EmployeeDeleted;
    }
}
