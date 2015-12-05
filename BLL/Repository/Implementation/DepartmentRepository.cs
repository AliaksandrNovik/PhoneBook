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
        private readonly string fileName = "Departmet.txt";
        Dictionary<string, Department> _departmentsDictionary;

        public DepartmentRepository()
        {
            if (!File.Exists(fileName))
            {
                var file = File.Create(fileName);
                file.Close();
                _departmentsDictionary = new Dictionary<string, Department>();
            }
            else
            {
                _departmentsDictionary = Serializer.DeSerializeObject<Dictionary<string, Department>> (fileName);
            }
        }

        public Department CreateDepartment(string name, string parentId)
        {
            var newDepartment = new Department(name, parentId);
            _departmentsDictionary.Add(newDepartment.Id, newDepartment);
            UpdateFile();
            return newDepartment;
        }

        public bool DeleteDepartment(string departmentId)
        {
            bool result = _departmentsDictionary.Remove(departmentId);
            UpdateFile();
            return result;
        }

        public IReadOnlyCollection<Department> GetAllDepartment()
        {
            return _departmentsDictionary.Values.ToList();            
        }

        public Department GetDepartmentById(string departmentId)
        {
            if (_departmentsDictionary.ContainsKey(departmentId))
            {
                return _departmentsDictionary[departmentId];
            }
            else
            {
                return null;
            }
        }


        public string GetRootId()
        {
            return RootId;
        }

        public bool UpdateDepartment(Department department)
        {
            var key = department.Id;
            if (_departmentsDictionary.ContainsKey(key))
            {
                var storedDepartment = _departmentsDictionary[key];
                storedDepartment.Name = department.Name;
                storedDepartment.ParentId = department.ParentId;
                UpdateFile();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UpdateFile()
        {
            Serializer.SerializeObject(_departmentsDictionary, fileName);
        }
    }
}
