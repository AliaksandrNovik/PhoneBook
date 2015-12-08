using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;

namespace Services.Implementation
{
    public class CallSession : ICallSession
    {
        public CallSession(BLL.Entities.PhoneStatistic phoneStat):
            this(phoneStat.Id, phoneStat.PhoneId, phoneStat.TargetPhone, phoneStat.DateAndTime,
                phoneStat.DurationSecs, phoneStat.PriceForMinute)
        { }

        public CallSession(string id, string phoneId, string targetPhone, DateTime dateTime,
            int durationSeconds, int pricePerMinute)
        {
            this.Id = id;
            this.PhoneId = phoneId;
            this.TargetPhone = targetPhone;
            this.DateAndTime = dateTime;
            this.DurationInSeconds = durationSeconds;
            this.PricePerMinute = pricePerMinute;
            this.TotalPrice = (int)(Math.Ceiling(durationSeconds / 60.0) * pricePerMinute);
        }

        public string Id
        { get; private set; }

        public string PhoneId
        { get; private set; }

        public string TargetPhone
        { get; private set; }

        public DateTime DateAndTime
        { get; private set; }

        public int DurationInSeconds
        { get; private set; }        

        public int PricePerMinute
        { get; private set; }        

        public int TotalPrice
        { get; private set; }
    }
}
