using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository.Implement.Ent
{
    class ReposEmpl :IRepositoryEmployee
    {
        private Dictionary<String, Employee> listEmployeeId;
        private String nameEmpl;

        public Employee getEmplbyId(String id)
        {
            Employee employee;
            listEmployeeId.TryGetValue(id, out employee);
            return employee;
        }

        public Employee createEmployee(string name, string employeeId, IReadOnlyCollection<string> subDepartmens = null, IReadOnlyCollection<string> employees = null, IReadOnlyCollection<string> phones = null)
        {
            employeeId = Guid.NewGuid().ToString("N"); ;
            Employee testEmpl = new Employee(name,employeeId);
            listEmployeeId.Add(employeeId, testEmpl);
            return getEmplbyId(employeeId);
        }

        public bool updateEmployee(string name, string departmentId, IReadOnlyCollection<string> subDepartmens = null, IReadOnlyCollection<string> employees = null, IReadOnlyCollection<string> phones = null)
        {
            return true;
        }

        public bool deleteEmployee(string name, string employeeId, IReadOnlyCollection<string> subDepartmens = null, IReadOnlyCollection<string> employees = null, IReadOnlyCollection<string> phones = null)
        {
            listEmployeeId.Remove(employeeId);
            return true;
        }

        public ReposEmpl()
        {
            listEmployeeId = new Dictionary<string, Employee>();
        }

    }
}
