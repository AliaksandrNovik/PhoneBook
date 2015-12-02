using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public delegate void PassEmployeeUser(IEmployeeUser user);
    public delegate void PassEmployeeUserId(string user);

    public delegate void PassManagerUser(IManagerUser user);
    public delegate void PassManagerUserId(string user);

    public delegate void PassAdminUser(IAdminUser user);
    public delegate void PassAdminUserId(string user);

    public interface IAdminService
    {
        IEmployeeUser CreateEmployeeUser(string login, string password, string employeeId);
        bool UdpateEmployeeUser(IEmployeeUser employeeUser);
        bool DeleteEmployeeUser(string userId);
        //event PassEmployeeUser EmployeeUserCreated;
        //event PassEmployeeUser EmployeeUserUpdated;
        //event PassEmployeeUserId EmployeeUserDeleted;

        IManagerUser CreateManagerUser(string login, string password, string employeeId, string departmentId);
        bool UpdateManagerUser(IManagerUser managerUser);
        bool DeleteManagerUser(string userId);
        //event PassManagerUser ManagerUserCreated;
        //event PassManagerUser ManagerUserUpdated;
        //event PassManagerUserId ManagerUserDeleted;

        IAdminUser CreateAdminUser(string login, string password);
        bool UpdateAdminUser(IAdminUser user);
        bool DeleteAdminUser(string userId);
        //event PassAdminUser AdminUserCreated;
        //event PassAdminUser AdminUserUpdated;
        //event PassAdminUserId AdminUserDeleted;
    }
}
