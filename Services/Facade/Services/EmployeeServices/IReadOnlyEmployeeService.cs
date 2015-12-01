using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    //TODO async
    public delegate void EmployeePassDelegate(Employee employee);
    public delegate void PassEmployeeId(EntityId employeeId);

    public interface IReadOnlyEmployeeService
    {
        Employee GetEmployeeById(EntityId id);
        IReadOnlyCollection<Employee> GetAll();
        IReadOnlyCollection<Employee> GetByDepartmentId(EntityId departmentId);
        Employee GetByUserId(EntityId id);

        //notifications
        event EmployeePassDelegate EmployeeCreated;
        event EmployeePassDelegate EmployeeUpdated;
        event PassEmployeeId EmployeeDeleted;
    }
}
