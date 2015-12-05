using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using BLL.Serialization;

namespace BLL.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly static string RootId = "Root";
        private FileRepository<Department> _fileRepository;
        public DepartmentRepository()
        {
            _fileRepository = new FileRepository<Department>("Departmet.txt");
        }

        public Department CreateDepartment(string name, string parentId)
        {
            var newDepartment = new Department(name, parentId);
            _fileRepository.Upsert(newDepartment);
            return newDepartment;
        }

        public bool DeleteDepartment(string departmentId)
        {
            return _fileRepository.Delete(departmentId);
        }

        public IReadOnlyCollection<Department> GetAllDepartment()
        {
            return _fileRepository.GetAll();
        }

        public Department GetDepartmentById(string departmentId)
        {
            return _fileRepository.GetById(departmentId);
        }

        public string GetRootId()
        {
            return RootId;
        }

        public bool UpdateDepartment(Department department)
        {
            var oldValue = _fileRepository.GetById(department.Id);
            bool updated = (oldValue != null);

            _fileRepository.Upsert(department);
            return updated;
        }
    }
}
