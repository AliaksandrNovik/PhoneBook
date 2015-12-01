using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;

namespace Services.Implementation
{
    class UserInfo : IUserInfo
    {
        public UserInfo(Facade.String id, UserType userType)
        {
            this.Id = id;
            this.UserType = userType;
        }

        public String Id
        { get; private set; }

        public UserType UserType
        { get; private set; }
    }
}
