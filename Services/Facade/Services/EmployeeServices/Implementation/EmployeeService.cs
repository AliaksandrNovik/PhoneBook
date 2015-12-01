using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public class EmployeeService : IEmployeeService
    {
        public event EmployeePassDelegate EmployeeCreated;
        public event PassEmployeeId EmployeeDeleted;
        public event EmployeePassDelegate EmployeeUpdated;

        public void CreateEmployee(string firstName, string lastName, string patronym, Date birthDate, Gender gender, string place, EntityId departmentId)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(EntityId employeeId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Employee> GetByDepartmentId(EntityId departmentId)
        {
            throw new NotImplementedException();
        }

        public Employee GetByUserId(EntityId id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(EntityId id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
