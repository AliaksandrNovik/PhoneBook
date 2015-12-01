using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;
using BLL;

namespace Services.Implementation
{
    class LoginService : ILoginService
    {
        public LoginService(IUserRepository adminRepository)

        public UserInfo Login(string user, string password)
        {
            throw new NotImplementedException();
        }

        Facade.UserInfo ILoginService.Login(string user, string password)
        {
            throw new NotImplementedException();
        }
    }
}
