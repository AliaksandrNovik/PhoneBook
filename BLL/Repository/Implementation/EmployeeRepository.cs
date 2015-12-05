using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Serialization;

namespace BLL.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        Dictionary<string, Employee> _employeeDictionary;
        private readonly string FileName = "Employee.txt";

        public EmployeeRepository()
        {
            if(!File.Exists(FileName))
            {
                var file = File.Create(FileName);
                file.Close();
                _employeeDictionary = new Dictionary<string, Employee>();
            }
            else
            {
                _employeeDictionary = Serializer.DeSerializeObject<Dictionary<string, Employee>>(FileName);
            }
        }

        public Employee CreateEmployee(string firstName, string lastName, string patronym, Date birthDate, string place, string departmentId)
        {
            var employee = new Employee(firstName, lastName, patronym, birthDate, place, departmentId);
            _employeeDictionary.Add(employee.Id, employee);
            UpdateFile();
            return employee;
        }

        public bool DeleteEmployee(string id)
        {
            bool result = _employeeDictionary.Remove(id);
            UpdateFile();
            return result;
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

        private void UpdateFile()
        {
            Serializer.SerializeObject(_employeeDictionary, FileName);
        }
    }
}
