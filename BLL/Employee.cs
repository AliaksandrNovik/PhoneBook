using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Employee
    {
        //personal info
        //
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Patronym
        {
            get
            {
                return patronym;
            }
            set
            {
                patronym = value;
            }
        }

        //unit
        public Division WorkingDivision
        {
            get
            {
                return division;
            }
            set
            {
                division = value;
            }
        }


        //phone methods TODO
        void AddPhone(Phone phone)
        {}

        void RemovePhone(Phone phone)
        {}
        //todo add phone accesor method


        private string firstName;
        private string lastName;
        private string patronym;
        private Division division;
        private List<Phone> phonesList;
    }
}
