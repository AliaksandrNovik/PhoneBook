using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [Serializable]
    public class Date
    {
        public Date() : this(1, 1, 1970)
        {}

        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public int Day
        { get; set; }

        public int Month
        { get; set; }

        public int Year
        { get; set; }
    }


    public class Employee : Identified
    {
        internal Employee (string firstName, string lastName, string patronym,
            Date birthDate, string place, string departmentId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Patronym = patronym;
            this.BirthDate = birthDate;
            this.Place = place;
            this.DepartmentId = departmentId;
        }

        public string FirstName
        { get; set; }

        public string LastName
        { get; set; }

        public string Patronym
        { get; set; }

        public Date BirthDate
        { get; set; }

        public string Place
        { get; set; }

        public string DepartmentId
        { get; set; }
    }
}
