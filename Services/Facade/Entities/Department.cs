using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface Department
    {
        string Id
        { get; }

        string Name
        { get; set; }

        String HeadEmployeeId
        { get; set; }

        IReadOnlyCollection<String> SubordinateDepartmentIds
        { get; set; }

        String ParentDepartmentId
        { get; set; }
    }
}
