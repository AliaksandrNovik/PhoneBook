using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [Serializable]
    public class AdminUser : Identified
    {
        AdminUser() : base() {}

        AdminUser(string login, string password) :
            base()
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
