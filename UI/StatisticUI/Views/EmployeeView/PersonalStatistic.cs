using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Views.EmployeeView
{
    public class StatisticItem
    {
        public string DateAndTime
        { get; set; }

        public int DurationInSecs
        { get; set; }

        public string PhoneNumber
        { get; set; }

        public int PricePerMinute
        { get; set; }

        public int TotalPrice
        { get; set; }
    }
    public interface PersonalStatistic
    {
        IReadOnlyCollection<StatisticItem>
    }
}
