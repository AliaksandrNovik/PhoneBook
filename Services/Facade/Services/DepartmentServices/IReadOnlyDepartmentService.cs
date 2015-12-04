using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    //public delegate void PassDepartment(Department department);
    //public delegate void PassDepartmentId(String departmentId);
    
    public interface IReadOnlyDepartmentService
    {
        //queries
        Department GetById(string id);
        IReadOnlyCollection<Department> GetAll();
        IReadOnlyCollection<Department> GetByParentId(string parentId);
        Department GetRootDepartment();
        Department GetDepartmentByManagerUserId(string id);
        
        //notifications
        //event PassDepartment DepartmentCreated;
        //event PassDepartment DepartmentUpdated;
        //event PassDepartmentId DepartmentDeleted;

    }
}
