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

        EntityId HeadEmployeeId
        { get; set; }

        IReadOnlyCollection<EntityId> SubordinateDepartmentIds
        { get; set; }

        EntityId ParentDepartmentId
        { get; set; }
    }
}
