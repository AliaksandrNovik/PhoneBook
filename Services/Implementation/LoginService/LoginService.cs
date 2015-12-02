using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;
using BLL;

namespace Services.Implementation
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;
        public LoginService()
        {
        }

        public IUserInfo Login(string user, string password)
        {
            if (user.Equals("admin"))
            {
                return new UserInfo(UserType.Admin, "123");
            }
            else
            {
                return null;
            }

            foreach (var userItem in _userRepository.GetAdminAll())
            {
                if (userItem.Login.Equals(user) && userItem.Password.Equals(password))
                {
                    return new UserInfo(UserType.Admin, userItem.Id);
                }
            }

            foreach (var userItem in _userRepository.GetEmployeeAll())
            {
                if (userItem.Login.Equals(user) && userItem.Password.Equals(password))
                {
                    return new UserInfo(UserType.Employee, userItem.Id);
                }
            }

            foreach (var userItem in _userRepository.GetManagerAll())
            {
                if (userItem.Login.Equals(user) && userItem.Password.Equals(password))
                {
                    return new UserInfo(UserType.Manager, userItem.Id);
                }
            }

            return null;
        }
    }
}
