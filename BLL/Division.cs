using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Division
    {
        Employee _manager;
        public Employee Manager
        {
            get
            {
                return _manager;
            }
            set
            {
                _manager = value;
            }
        }

        //phone
        //
        /*private ISet<Phone> _phones = new <Phone>();
        public IReadOnlyList<Phone> Phones
        {
            get
            {
                return new List<Phone>(_phones);
            }
        }*/

        public void AddPhone(Phone phone)
        {
            _phones.Add(phone);
        }

        public void RemovePhone(Phone phone)
        {
            _phones.Remove(phone);
        }


        //employees
        private Imm<Employee> _employees = new SortedSet<Employee>();
        public IReadOnlyCollection<Employee> Employees
        {
            get
            {
                return new ReadOnlyCollection<Employee>(_employees.ToList());
            }
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Contains(employee);
        }

    }
}
