using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Employee
    {
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        private string _patronym;
        public string Patronym
        {
            get
            {
                return _patronym;
            }
            set
            {
                _patronym = value;
            }
        }


        private Division _division;
        public Division WorkingDivision
        {
            get
            {
                return _division;
            }
            set
            {
                
                _division = value;
            }
        }

        //Phone methods
        private IList<Phone> _phones = new List<Phone>();
        public IReadOnlyCollection<Phone> Phones
        {
            get
            {
                return new ReadOnlyCollection<Phone>(_phones);
            }
        }

        void AddPhone(Phone phone)
        {
            _phones.Add(phone);
        }

        void RemovePhone(Phone phone)
        {
            _phones.Remove(phone);
        }
    }
}
