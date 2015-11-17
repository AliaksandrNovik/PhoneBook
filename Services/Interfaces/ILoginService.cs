using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public enum UserType { Admin, Manager, Employee };
    public interface ILoginService
    {
        UserType GetUserType(string userName, string password);
    }


    public class DummyLogin : ILoginService
    {
        UserType ILoginService.GetUserType(string userName, string password)
        {
            if (userName.StartsWith("admin"))
            {
                return UserType.Admin;
            }
            else if (userName.StartsWith("manager"))
            {
                return UserType.Manager;
            }
            else
            {
                return UserType.Employee;
            }
        }
    }
}
