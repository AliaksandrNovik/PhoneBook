using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BLL
{
    public class Date
    {
        public Date() : this(1, 1, 1970)
        { }

        [JsonConstructor]
        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public int Day
        { get; set; }

        public int Month
        { get; set; }

        public int Year
        { get; set; }

        public override string ToString()
        {
            return Day.ToString("D2") + "-" + Month.ToString("D2") + "-" + Year.ToString("D4");
        }
    }
}
