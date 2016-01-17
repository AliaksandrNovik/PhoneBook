using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IDepartmentRepository
    {
        IReadOnlyCollection<Department> GetAllDepartment();
        Department GetDepartmentById(string departmentId);
        Department CreateDepartment(string name, string parentId);
        string GetRootId();
        bool UpdateDepartment(Department department);
        bool DeleteDepartment(string departmentId);
    }
}
