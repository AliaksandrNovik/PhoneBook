using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.EmployeeService
{
    public class NameFields
    {
        public string FirstName
        { get; set; }

        public string SecondName
        { get; set; }

        public string Patronym
        { get; set; }
    }

    public class Date
    {
        //TODO    
    }

    public enum Gender
    {
        Male,
        Female
    }

    public class EmployeeID
    {
    
    }

    public interface IEmployee
    {
        EmployeeID ID
        { get; }

        Date BirthDate
        { get; set; }

        Gender Gender
        { get; set; }

        NameFields Name
        { get; set; }

        string Place
        { get; set; }
    }
}
