using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UI.AppController;
using UI.CompanyStructure.Entities;

namespace UI.CompanyStructure.Views
{    
    public delegate void PassEmployee(Employee employee);
    public delegate void PassPhone(Phone phone);
    public delegate void PassDepartment(Department department);

    public interface IManagerView : IPassiveCompanyStructView
    {
        event EventHandler EpmloyeeCreateCalled;
        event PassEmployee EmployeeUpdateCalled;
        event PassEmployee EmployeeDeleteCalled;

        event EventHandler PhoneCreateCalled;
        event PassPhone PhoneUpdateCalled;
        event PassPhone PhoneDeleteCalled;

        event PassDepartment CreateSubDepartment;//pass parent
        event PassDepartment UpdateDepartment;//pass item to update
        event PassDepartment DeleteDepartment;//pass item to remove
    }
}
