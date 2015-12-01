using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Basics;

namespace UI.AdminUI
{
    public class UserInfo
    {
        UserInfo (string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }

        public string Login
        { get; set; }

        public string Password
        { get; set; }
    }
}
