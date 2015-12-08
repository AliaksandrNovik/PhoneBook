using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;

namespace BLL.Repository
{
    public class PhoneStatisticsRepository : IPhoneStatisticRepository
    {
        private FileRepository<PhoneStatistic> _fileRepository = FileRepository<PhoneStatistic>.GetInstance("PhoneStat.txt");
        public PhoneStatistic Create(string phoneId, string targetPhone, DateTime dateTime, int durationSecs, int pricePerMinute)
        {
            var phoneStat = new PhoneStatistic(phoneId, targetPhone, dateTime, durationSecs, pricePerMinute);
            _fileRepository.Upsert(phoneStat);
            return phoneStat;
        }

        public bool Delete(string id)
        {
            return _fileRepository.Delete(id);
        }

        public IReadOnlyCollection<PhoneStatistic> GetAll()
        {
            return _fileRepository.GetAll();
        }

        public IReadOnlyCollection<PhoneStatistic> GetByPhoneId(string phoneId)
        {
            return _fileRepository.GetAll().Where(x => x.PhoneId == phoneId).ToList();
        }

        public PhoneStatistic GetById(string id)
        {
            return _fileRepository.GetById(id);
        }

        public bool Update(PhoneStatistic phoneStatistics)
        {
            bool canUpdate = (_fileRepository.GetById(phoneStatistics.Id) != null);
            if (canUpdate)
            {
                _fileRepository.Upsert(phoneStatistics);
            }
            return canUpdate;
        }
    }
}
