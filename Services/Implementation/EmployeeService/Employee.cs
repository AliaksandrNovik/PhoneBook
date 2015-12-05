using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
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

        public Employee(BLL.Employee bllEmployee)
        {
            this.Id = bllEmployee.Id;
            this.FirstName = bllEmployee.FirstName;
            this.LastName = bllEmployee.LastName;
            this.Patronym = bllEmployee.Patronym;
            this.Place = bllEmployee.Place;
            this.BirthDate = bllEmployee.BirthDate;
            this.DepartmentId = bllEmployee.DepartmentId;
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
