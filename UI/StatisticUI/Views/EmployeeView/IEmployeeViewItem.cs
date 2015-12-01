using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Views
{
    public enum GenderEnum
    {
        Male,
        Female
    }

    public interface IEmployeeViewItem
    {
        string DepartmentName
        { get; set; }

        string PhoneNumber
        { get;}

        string EmployeeFullName
        { get; }
        string FirstEmployeeName
        { get; set; }

        string SecondEmployeeName
        { get; set; }

        string EmployeePatronym
        { get; set; }

        string BirthDay//need parse?
        { get; set; }

        //GenderEnum Gender
        //{ get; set; }

        string Position
        { get; set; }
    }
}
