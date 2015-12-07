using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;

namespace UI.EmployeeUI
{
    public class PhoneWrapItem
    {
        private readonly IDepartment _department;
        private readonly IEmployee _employee;
        private readonly IPhone _phone;        


        public PhoneWrapItem(IDepartment department, IEmployee employee, IPhone phone)
        {
            _department = department;
            _employee = employee;
            _phone = phone;
        }

        public string Phone
        {
            get
            {
                return _phone.Number;
            }
        }

        public string FullName
        {
            get
            {
                if (_employee == null)
                    return null;
                else
                    return _employee.FirstName + " " + _employee.LastName + " " + _employee.Patronym;
            }
        }

        public string BirthDate
        {
            get
            {
                return _employee?.BirthDate.ToString();
            }
        }

        public string Place
        {
            get
            {
                return _employee?.Place;
                
            }
        }

        public string Department
        {
            get
            {
                return _department?.Name;
            }
        }
    }
}
