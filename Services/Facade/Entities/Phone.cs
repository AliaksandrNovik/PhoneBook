using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface Phone
    {
        string Id
        { get; }

        string Number
        { get; set; }

        String Department
        { get; set; }

        String Employee
        { get; set; }
    }
}
