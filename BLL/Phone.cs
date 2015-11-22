using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Phone
    {
        public string PhoneNumber
        {
            get;
            set;
        }

        public Division CompanyDivision { get; set; }        

        public Employee Owner { get; set; }
    }
}
