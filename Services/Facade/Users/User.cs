using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface User
    {
        EntityId UserId
        { get; }

        string Login
        { get; set; }

        string Password
        { get; set; }
    }
}
