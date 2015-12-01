using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IUserRepository
    {
        IReadOnlyCollection<AdminUser> GetAdminAll();
        AdminUser CreateAdmin(string login, string password);
        bool UpdateAdmin(AdminUser user);
        bool RemoveAdmin(AdminUser user);

        IReadOnlyCollection<EmployeeUser> GetEmployeeAll();
        EmployeeUser CreateEmployee(string login, string password, string employeeId);
        bool UpdateEmployee(EmployeeUser user);
        bool RemoveEmployee(EmployeeUser user);

        IReadOnlyCollection<ManagerUser> GetManagerAll();
        ManagerUser CreateManager(string login, string password, string employeeId, string departmentId);
        bool UpdateManager(ManagerUser user);
        bool RemoveManager(ManagerUser user);
    }
}
