using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Phone
    {
        public Phone(string phoneNumber)
        {            
            this.PhoneNumber = phoneNumber;
        }

        public Phone(string phoneNumber, Department department)
        {
            this.PhoneNumber = phoneNumber;
            this.Department = department;
        }

        public Phone(string phoneNumber, Employee employee)
        {
            if (employee.Department == null)
            {
                throw new ArgumentException("Employee without department");
            }
            else
            {
                this.PhoneNumber = phoneNumber;
                this.Owner = employee;
                this.Department = employee?.Department;
            }
        }

        public string PhoneNumber
        {
            get;
            set;
        }

        public Department Department
        {
            get;
            internal set;
        }

        public Employee Owner
        {
            get;
            internal set;
        }
    }
}
