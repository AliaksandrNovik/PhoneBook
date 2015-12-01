using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface IPhoneService : IReadOnlyPhoneService
    {
        void CreatePhone(string number, String department = null, String employee = null);
        void UpdatePhone(Phone phone);
        void DeletePhone(String phoneId);
    }
}
