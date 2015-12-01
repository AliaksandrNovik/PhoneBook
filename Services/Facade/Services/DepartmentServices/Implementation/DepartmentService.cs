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

        public void CreateDepartment(string name, EntityId headEmployee, IReadOnlyCollection<EntityId> subordinateDepartments, EntityId parentDepartment)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(EntityId id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Department> GetAll()
        {
            throw new NotImplementedException();
        }

        public Department GetById(EntityId id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Department> GetByParentId(EntityId parentId)
        {
            throw new NotImplementedException();
        }

        public Department GetDepartmentByManagerUserId(EntityId id)
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
