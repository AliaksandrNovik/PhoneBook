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
        void CreateEmployee(
            string firstName, string lastName, string patronym, 
            Date birthDate, Gender gender, string place,
            EntityId departmentId
            );

        void UpdateEmployee(Employee employee);

        void DeleteEmployee(EntityId employeeId);
    }
}
