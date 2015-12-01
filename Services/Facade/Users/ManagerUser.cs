using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface ManagerUser : User
    {
        String Department
        { get; set; }
    }
}
