using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services.Interfaces
{
    public class DummyLogin : ILoginService
    {
        UserType ILoginService.GetUserType(string userName, string password)
        {
            return UserType.Admin;
        }
    }
}
