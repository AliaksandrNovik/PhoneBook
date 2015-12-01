using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public delegate void PassEmployeeUser(EmployeeUser user);
    public delegate void PassEmployeeUserId(String user);

    public delegate void PassManagerUser(ManagerUser user);
    public delegate void PassManagerUserId(String user);

    public delegate void PassAdminUser(AdminUser user);
    public delegate void PassAdminUserId(String user);

    public interface IAdminService
    {
        void AddEmployeeUser(string login, string password, String employeeId);
        void UdpateEmployeeUser(EmployeeUser employeeUser);
        void DeleteEmployeeUser(String userId);
        event PassEmployeeUser EmployeeUserCreated;
        event PassEmployeeUser EmployeeUserUpdated;
        event PassEmployeeUserId EmployeeUserDeleted;

        void AddManagerUser(string login, string password, String departmentId);
        void UpdateManagerUser(ManagerUser managerUser);
        void DeleteManagerUser(String userId);
        event PassManagerUser ManagerUserCreated;
        event PassManagerUser ManagerUserUpdated;
        event PassManagerUserId ManagerUserDeleted;

        void AddAdmin(string login, string password);
        void UpdateAdminUser(AdminUser user);
        void DeleteAdminUser(String userId);
        event PassAdminUser AdminUserCreated;
        event PassAdminUser AdminUserUpdated;
        event PassAdminUserId AdminUserDeleted;
    }
}
