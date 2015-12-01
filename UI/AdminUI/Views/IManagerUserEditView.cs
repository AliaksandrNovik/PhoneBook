using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Basics;

namespace UI.AdminUI
{
    public class DepartmentArgs : EventArgs
    {
        public DepartmentArgs(Department department)
        {
            this.Department = department;
        }

        Department Department
        { get; set; }
    }

    public delegate void DepartmentDelegate(DepartmentArgs departmentArgs);

    public interface IManagerUserEditView : IUserEditView
    {
        ManagerUser User
        { get; set; }

        IReadOnlyCollection<Department> AvailableDepartments
        { get; set; }

        IReadOnlyCollection<Employee> AvailableEmployees
        { get; set; }

        event DepartmentDelegate DepartmentSet;
    }
}
