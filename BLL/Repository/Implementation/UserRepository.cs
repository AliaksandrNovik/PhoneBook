using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class UserRepository : IUserRepository
    {
        private FileRepository<AdminUser> _adminRepository;
        public UserRepository()
        {
            _adminRepository = new FileRepository<AdminUser>("AdminUser.txt");
        }

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

        public EmployeeUser CreateEmployee(string login, string password, string employeeId)
        {
            throw new NotImplementedException();
        }

        public ManagerUser CreateManager(string login, string password, string employeeId, string departmentId)
        {
            throw new NotImplementedException();
        }             

        public IReadOnlyCollection<EmployeeUser> GetEmployeeAll()
        {
            throw new NotImplementedException();
        }

        public EmployeeUser GetEmployeeById(string id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<ManagerUser> GetManagerAll()
        {
            throw new NotImplementedException();
        }

        public ManagerUser GetManagerById(string id)
        {
            throw new NotImplementedException();
        }


        public bool RemoveEmployee(string id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveManager(string id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(EmployeeUser user)
        {
            throw new NotImplementedException();
        }

        public bool UpdateManager(ManagerUser user)
        {
            throw new NotImplementedException();
        }
    }
}
