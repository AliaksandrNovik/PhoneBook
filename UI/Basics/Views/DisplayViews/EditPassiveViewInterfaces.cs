using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.AppController;

namespace UI.Basics
{
    //TODO divide this stuff

    #region Employee Stuff
    public class EmployeeCreateArgs : EventArgs
    {
        EmployeeCreateArgs(Department department)
        { this.Department = department; }

        public Department Department
        { get; }
    }

    public delegate void EmployeeCreateDelegate(EmployeeCreateArgs createArgs);

    public class EmployeeUpdateArgs : EventArgs
    {
        EmployeeUpdateArgs(Employee employee)
        { this.Employee = employee; }

        public Employee Employee
        { get; }
    }

    public delegate void EmployeeUpdateDelegate(EmployeeUpdateArgs createArgs);

    public interface IEmployeePassiveEditView : IView
    {
        event EmployeeCreateDelegate EmployeeCreateCalled;

        event EmployeeUpdateDelegate EmployeeUpdateCalled;

        event EmployeeUpdateDelegate EmployeeDeleteCalled;
    }
    #endregion

    #region Department Stuff
    //Department
    public class DepartmentCreateArgs : EventArgs
    {
        DepartmentCreateArgs(Department parent)
        { this.Parent = parent; }

        public Department Parent
        { get; }
    }

    public delegate void DepartmentCreateDelegate(DepartmentCreateArgs createArgs);

    public class DepartmentUpdateArgs : EventArgs
    {
        DepartmentUpdateArgs(Department department)
        { this.Department = department; }

        public Department Department
        { get; }
    }

    public delegate void DepartmentUpdateDelegate(DepartmentUpdateArgs createArgs);

    public interface IDepartmentPassiveEditView : IView
    {
        event DepartmentCreateDelegate DepartmentCreateCalled;

        event DepartmentUpdateDelegate DepartmentUpdateCalled;

        event DepartmentUpdateDelegate DepartmentDeleteCalled;
    }
    #endregion

    #region Phone Stuff
    //Phone
    public class PhoneCreateArgs : EventArgs
    {
        PhoneCreateArgs(Department department, Employee employee)
        {
            this.Department = department;
            this.Employee = employee;
        }

        public Department Department
        { get; }

        public Employee Employee
        { get; }
    }

    public delegate void PhoneCreateDelegate(PhoneCreateArgs createArgs);

    public class PhoneUpdateArgs : EventArgs
    {
        PhoneUpdateArgs(Phone phone)
        { this.Phone = phone; }

        public Phone Phone
        { get; }
    }

    public delegate void PhoneUpdateDelegate(DepartmentUpdateArgs createArgs);

    public interface IPhonePassiveEditView : IView
    {
        event PhoneCreateDelegate PhoneCreateCalled;

        event PhoneUpdateDelegate PhoneUpdateCalled;

        event PhoneUpdateDelegate PhoneDeleteCalled;
    }
    #endregion
}
