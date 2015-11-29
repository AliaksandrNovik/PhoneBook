using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface Employee
    {
        string Id
        { get; }

        //own stuff
        //
        string FirstName
        { get; set; }

        string LastName
        { get; set; }

        string Patronym
        { get; set; }

        Date BirthDate
        { get; set; }

        Gender Gender
        { get; set; }

        string Place
        { get; set; }

        //refs
        EntityId DepartmentId
        { get; set; }
    }
}
