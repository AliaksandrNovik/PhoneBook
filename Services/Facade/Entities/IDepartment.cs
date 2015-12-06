using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface IDepartment
    {
        string Id
        { get; }

        string Name
        { get; set; }

        string ParentDepartmentId
        { get; set; }
    }
}
