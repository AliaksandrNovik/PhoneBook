using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public interface IStatisticService
    {
        IReadOnlyCollection<ICallSession> GetByPhoneId(string phoneId);
        void DeleteByPhoneId(string phoneId);
    }
}
