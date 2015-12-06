using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;
using BLL.Repository;

namespace Services.Implementation
{
    public class DepartmentService : IDepartmentService
    {
        private DepartmentRepository _departmentRepository = new DepartmentRepository();

        public IDepartment Create(string name, string parentDepartmentId)
        {
            var repDepartment = _departmentRepository.CreateDepartment(name, parentDepartmentId);
            var bllDepartment = new Department(repDepartment.Id, name, parentDepartmentId);
            return bllDepartment;
        }

        public bool Delete(IDepartment department)
        {
            return _departmentRepository.DeleteDepartment(department.Id);
        }

        public IReadOnlyCollection<IDepartment> GetAll()
        {
            List<IDepartment> result = new List<IDepartment>();
            foreach (var repDepartment in _departmentRepository.GetAllDepartment())
            {
                result.Add(new Department(repDepartment.Id, repDepartment.Name, repDepartment.ParentId));
            }

            return result;
        }

        public IDepartment GetById(string id)
        {
            var repDepartment = _departmentRepository.GetDepartmentById(id);
            if (repDepartment != null)
            {
                return new Department(repDepartment.Id, repDepartment.Name, repDepartment.Name);
            }
            else
            {
                return null;
            }
        }

        public IReadOnlyCollection<IDepartment> GetByParentId(string parentId)
        {
            return GetAll().Where(x => x.ParentDepartmentId == parentId).ToList();
        }

        public string GetRootId()
        {
            return _departmentRepository.GetRootId();
        }

        public bool Update(IDepartment department)
        {
            var repDepartment = _departmentRepository.GetDepartmentById(department.Id);
            if (repDepartment == null)
            {
                return false;
            }
            else
            {
                repDepartment.Name = department.Name;
                repDepartment.ParentId = department.ParentDepartmentId;
                return _departmentRepository.UpdateDepartment(repDepartment);
            }
        }
    }
}
