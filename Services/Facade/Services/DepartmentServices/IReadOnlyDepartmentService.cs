using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public delegate void PassDepartment(Department department);
    public delegate void PassDepartmentId(EntityId departmentId);
    
    public interface IReadOnlyDepartmentService
    {
        //queries
        Department GetById(EntityId id);
        IReadOnlyCollection<Department> GetAll();
        IReadOnlyCollection<Department> GetByParentId(EntityId parentId);
        Department GetRootDepartment();
        Department GetDepartmentByManagerUserId(EntityId id);
        
        //notifications
        event PassDepartment DepartmentCreated;
        event PassDepartment DepartmentUpdated;
        event PassDepartmentId DepartmentDeleted;

    }
}
