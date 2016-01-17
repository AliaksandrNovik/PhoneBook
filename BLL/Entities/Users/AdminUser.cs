using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Repositories
{
    public class AdminUser : Identified
    {
        [JsonConstructor]
        internal AdminUser(string id, string login, string password) :
            base(id)
        {
            this.Login = login;
            this.Password = password;
        }

        internal AdminUser(string login, string password) :
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
