using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{ 
    //TODO async
    public interface IEmployeeService : IReadOnlyEmployeeService
    {
        IEmployee CreateEmployee(
            string firstName, string lastName, string patronym, 
            BLL.Date birthDate, string place,
            string departmentId
            );

        bool UpdateEmployee(IEmployee employee);

        bool DeleteEmployee(string employeeId);
    }
}
