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
        public EmployeeWrapperItem(IEmployee item, IUserInfo userInfo = null)
        {
            if (item == null)
            {
                throw new ArgumentException("Item is null");
            }
            this.Item = item;
            this.UserInfo = userInfo;
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

        public IUserInfo UserInfo
        { get; set; }            
        

        public string UserTypeName
        {
            get
            {
                if (this.UserInfo == null)
                {
                    return "Не назначены";
                }
                else
                {
                    var userType = this.UserInfo.Type;
                    switch (userType)
                    {
                        case UserType.Employee:
                            return "Сотрудник";
                        case UserType.Manager:
                            return "Менеджер";
                        default:
                            return "Колиззия";
                    }
                }
            }
        }
    }
}
