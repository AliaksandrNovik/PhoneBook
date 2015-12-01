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

        EntityId Department
        { get; set; }

        EntityId Employee
        { get; set; }
    }
}
