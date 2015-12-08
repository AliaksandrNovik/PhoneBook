using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;

namespace UI.ManagerUI
{
    public class PhoneWrapItem
    {
        public PhoneWrapItem(IPhone phone, IEmployee employee = null)
        {
            if (phone == null)
                throw new ArgumentException("Phone is null!");
            this.PhoneItem = phone;
            this.EmployeeItem = employee;
        }

        public IPhone PhoneItem
        { get; set; }

        public IEmployee EmployeeItem
        { get; set; }

        public string Phone
        {
            get
            {
                return this.PhoneItem.Number;
            }
        }

        public string Name
        {
            get
            {
                if (this.EmployeeItem == null)
                {
                    return "Не задан";
                }
                else
                {
                    return this.EmployeeItem.LastName
                        + " " + this.EmployeeItem.FirstName
                        + " " + this.EmployeeItem.Patronym;
                }
            }
        }

        public string Place
        {
            get
            {
                if (this.EmployeeItem == null)
                {
                    return "-";
                }
                else
                {
                    return this.EmployeeItem.Place;
                }
            }
        }
    }
}
