using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public delegate void PassDepartment(Department department);
    public delegate void PassDepartmentId(String departmentId);
    
    public interface IReadOnlyDepartmentService
    {
        //queries
        Department GetById(String id);
        IReadOnlyCollection<Department> GetAll();
        IReadOnlyCollection<Department> GetByParentId(String parentId);
        Department GetRootDepartment();
        Department GetDepartmentByManagerUserId(String id);
        
        //notifications
        event PassDepartment DepartmentCreated;
        event PassDepartment DepartmentUpdated;
        event PassDepartmentId DepartmentDeleted;

    }
}
