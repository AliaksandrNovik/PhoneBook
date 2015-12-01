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
            string name, String headEmployee, 
            IReadOnlyCollection<String> subordinateDepartments,
            String parentDepartment
                );
        void UpdateDepartment(Department department);
        void DeleteEmployee(String id);        
    }
}
