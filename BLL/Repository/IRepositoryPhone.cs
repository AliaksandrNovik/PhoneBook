using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository.Implement.Ent
{
    interface IRepositoryPhone
    {
        Phone createPhone(string name, string departmentId,
            IReadOnlyCollection<string> subDepartmens = null,
            IReadOnlyCollection<string> employees = null,
            IReadOnlyCollection<string> phones = null);//args
        bool updatePhone(string name, string departmentId,
            IReadOnlyCollection<string> subDepartmens = null,
            IReadOnlyCollection<string> employees = null,
            IReadOnlyCollection<string> phones = null);
        bool deletePhone(string name, string departmentId,
            IReadOnlyCollection<string> subDepartmens = null,
            IReadOnlyCollection<string> employees = null,
            IReadOnlyCollection<string> phones = null);
    }
}
