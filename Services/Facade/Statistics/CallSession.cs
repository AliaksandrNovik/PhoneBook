using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface CallSession
    {
        EntityId CallerPhone
        { get; }

        DateTime DateAndTime
        { get; }

        string TargetPhone
        { get; }

        int DurationInSeconds
        { get; }

        int PricePerMinute
        { get; }

        int TotalPrice
        { get; }
    }
}
