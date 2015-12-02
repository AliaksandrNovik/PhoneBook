using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Phone
    {
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
