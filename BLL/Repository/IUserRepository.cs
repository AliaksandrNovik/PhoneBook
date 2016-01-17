using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public interface IUserRepository
    {
        IReadOnlyCollection<AdminUser> GetAdminAll();
        AdminUser GetAdminById(string id);
        AdminUser CreateAdmin(string login, string password);
        bool UpdateAdmin(AdminUser user);
        bool RemoveAdmin(string id);

        IReadOnlyCollection<EmployeeUser> GetEmployeeAll();
        EmployeeUser GetEmployeeById(string id);
        EmployeeUser CreateEmployee(string login, string password, string employeeId);
        bool UpdateEmployee(EmployeeUser user);
        bool RemoveEmployee(string id);

        IReadOnlyCollection<ManagerUser> GetManagerAll();
        ManagerUser GetManagerById(string id);
        ManagerUser CreateManager(string login, string password, string employeeId, string departmentId);
        bool UpdateManager(ManagerUser user);
        bool RemoveManager(string id);
    }
}
