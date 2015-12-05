using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly string fileName = "Employee.txt";
        public Employee CreateEmployee(string firstName, string lastName, string patronym, Date birthDate, string place, string departmentId)
        {
            var employee = new Employee(firstName, lastName, patronym, birthDate, place, departmentId);
            return employee;
        }

        public bool DeleteEmployee(string id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Employee> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(string employeeId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
