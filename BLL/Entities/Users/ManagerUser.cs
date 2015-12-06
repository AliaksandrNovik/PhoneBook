using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BLL
{
    public class ManagerUser : Identified
    {
        [JsonConstructor]
        internal ManagerUser(string id, string login, string password, string employeeId, string departmentId):
            base(id)
        {
            this.Login = login;
            this.Password = password;
            this.EmployeeId = employeeId;
            this.DepartmentId = departmentId;
        }

        internal ManagerUser(string login, string password, string employeeId, string departmentId) :
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
