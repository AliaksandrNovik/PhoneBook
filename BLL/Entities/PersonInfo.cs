using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Date
    { }

    public enum Gender
    {
        Male,
        Female
    }

    public class PersonInfo
    {
        public string FirstName
        { get; set; }

        public string LastName
        { get; set; }

        public string Patronym
        { get; set; }

        public Date BirthDate
        { get; set; }

        public Gender Gender
        { get; set; }
    }
}
