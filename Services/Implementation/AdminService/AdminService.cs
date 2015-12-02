using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;

namespace Services.Implementation
{
    public class AdminService : IAdminService
    {
        private BLL.IUserRepository _userRepository;
        public AdminService(BLL.IUserRepository useRepository)
        {
            _userRepository = useRepository;
        }

        public IAdminUser CreateAdminUser(string login, string password)
        {
            var adminRepUser = _userRepository.CreateAdmin(login, password);
            return new AdminUser(login, password, adminRepUser.Id);
        }

        public IEmployeeUser CreateEmployeeUser(string login, string password, string employeeId)
        {
            var employeeUser = _userRepository.CreateEmployee(login, password, employeeId);
            return new EmployeeUser(login, password, employeeId, employeeUser.Id);
        }

        public IManagerUser CreateManagerUser(string login, string password, string employeeId, string departmentId)
        {
            var employeeUser = _userRepository.CreateManager(login, password, employeeId, departmentId);
            return new ManagerUser(login, password, employeeId, departmentId, employeeUser.Id);
        }

        public bool DeleteAdminUser(string userId)
        {
            return _userRepository.RemoveAdmin(userId);
        }

        public bool DeleteEmployeeUser(string userId)
        {
            return _userRepository.RemoveEmployee(userId);
        }

        public bool DeleteManagerUser(string userId)
        {
            return _userRepository.RemoveManager(userId);
        }

        public bool UdpateEmployeeUser(IEmployeeUser employeeUser)
        {
            var employeeRepUser = _userRepository.GetEmployeeById(employeeUser.UserId);
            employeeRepUser.Login = employeeUser.Login;
            employeeRepUser.Password = employeeUser.Password;
            employeeRepUser.EmployeeId = employeeUser.EmployeeId;
            return _userRepository.UpdateEmployee(employeeRepUser);
        }

        public bool UpdateAdminUser(IAdminUser user)
        {
            var adminRepUser = _userRepository.GetAdminById(user.UserId);
            adminRepUser.Login = user.Login;
            adminRepUser.Password = user.Password;
            return _userRepository.UpdateAdmin(adminRepUser);
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
    }
}
