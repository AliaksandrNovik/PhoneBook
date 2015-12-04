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
        IDepartment GetById(string id);
        IReadOnlyCollection<IDepartment> GetAll();
        IReadOnlyCollection<IDepartment> GetByParentId(string parentId);
        string GetRootDepartmentId();        
        //notifications
        //event PassDepartment DepartmentCreated;
        //event PassDepartment DepartmentUpdated;
        //event PassDepartmentId DepartmentDeleted;

    }
}
