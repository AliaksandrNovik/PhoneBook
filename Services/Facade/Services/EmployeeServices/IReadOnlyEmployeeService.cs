using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    //public delegate void EmployeePassDelegate(Employee employee);
    //public delegate void PassEmployeeId(String employeeId);

    public interface IReadOnlyEmployeeService
    {
        IEmployee GetEmployeeById(String id);
        IReadOnlyCollection<IEmployee> GetAll();
        IReadOnlyCollection<IEmployee> GetByDepartmentId(String departmentId);
        //notifications
        //event EmployeePassDelegate EmployeeCreated;
        //event EmployeePassDelegate EmployeeUpdated;
        //event PassEmployeeId EmployeeDeleted;
    }
}
