using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Department
    {
        public Department(string name, Employee manager = null)
        {
            this.Name = name;
            this.Manager = null;
        }

        public string Name
        {
            get;set;
        }

        //manager methods
        //
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
                _employees.Remove(_manager);
                _manager.Department = this;
            }
        }

        //phones methods
        //
        private ISet<Phone> _phones = new HashSet<Phone>();
        public IReadOnlyCollection<Phone> Phones
        {
            get
            {
                return _phones.ToList();
            }
        }

        public void AddPhone(Phone phone)
        {
            //TODO check codes
            phone.Department = this;
            _phones.Add(phone);
        }

        public void RemovePhone(Phone phone)
        {
            phone.Department = null;
            phone.Owner = null;
            _phones.Remove(phone);
        }


        //employee methods
        //
        private ISet<Employee> _employees = new HashSet<Employee>();
        public IReadOnlyCollection<Employee> Employees
        {
            get
            {
                return _employees.ToList();
            }
        }

        public void AddEmployee(Employee employee)
        {
            employee.Department = this;
            _employees.Add(employee);
        }

        private void RemoveEmployee(Employee employee)
        {
            employee.Department = null;
            _employees.Remove(employee);
        }
    }
}
