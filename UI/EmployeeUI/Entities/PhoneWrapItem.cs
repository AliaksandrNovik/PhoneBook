using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Basics;

namespace UI.EmployeeUI
{
    public class PhoneWrapItem
    {
        private readonly Phone _phone;
        public PhoneWrapItem(Phone phone)
        {
            _phone = phone;
        }

        public string Phone
        {
            get
            {
                return _phone?.Number;
            }
        }

        public string Name
        {
            get
            {
                return FullName(_phone?.Employee);
            }
        }
        private string FullName(Employee employee)
        {
            return employee?.FirstName + " " + employee?.LastName + " " + employee?.Patronym;
        }

        public string BirthDate
        {
            get
            {
                return _phone?.Employee?.BirthDay?.ToString();
            }
        }

        public string Place
        {
            get
            {
                return _phone?.Employee?.Place;
            }
        }

        public string Department
        {
            get
            {
                return _phone?.Department?.Name;
            }
        }

        public bool ContainsValue(string value)
        {
            return CheckField(this.Phone, value)
                || CheckField(this.Name, value)
                || CheckField(this.BirthDate, value)
                || CheckField(this.Department, value)
                || CheckField(this.Place, value);
        }

        public bool CheckField(string field, string value)
        {
            if (field == null || value == null)
            {
                return false;
            }
            else
            {
                return field.Contains(value);
            }
        }

    }
}