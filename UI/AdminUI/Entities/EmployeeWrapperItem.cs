using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;

namespace UI.AdminUI
{
    public class EmployeeWrapperItem
    {
        public EmployeeWrapperItem(IEmployee item)
        {
            this.Item = item;
            if (item == null)
            {
                throw new ArgumentException("Item is null");
            }
        }

        public IEmployee Item
        {
            get; set;
        }

        public string Name
        {
            get
            {
                return this.Item.FirstName + " " + this.Item.LastName + " " + this.Item.Patronym;
            }
        }

        public string Place
        {
            get
            {
                return this.Item.Place;
            }
        }

        public string BirthDate
        {
            get
            {
                return this.Item.BirthDate.ToString();
            }
        }
    }
}
