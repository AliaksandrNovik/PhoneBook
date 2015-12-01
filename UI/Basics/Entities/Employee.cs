using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Basics
{
    #region TODO place in commons
    public enum Gender
    {
        Male,
        Female
    }

    public class Date
    {
        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public int Day
        { get; }

        public int Month
        { get; }

        public int Year
        { get; }

        public override string ToString()
        {
            return string.Format("{0}.{1}.{2}", this.Day, this.Month, this.Year);
        }
    }
    #endregion

    public class Employee
    {
        public Employee (
            string firstName, string lastName, string patronym,
            Date birthDay, Gender gender,  string place
            )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Patronym = patronym;
            this.BirthDay = birthDay;
            this.Gender = gender;
            this.Place = place; 
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName + " " + this.Patronym;
        }

        public string FirstName
        { get; set; }

        public string LastName
        { get; set; }

        public string Patronym
        { get; set; }

        public Date BirthDay
        { get; set; }

        public Gender Gender
        { get; set; }

        public string Place
        { get; set; }
    }
}

