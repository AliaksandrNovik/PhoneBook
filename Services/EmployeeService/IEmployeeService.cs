using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.EmployeeService
{
    public interface IEmployeeService : IReadOnlyEmployeeService
    {
        void InsertEmployee(Employee employee);

        void UpdateEmployee(Employee employee);

        void RemoveEmployee(Employee employee);
    }
}
