using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;

namespace Services.Implementation
{
    public class Phone : IPhone
    {
        public Phone(string number, string employeeId, string departmentId, string id)
        {
            this.Number = number;
            this.EmployeeId = employeeId;
            this.DepartmentId = departmentId;
            this.Id = id;
        }

        public string DepartmentId
        { get; set; }

        public string EmployeeId
        { get; set; }

        public string Id
        { get; set; }

        public string Number
        { get; set; }
    }
}
