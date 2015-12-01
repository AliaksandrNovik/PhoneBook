using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Basics;

namespace UI.ManagerUI
{
    public class PhoneWrap
    {
        public PhoneWrap(Phone phone)
        {
            this.Phone = phone;
        }

        public string PhoneNumber
        {
            get
            {
                return this.Phone?.Number;
            }
        }

        public string FullEmployeeName
        {
            get
            {
                return this.Phone?.Employee?.GetFullName();
            }
        }

        public string Birthday
        {
            get
            {
                return this.Phone?.Employee?.BirthDay?.ToString();
            }
        }

        public string Place
        {
            get
            {
                return this.Phone?.Employee?.Place;
            }
        }

        public string DepartmentName
        {
            get
            {
                return this.Phone?.Department?.Name;
            }
        }

        public Phone Phone
        { get; private set; }
    }
}
