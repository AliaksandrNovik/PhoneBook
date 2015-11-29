using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Entities
{
    public interface Employee
    {
        string EmployeeID
        { get; }

        string FirstName
        { get; set; }

        string LastName
        { get; set; }

        string Patronym
        { get; set; }

        IDate BirthDate
        { get; set; }

        Gender Gender
        { get; set; }
    }
}
