using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;
using Repositories.Repository;
using Faker;

namespace Services.Implementation
{
    public class StatisticService : IStatisticService
    {
        private IPhoneStatisticRepository _repository = new PhoneStatisticsRepository();
        public void DeleteByPhoneId(string phoneId)
        {
            foreach (var repStat in _repository.GetByPhoneId(phoneId))
            {
                _repository.Delete(repStat.Id);
            }
        }

        public IReadOnlyCollection<ICallSession> GetByPhoneId(string phoneId)
        {
            var list = ReadByPhoneId(phoneId);
            if (list.Count == 0)
            {
                return GeneratePhoneStat(phoneId);
            }
            else
            {
                return list;
            }
        }

        private List<ICallSession> ReadByPhoneId(string phoneId)
        {
            List<ICallSession> callSessionList = new List<ICallSession>();
            foreach (var repStat in _repository.GetByPhoneId(phoneId))
            {
                callSessionList.Add(new CallSession(repStat));
            }
            return callSessionList;
        }

        private List<ICallSession> GeneratePhoneStat(string phoneId)
        {
            Random rand = new Random();
            int sessionCount = rand.Next(5, 15);
            for (int i = 0; i < sessionCount; ++i)
            {
                var targetPhone = Faker.PhoneFaker.InternationalPhone();
                var dateTime = Faker.DateTimeFaker.DateTimeBetweenMonths(1, 8);
                var duration = rand.Next(5, 300);
                var price = rand.Next(30, 50);
                _repository.Create(phoneId, targetPhone, dateTime, duration, price);
            }

            return ReadByPhoneId(phoneId);
        }
    }
}
