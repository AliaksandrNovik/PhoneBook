using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade.Services.UserServices
{
    public interface IManagerInfoService
    {
        EntityId GetDepartment(IUserInfo userInfo);
    }
}
