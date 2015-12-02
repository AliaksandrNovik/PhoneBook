using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [Serializable]
    public class EmployeeUser : Identified
    {
        EmployeeUser():base() { }
        EmployeeUser(string login, string password, string employeeId) :
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
