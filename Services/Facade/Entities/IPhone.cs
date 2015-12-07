using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface IPhone
    {
        string Id
        { get; }

        string Number
        { get; set; }

        string DepartmentId
        { get; set; }

        string EmployeeId
        { get; set; }
    }
}
