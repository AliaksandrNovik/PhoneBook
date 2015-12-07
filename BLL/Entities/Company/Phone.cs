using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BLL
{
    public class Phone : Identified
    {
        [JsonConstructor]
        internal Phone(string id, string phoneNumber, string departmentId, string employeeId):
            base(id)
        {
            this.PhoneNumber = phoneNumber;
            this.DepartmentId = departmentId;
            this.EmployeeId = employeeId;
        }

        internal Phone(string phoneNumber, string departmentId, string employeeId)
        {            
            this.PhoneNumber = phoneNumber;
            this.DepartmentId = departmentId;
            this.EmployeeId = employeeId;
        }        

        public string PhoneNumber
        { get; set; }

        public string DepartmentId
        { get; set; }

        public string EmployeeId
        { get; set; }
    }
}
