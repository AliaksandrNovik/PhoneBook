using Newtonsoft.Json;

namespace Repositories
{
    public class Employee : Identified
    {
        [JsonConstructor]
        internal Employee (
            string id,
            string firstName, string lastName, string patronym,
            Date birthDate, string place, string departmentId):
                base(id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Patronym = patronym;
            this.BirthDate = birthDate;
            this.Place = place;
            this.DepartmentId = departmentId;
        }

        internal Employee (string firstName, string lastName, string patronym,
            Date birthDate, string place, string departmentId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Patronym = patronym;
            this.BirthDate = birthDate;
            this.Place = place;
            this.DepartmentId = departmentId;
        }

        public string FirstName
        { get; set; }

        public string LastName
        { get; set; }

        public string Patronym
        { get; set; }

        public Date BirthDate
        { get; set; }

        public string Place
        { get; set; }

        public string DepartmentId
        { get; set; }
    }
}
