using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Entities
{
    public interface Phone
    {
        string PhoneID
        { get; }

        string Number
        { get; set; }

        Department Department
        { get; set; }

        Employee Employee
        { get; set; }
    }
}
