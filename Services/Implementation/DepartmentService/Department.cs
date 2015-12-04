using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;

namespace Services.Implementation
{
    public class Department : IDepartment
    {
        public Department(string id, string name, string parentDepartmentId)
        {
            this.Id = id;
            this.Name = name;
            this.ParentDepartmentId = parentDepartmentId;
        }

        public string Id
        { get; private set; }

        public string Name
        { get; set; }

        public string ParentDepartmentId
        { get; set; }  
    }
}
