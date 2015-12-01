using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository.Implement.Ent
{
    interface IRepositoryEmployee
    {
        Employee createEmployee(string name, string departmentId,
           IReadOnlyCollection<string> subDepartmens = null,
           IReadOnlyCollection<string> employees = null,
           IReadOnlyCollection<string> phones = null);//args
        bool updateEmployee(string name, string departmentId,
            IReadOnlyCollection<string> subDepartmens = null,
            IReadOnlyCollection<string> employees = null,
            IReadOnlyCollection<string> phones = null);
        bool deleteEmployee(string name, string departmentId,
            IReadOnlyCollection<string> subDepartmens = null,
            IReadOnlyCollection<string> employees = null,
            IReadOnlyCollection<string> phones = null);
    }
}
