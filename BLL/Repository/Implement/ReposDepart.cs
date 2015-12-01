using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository.Implement.Ent
{
     public class ReposDepart : IRepositoryDepartment
        {

        private Dictionary<String, Department> listDepartmId;
        private String nameDep;

        public Department getDepbyId(String id)
        {
            Department dep;
            listDepartmId.TryGetValue(id, out dep);
            return dep;
        }
      
        public ReposDepart()
        {
            listDepartmId = new Dictionary<string, Department>();
        }

        public Department createDepartment(string name, string departmentId,
            IReadOnlyCollection<string> subDepartmens = null, 
            IReadOnlyCollection<string> employees = null,
            IReadOnlyCollection<string> phones = null)
        {
            departmentId = Guid.NewGuid().ToString("N"); ;
            Department templDep = new Department(name, departmentId);
            listDepartmId.Add(departmentId, templDep);
            return getDepbyId(departmentId);

        }

        public bool updateDepartment(string name, string departmentId, IReadOnlyCollection<string> subDepartmens = null, IReadOnlyCollection<string> employees = null, IReadOnlyCollection<string> phones = null)
        {
            return true;
        }

        public bool deleteDepartment(string name, string departmentId, IReadOnlyCollection<string> subDepartmens = null, IReadOnlyCollection<string> employees = null, IReadOnlyCollection<string> phones = null)
        {
            listDepartmId.Remove(departmentId);
            return true;
        }
    }
}
