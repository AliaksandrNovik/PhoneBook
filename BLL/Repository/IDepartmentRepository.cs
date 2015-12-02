using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IDepartmentRepository
    {
        IReadOnlyCollection<Department> GetAllDepartment();
        Department GetDepartmentById(string departmentId);
        Department CreateDepartment(string name, string parentId);
        bool UpdateDepartment(Department department);
        bool DeleteDepartment(string departmentId);
    }
}
