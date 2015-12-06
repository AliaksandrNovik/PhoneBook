using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;

namespace Services.Implementation
{
    class AdminUser : IAdminUser
    {
        internal AdminUser(string login, string password, string userId)
        {
            this.Login = login;
            this.Password = password;
            this.UserId = userId;
        }

        public string Login
        { get; set; }

        public string Password
        { get; set; }
        
        public string UserId
        { get; set; }
        
    }
}
