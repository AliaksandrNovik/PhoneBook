using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.AppController;

namespace UI.Views
{
    public class StatisticItem
    {
        public StatisticItem(
            DateTime dateTime, int durationSecs, 
            string phone, int pricePerMinute, int totalPrice
            )
        {
            this.DateAndTime = dateTime;
            this.DurationInSeconds = durationSecs;
            this.Phone = phone;
            this.PricePerMinute = pricePerMinute;
            this.TotalPrice = totalPrice;
        }

        public DateTime DateAndTime
        { get; private set; }

        public int DurationInSeconds
        { get; private set; }

        public string Phone
        { get; private set; }

        public int PricePerMinute
        { get; private set; } 
        
        public int TotalPrice
        { get; private set; }               
    }

    public interface IPhoneStatisticView : IView
    {
        string Phone
        { set; }

        string Department
        { set; }

        string Employee
        { set; }

        IReadOnlyCollection<StatisticItem> PhoneCalls
        { set; }
    }
}
