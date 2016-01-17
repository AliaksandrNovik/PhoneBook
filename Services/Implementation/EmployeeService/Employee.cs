using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Services.Facade;

namespace Services.Implementation
{
    public class Employee : IEmployee
    {
        public Employee(
            string id, 
            string firstName, string lastName, string partonym,
            string place, Date birthDay, string departmentId
            )
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Patronym = Patronym;
            this.Place = place;
            this.BirthDate = birthDay;
            this.DepartmentId = departmentId;
        }

        public Employee(Repositories.Employee repEmployee)
        {
            this.Id = repEmployee.Id;
            this.FirstName = repEmployee.FirstName;
            this.LastName = repEmployee.LastName;
            this.Patronym = repEmployee.Patronym;
            this.Place = repEmployee.Place;
            this.BirthDate = repEmployee.BirthDate;
            this.DepartmentId = repEmployee.DepartmentId;
        }         

        public string Id
        { get; private set; }

        public string FirstName
        { get; set; }

        public string LastName
        { get; set; }

        public string Patronym
        { get; set; }

        public string Place
        { get; set; }

        public Date BirthDate
        { get; set; }

        public string DepartmentId
        { get; set; }        
    }
}
