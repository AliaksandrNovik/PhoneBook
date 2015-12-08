using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface IPhoneService : IReadOnlyPhoneService
    {
        IPhone CreatePhone(string number, string department = null, string employee = null);
        bool UpdatePhone(IPhone phone);
        bool DeletePhone(string phoneId);
    }
}
