using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;

namespace Services.Implementation
{
    class ManagerUser : IManagerUser
    {
        internal ManagerUser(string login, string password, string employeeId, string departmentId, string userId)
        {
            this.Login = login;
            this.Password = password;
            this.EmployeeId = employeeId;
            this.DepartmentId = departmentId;
            this.UserId = userId;
        }
        public string DepartmentId
        { get; set; }

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
