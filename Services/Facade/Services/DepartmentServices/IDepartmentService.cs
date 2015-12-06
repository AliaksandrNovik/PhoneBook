using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface IDepartmentService : IReadOnlyDepartmentService
    {
        IDepartment Create(string name, string parentDepartmentId);
        bool Update(IDepartment department);
        bool Delete(IDepartment department);        
    }
}
