using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class UserRepository : IUserRepository
    {
        private FileRepository<AdminUser> _adminRepository = FileRepository<AdminUser>.GetInstance("AdminUser.txt");
        private FileRepository<EmployeeUser> _employeeRepository = FileRepository<EmployeeUser>.GetInstance("EmployeeUser.txt");
        private FileRepository<ManagerUser> _managerRepository = FileRepository<ManagerUser>.GetInstance("ManagerUser.txt");

        #region Admin
        public AdminUser CreateAdmin(string login, string password)
        {
            var adminUser = new AdminUser(login, password);
            _adminRepository.Upsert(adminUser);
            return adminUser;
        }

        public IReadOnlyCollection<AdminUser> GetAdminAll()
        {
            return _adminRepository.GetAll();
        }

        public AdminUser GetAdminById(string id)
        {
            return _adminRepository.GetById(id);
        }

        public bool RemoveAdmin(string id)
        {
            return _adminRepository.Delete(id);
        }

        public bool UpdateAdmin(AdminUser user)
        {
            bool canUpdate = (_adminRepository.GetById(user.Id) != null);
            if (canUpdate)
            {
                _adminRepository.Upsert(user);
            }
            return canUpdate;
        }
        #endregion

        #region Employee
        public IReadOnlyCollection<EmployeeUser> GetEmployeeAll()
        {
            return _employeeRepository.GetAll();
        }

        public EmployeeUser GetEmployeeById(string id)
        {
            return _employeeRepository.GetById(id);
        }

        public bool RemoveEmployee(string id)
        {
            return _employeeRepository.Delete(id);
        }

        public bool UpdateEmployee(EmployeeUser user)
        {
            bool canUpdate = (_employeeRepository.GetById(user.Id) != null);
            if (canUpdate)
            {
                _employeeRepository.Upsert(user);
            }
            return canUpdate;
        }

        public EmployeeUser CreateEmployee(string login, string password, string employeeId)
        {
            var employeeUser = new EmployeeUser(login, password, employeeId);
            _employeeRepository.Upsert(employeeUser);
            return employeeUser;
        }
        #endregion

        #region Manager
        public IReadOnlyCollection<ManagerUser> GetManagerAll()
        {
            return _managerRepository.GetAll();
        }

        public ManagerUser GetManagerById(string id)
        {
            return _managerRepository.GetById(id);
        }

        public bool RemoveManager(string id)
        {
            return _managerRepository.Delete(id);
        }

        public bool UpdateManager(ManagerUser user)
        {
            bool canUpdate = (_managerRepository.GetById(user.Id) != null);
            if (canUpdate)
            {
                _managerRepository.Upsert(user);
            }
            return canUpdate;
        }

        public ManagerUser CreateManager(string login, string password, string employeeId, string departmentId)
        {
            var managerUser = new ManagerUser(login, password, employeeId, departmentId);
            _managerRepository.Upsert(managerUser);
            return managerUser;
        }
        #endregion
    }
}
