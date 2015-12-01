using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface UserInfo
    {
        EntityId UserId
        { get; set; }

        UserType Type
        { get; set; }
    }
}
