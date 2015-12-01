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
            string name, EntityId headEmployee, 
            IReadOnlyCollection<EntityId> subordinateDepartments,
            EntityId parentDepartment
                );
        void UpdateDepartment(Department department);
        void DeleteEmployee(EntityId id);        
    }
}
