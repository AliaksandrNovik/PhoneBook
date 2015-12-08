using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;

namespace BLL.Repository
{
    public interface IPhoneStatisticRepository
    {
        PhoneStatistic Create(string phoneId, string targetPhone, DateTime dateTime, 
            int durationSecs, int pricePerMinute);

        IReadOnlyCollection<PhoneStatistic> GetAll();
        IReadOnlyCollection<PhoneStatistic> GetByPhoneId(string phoneId);
        PhoneStatistic GetById(string id);
        bool Update(PhoneStatistic phoneStatistics);
        bool Delete(string id);
    }
}
