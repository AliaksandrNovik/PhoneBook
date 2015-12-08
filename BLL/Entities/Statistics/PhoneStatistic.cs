using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BLL.Entities
{
    public class PhoneStatistic : Identified
    {
        internal PhoneStatistic(string phoneId, string targetPhone, DateTime dateTime, 
            int durationSecs, int pricePerMinute): base()
        {
            this.PhoneId = phoneId;
            this.TargetPhone = targetPhone;
            this.DateAndTime = dateTime;
            this.DurationSecs = durationSecs;
            this.PriceForMinute = pricePerMinute;
        }
        [JsonConstructor]
        internal PhoneStatistic(string id,
            string phoneId, string targetPhone, DateTime dateTime,
            int durationSecs, int pricePerMinute) : base(id)
        {
            this.PhoneId = phoneId;
            this.TargetPhone = targetPhone;
            this.DateAndTime = dateTime;
            this.DurationSecs = durationSecs;
            this.PriceForMinute = pricePerMinute;
        }

        public string PhoneId
        { get; set; }

        public string TargetPhone
        { get; set; }

        public DateTime DateAndTime
        { get; set; }

        public int DurationSecs
        { get; set; }

        public int PriceForMinute
        { get; set; }
    }
}
