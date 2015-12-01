using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Basics;

namespace UI.AdminUI
{
    #region create user
    public class CreationContextArgs : EventArgs
    {
        CreationContextArgs(Department department, Employee employee)
        {
            this.Department = department;
            this.Employee = employee;
        }

        public Department Department
        { get; set; }

        public Employee Employee
        { get; set; }
    }

    public delegate void CreationContextDelegate(CreationContextArgs contexArg);
    #endregion


    #region employee user stuff
    public class EmployeeUserArgs : EventArgs
    {
        EmployeeUserArgs(EmployeeUser user)
        { this.User = user; }

        public EmployeeUser User
        { get; }
    }

    public delegate void EmployeeUserDelegate(EmployeeUserArgs employeeArg);
    #endregion

    #region manager user stuff
    public class ManagerUserArgs : EventArgs
    {
        public ManagerUserArgs(ManagerUser user)
        {
            this.User = user;
        }

        public ManagerUser User
        { get; }
    }

    public delegate void ManagerUserDelegate(ManagerUserArgs managerArgs);
    #endregion

    #region admin user stuff
    public class AdminUserArgs : EventArgs
    {
        public AdminUserArgs(UserInfo user)
        {
            this.User = user;
        }
        public UserInfo User
        { get; set; }
    }
    public delegate void AdminUserDelegate(AdminUserArgs adminArgs);
    #endregion

    public interface IAdminPassiveView : IDepartmentPassiveEditView, IEmployeePassiveEditView
    {
        event CreationContextDelegate EmployeeUserCreateCalled;
        event EmployeeUserDelegate EmployeeUserUpdateCalled;
        event EmployeeUserDelegate EmployeeUserDeleteCalled;

        event CreationContextDelegate ManagerUserCreateCalled;
        event ManagerUserDelegate ManagerUserUpdateCalled;
        event ManagerUserDelegate ManagerUserDeleteCalled;

        event EventHandler AdminCreateCalled;
        event AdminUserDelegate AdminUpdateCalled;
        event AdminUserDelegate AdminDeleteCalled;
    }
}
