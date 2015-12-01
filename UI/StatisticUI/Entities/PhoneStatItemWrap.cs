using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Views;

namespace UI.Forms
{
    //TODO remove
    public class PhoneStatItemWrap
    {
        private StatisticItem _item;
        public PhoneStatItemWrap(StatisticItem item)
        {
            _item = item;
        }

        public string DateAndTime
        {
            get
            {
                return _item.DateAndTime.ToString();
            }
        }

        public int DurationInSecs
        {
            get
            {
                return _item.DurationInSeconds;
            }
        }


        public string Phone
        {
            get
            {
                return _item.Phone;
            }
        }

        public int PricePerMinute
        {
            get
            {
                return _item.PricePerMinute;
            }
        }

        public int TotalPrice
        {
            get
            {
                return _item.TotalPrice;
            }
        }
    }
}
