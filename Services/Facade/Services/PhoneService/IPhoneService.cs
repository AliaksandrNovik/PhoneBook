using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface IPhoneService : IReadOnlyPhoneService
    {
        void CreatePhone(string number, EntityId department = null, EntityId employee = null);
        void UpdatePhone(Phone phone);
        void DeletePhone(EntityId phoneId);
    }
}
