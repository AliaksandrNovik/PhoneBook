using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public class DepartmentService : IDepartmentService
    {
        public event PassDepartment DepartmentCreated;
        public event PassDepartmentId DepartmentDeleted;
        public event PassDepartment DepartmentUpdated;

        public void CreateDepartment(string name, String headEmployee, IReadOnlyCollection<String> subordinateDepartments, String parentDepartment)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(String id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Department> GetAll()
        {
            throw new NotImplementedException();
        }

        public Department GetById(String id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Department> GetByParentId(String parentId)
        {
            throw new NotImplementedException();
        }

        public Department GetDepartmentByManagerUserId(String id)
        {
            throw new NotImplementedException();
        }

        public Department GetRootDepartment()
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartment(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
