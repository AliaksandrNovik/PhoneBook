using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Repository;
using Services.Facade;

namespace Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository = new EmployeeRepository();

        public IEmployee CreateEmployee(string firstName, string lastName, string patronym, BLL.Date birthDate, string place, string departmentId)
        {
            var repEmployee = _employeeRepository.CreateEmployee(firstName, lastName, patronym, birthDate, place, departmentId);
            var bllDepartment = new Employee(repEmployee);
            return bllDepartment;
        }

        public bool DeleteEmployee(string employeeId)
        {
            return _employeeRepository.DeleteEmployee(employeeId);
        }

        public IReadOnlyCollection<IEmployee> GetAll()
        {
            List<IEmployee> result = new List<IEmployee>();
            foreach (var repEmployee in _employeeRepository.GetAllEmployee())
            {
                result.Add(new Employee(repEmployee));
            }
            return result;
        }

        public IReadOnlyCollection<IEmployee> GetByDepartmentId(string departmentId)
        {
            return GetAll().Where(x => x.DepartmentId == departmentId).ToList();
        }

        public IEmployee GetEmployeeById(string id)
        {
            var repEmployee = _employeeRepository.GetEmployeeById(id);
            if (repEmployee != null)
            {
                return new Employee(repEmployee);
            }
            else
            {
                return null;
            }
        }

        public bool UpdateEmployee(IEmployee employee)
        {
            var repEmployee = _employeeRepository.GetEmployeeById(employee.Id);
            if (repEmployee == null)
            {
                return false;
            }
            else
            {
                repEmployee.FirstName = employee.FirstName;
                repEmployee.LastName = employee.LastName;
                repEmployee.Patronym = employee.Patronym;
                repEmployee.Place = employee.Place;
                repEmployee.BirthDate = employee.BirthDate;
                repEmployee.DepartmentId = employee.DepartmentId;
                return _employeeRepository.UpdateEmployee(repEmployee);
            }
        }
    }
}
