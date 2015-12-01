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

        public void CreateEmployee(string firstName, string lastName, string patronym, Date birthDate, Gender gender, string place, String departmentId)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(String employeeId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Employee> GetByDepartmentId(String departmentId)
        {
            throw new NotImplementedException();
        }

        public Employee GetByUserId(String id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(String id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
