using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BLL
{
    public class EmployeeUser : Identified
    {
        [JsonConstructor]
        internal EmployeeUser(string id, string login, string password, string employeeId):
            base(id)
        {
            this.Login = login;
            this.Password = password;
            this.EmployeeId = employeeId;
        }

        internal EmployeeUser(string login, string password, string employeeId) :
            base()
        {
            this.Login = login;
            this.Password = password;
            this.EmployeeId = employeeId;
        }

        public string Login
        { get; set; }

        public string Password
        { get; set; }

        public string EmployeeId
        { get; set; }
    }
}
