using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private FileRepository<Employee> _fileRepository;
        public EmployeeRepository()
        {
            _fileRepository = FileRepository<Employee>.GetInstance("Employee.txt");
        }

        public Employee CreateEmployee(string firstName, string lastName, string patronym, Date birthDate, string place, string departmentId)
        {
            var employee = new Employee(firstName, lastName, patronym, birthDate, place, departmentId);
            _fileRepository.Upsert(employee);
            return employee;
        }

        public bool DeleteEmployee(string id)
        {
            return _fileRepository.Delete(id);
        }

        public IReadOnlyCollection<Employee> GetAllEmployee()
        {
            return _fileRepository.GetAll();
        }

        public Employee GetEmployeeById(string employeeId)
        {
            return _fileRepository.GetById(employeeId);
        }

        public bool UpdateEmployee(Employee employee)
        {
            bool canUpdate = (_fileRepository.GetById(employee.Id) != null);
            if (canUpdate)
            {
                _fileRepository.Upsert(employee);
            }
            return canUpdate;
        }
    }
}
