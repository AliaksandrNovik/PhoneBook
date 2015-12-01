using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository.Implement.Ent
{
    interface IRepositoryDepartment
    {

       Department createDepartment(string name, string departmentId,
            IReadOnlyCollection<string> subDepartmens = null,
            IReadOnlyCollection<string> employees = null,
            IReadOnlyCollection<string> phones = null);//args
        bool updateDepartment(string name, string departmentId,
            IReadOnlyCollection<string> subDepartmens = null,
            IReadOnlyCollection<string> employees = null,
            IReadOnlyCollection<string> phones = null);
        bool deleteDepartment(string name, string departmentId,
            IReadOnlyCollection<string> subDepartmens = null,
            IReadOnlyCollection<string> employees = null,
            IReadOnlyCollection<string> phones = null);
    }
}
