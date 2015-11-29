using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    //TODO async
    public delegate void PassEmployee(Employee employee);
    public delegate void PassEmployeeId(EntityId employeeId);

    public interface IReadOnlyEmployeeService
    {
        Employee GetEmployeeById(EntityId id);
        IReadOnlyCollection<Employee> GetAll();
        IReadOnlyCollection<Employee> GetByDepartmentId(EntityId departmentId);

        //notifications
        event PassEmployee EmployeeCreated;
        event PassEmployee EmployeeUpdated;
        event PassEmployeeId EntityDeleted;
    }
}
