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
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Patronym
        {
            get;
            set;
        }

        private Department _department;
        public Department Department
        {
            get
            {
                return _department;
            }
            internal set
            {
                _department = value;
                foreach (var phone in _phones)
                {
                    phone.Department = _department;
                }
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
            phone.Owner = this;
            phone.Department = this.Department;
            _phones.Add(phone);
        }

        void RemovePhone(Phone phone)
        {
            phone.Owner = null;
            _phones.Remove(phone);
        }
    }
}
