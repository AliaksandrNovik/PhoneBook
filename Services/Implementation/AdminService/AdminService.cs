﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;
using BLL.Repository;

namespace Services.Implementation
{
    public class AdminService : IAdminService
    {
        public bool ContainsUser(string login)
        {
            return false;
        }

        private IUserRepository _userRepository = new UserRepository();

        #region Admin
        public IAdminUser CreateAdminUser(string login, string password)
        {
            var adminRepUser = _userRepository.CreateAdmin(login, password);
            return new AdminUser(login, password, adminRepUser.Id);
        }

        public bool DeleteAdminUser(string userId)
        {
            return _userRepository.RemoveAdmin(userId);
        }

        public bool UpdateAdminUser(IAdminUser user)
        {
            var adminRepUser = _userRepository.GetAdminById(user.UserId);
            adminRepUser.Login = user.Login;
            adminRepUser.Password = user.Password;
            return _userRepository.UpdateAdmin(adminRepUser);
        }

        IReadOnlyCollection<IAdminUser> IAdminService.GetAllAdminUsers()
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

        public bool UdpateEmployeeUser(IEmployeeUser employeeUser)
        {
            var employeeRepUser = _userRepository.GetEmployeeById(employeeUser.UserId);
            employeeRepUser.Login = employeeUser.Login;
            employeeRepUser.Password = employeeUser.Password;
            employeeRepUser.EmployeeId = employeeUser.EmployeeId;
            return _userRepository.UpdateEmployee(employeeRepUser);
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

        public IReadOnlyCollection<IManagerUser> GetAllEmployeeUsers()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
        #endregion
    }
}
