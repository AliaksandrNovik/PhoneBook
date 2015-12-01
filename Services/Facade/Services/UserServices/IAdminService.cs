using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public delegate void PassEmployeeUser(EmployeeUser user);
    public delegate void PassEmployeeUserId(EntityId user);

    public delegate void PassManagerUser(ManagerUser user);
    public delegate void PassManagerUserId(EntityId user);

    public delegate void PassAdminUser(AdminUser user);
    public delegate void PassAdminUserId(EntityId user);

    public interface IAdminService
    {
        void AddEmployeeUser(string login, string password, EntityId employeeId);
        void UdpateEmployeeUser(EmployeeUser employeeUser);
        void DeleteEmployeeUser(EntityId userId);
        event PassEmployeeUser EmployeeUserCreated;
        event PassEmployeeUser EmployeeUserUpdated;
        event PassEmployeeUserId EmployeeUserDeleted;

        void AddManagerUser(string login, string password, EntityId departmentId);
        void UpdateManagerUser(ManagerUser managerUser);
        void DeleteManagerUser(EntityId userId);
        event PassManagerUser ManagerUserCreated;
        event PassManagerUser ManagerUserUpdated;
        event PassManagerUserId ManagerUserDeleted;

        void AddAdmin(string login, string password);
        void UpdateAdminUser(AdminUser user);
        void DeleteAdminUser(EntityId userId);
        event PassAdminUser AdminUserCreated;
        event PassAdminUser AdminUserUpdated;
        event PassAdminUserId AdminUserDeleted;
    }
}
