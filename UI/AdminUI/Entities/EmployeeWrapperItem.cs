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
        public EmployeeWrapperItem()
        {
        }

        public EmployeeWrapperItem(string firstName, string lastName, string patronym,
            string birthDate, string place)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Patronym = patronym;
            this.BirthDate = birthDate;
            this.Place = place;
        }

        internal string FirstName
        { get; set; }

        internal string LastName
        { get; set; }

        internal string Patronym
        { get; set; }

        public Employee Employee
        { get; set; }

        public string Name
        {
            get
            {
                return FirstName + " " + LastName + " " + Patronym;
            }
        }

        public string Place
        { get; set; }

        public string BirthDate
        { get; set; }
    }
}
