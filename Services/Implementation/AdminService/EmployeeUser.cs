using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;

namespace Services.Implementation
{
    public class EmployeeUser : IEmployeeUser
    {
        internal EmployeeUser(string login, string password, string employeeId, string userId)
        {
            this.Login = login;
            this.Password = password;
            this.EmployeeId = employeeId;
            this.UserId = userId;
        }

        public string EmployeeId
        { get; set; }

        public string Login
        { get; set; }

        public string Password
        { get; set; }
    
        public string UserId
        { get; set; }
    }
}
