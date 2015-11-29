using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Entities
{
    public interface IDate
    {
        int Day
        { get; set; }

        int Month
        { get; set; }

        int Year
        { get; set; }
    }
}
