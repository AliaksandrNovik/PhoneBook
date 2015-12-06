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
        internal UserInfo(UserType type, string userId)
        {
            this.Type = type;
            this.UserId = userId;
        }
        public UserType Type
        {
            get;
            set;
        }

        public string UserId
        {
            get;
            set;
        }
    }
}
