using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface IDepartmentService : IReadOnlyDepartmentService
    {
        void CreateDepartment(
            string name, string headEmployee, 
            IReadOnlyCollection<string> subordinateDepartments,
            string parentDepartment
                );
        void UpdateDepartment(Department department);
        void DeleteEmployee(string id);        
    }
}
