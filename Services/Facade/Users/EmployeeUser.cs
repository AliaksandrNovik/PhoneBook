using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface EmployeeUser : User
    {
        EntityId Employee
        { get; set; }
    }
}
