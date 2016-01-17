using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;
using Repositories.Repository;

namespace Services.Implementation
{
    public class AdminService : IAdminService
    {
        private IUserRepository _userRepository = new UserRepository();
        public bool ContainsUser(string login)
        {
            bool containsAdmin = GetAllAdminUsers().Any(x => x.Login == login);
            if (containsAdmin)
                return true;

            
            bool containsManager = GetAllManagerUsers().Any(x => x.Login == login);
            if (containsManager)
                return true;

            bool containsEmployee = GetAllEmployeeUsers().Any(x => x.Login == login);
            if (containsEmployee)
                return true;

            return false;
        }

        public bool DeleteUser(string userId)
        {
            if (_userRepository.RemoveAdmin(userId))
                return true;
            if (_userRepository.RemoveEmployee(userId))
                return true;
            if (_userRepository.RemoveManager(userId))
                return true;

            return false;
        }

        public IUserInfo GetUserInfoByEmployeeId(string employeeId)
        {
            var employee = GetAllEmployeeUsers().FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee != null)            
                return new UserInfo(UserType.Employee, employee.UserId);

            var manager = GetAllManagerUsers().FirstOrDefault(x => x.EmployeeId == employeeId);
            if (manager != null)
                return new UserInfo(UserType.Manager, manager.UserId);

            return null;
        }

        #region Admin
        public IAdminUser CreateAdminUser(string login, string password)
        {
            var adminRepUser = _userRepository.CreateAdmin(login, password);
            return new AdminUser(login, password, adminRepUser.Id);
        }

        public bool UpdateAdminUser(IAdminUser user)
        {
            var adminRepUser = _userRepository.GetAdminById(user.UserId);
            adminRepUser.Login = user.Login;
            adminRepUser.Password = user.Password;
            return _userRepository.UpdateAdmin(adminRepUser);
        }

        public IReadOnlyCollection<IAdminUser> GetAllAdminUsers()
        {
            var adminUserList = new List<IAdminUser>();
            foreach (var repAdminUser in _userRepository.GetAdminAll())
            {
                adminUserList.Add(new AdminUser(repAdminUser.Login, repAdminUser.Password, repAdminUser.Id));
            }
            return adminUserList;
        }
        #endregion

        #region Employee
        public IEmployeeUser CreateEmployeeUser(string login, string password, string employeeId)
        {
            var employeeUser = _userRepository.CreateEmployee(login, password, employeeId);
            return new EmployeeUser(login, password, employeeId, employeeUser.Id);
        }

        public bool DeleteEmployeeUser(string userId)
        {
            return _userRepository.RemoveEmployee(userId);
        }

        public bool UpdateEmployeeUser(IEmployeeUser employeeUser)
        {
            var employeeRepUser = _userRepository.GetEmployeeById(employeeUser.UserId);
            employeeRepUser.Login = employeeUser.Login;
            employeeRepUser.Password = employeeUser.Password;
            employeeRepUser.EmployeeId = employeeUser.EmployeeId;
            return _userRepository.UpdateEmployee(employeeRepUser);
        }

        public IReadOnlyCollection<IEmployeeUser> GetAllEmployeeUsers()
        {
            var employeeUserList = new List<IEmployeeUser>();
            foreach (var repEmployeeUser in _userRepository.GetEmployeeAll())
            {
                employeeUserList.Add(new EmployeeUser(repEmployeeUser.Login, repEmployeeUser.Password, repEmployeeUser.EmployeeId, repEmployeeUser.Id));
            }
            return employeeUserList;
        }

        #endregion

        #region Manager
        public IManagerUser CreateManagerUser(string login, string password, string employeeId, string departmentId)
        {
            var employeeUser = _userRepository.CreateManager(login, password, employeeId, departmentId);
            return new ManagerUser(login, password, employeeId, departmentId, employeeUser.Id);
        }
        
        public bool DeleteManagerUser(string userId)
        {
            return _userRepository.RemoveManager(userId);
        }

        public bool UpdateManagerUser(IManagerUser managerUser)
        {
            var managerRepUser = _userRepository.GetManagerById(managerUser.UserId);
            managerRepUser.Login = managerUser.Login;
            managerRepUser.Password = managerUser.Password;
            managerRepUser.EmployeeId = managerUser.EmployeeId;
            managerRepUser.DepartmentId = managerRepUser.DepartmentId;
            return _userRepository.UpdateManager(managerRepUser);
        }       

        public IReadOnlyCollection<IManagerUser> GetAllManagerUsers()
        {
            var employeeUserList = new List<IManagerUser>();
            foreach (var repEmployeeUser in _userRepository.GetManagerAll())
            {
                employeeUserList.Add(new ManagerUser(
                    repEmployeeUser.Login, repEmployeeUser.Password, repEmployeeUser.EmployeeId, 
                    repEmployeeUser.DepartmentId, repEmployeeUser.Id));
            }
            return employeeUserList;
        }

        public IEmployeeUser GetEmployeeUserById(string userId)
        {
            var repUser = _userRepository.GetEmployeeById(userId);
            if (repUser != null)
                return new EmployeeUser(repUser.Login, repUser.Password, repUser.EmployeeId, repUser.Id);

            return null;
        }

        public IManagerUser GetManagerUserById(string userId)
        {
            var repUser = _userRepository.GetManagerById(userId);
            return new ManagerUser(repUser.Login, repUser.Password, repUser.EmployeeId, repUser.DepartmentId, repUser.Id);
        }

        public IAdminUser GetAdminUserById(string userId)
        {
            var repUser = _userRepository.GetAdminById(userId);
            return new AdminUser(repUser.Login, repUser.Password, repUser.Id);
        }
        #endregion
    }
}
