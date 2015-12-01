using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManagerUser
    {
        ManagerUser(string login, string password, string employeeId, string departmentId) :
            base()
        {
            this.Login = login;
            this.Password = password;
            this.EmployeeId = employeeId;
            this.DepartmentId = departmentId;
        }

        public string Login
        { get; set; }

        public string Password
        { get; set; }

        public string EmployeeId
        { get; set; }

        public string DepartmentId
        { get; set; }
    }
}
