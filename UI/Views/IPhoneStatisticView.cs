using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.AppController;

namespace UI.Views
{
    class Name
    {
        public Name (string firstName, string secondName, string patronym)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Patronym = patronym;
        }
            
        public string FirstName
        { get; set; }

        public string SecondName
        { get; set; }

        public string Patronym
        { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", FirstName, SecondName, Patronym);
        }

    }
    public class StatisticItem
    {
        public DateTime DateAndTime
        { get; set; }

        public int DurationInSeconds
        { get; set; }

        public string Phone
        { get; set; }

        public int PricePerMinute
        { get; set; } 
        
        public int SummaryPrice
        { get; set; }               
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
