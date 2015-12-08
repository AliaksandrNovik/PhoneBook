using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.Facade;
using Services.Implementation;

using UI.AdminUI;

namespace UI.ManagerUI
{
    public partial class ManagerForm : Form
    {
        private IAdminService _adminService = new AdminService();
        private IReadOnlyDepartmentService _departmentService = new DepartmentService();
        private IEmployeeService _employeeService = new EmployeeService();
        private IPhoneService _phoneService = new PhoneService();
        private IStatisticService _statService = new StatisticService();

        public ManagerForm(string userId)
        {
            InitializeComponent();
            InitializeContents(userId);

            addEmployeeButton.Enabled = false;
            changeEmployeeButton.Enabled = false;
            removeEmployeeButton.Enabled = false;

            addPhoneButton.Enabled = false;
            changePhoneButton.Enabled = false;
            removePhoneButton.Enabled = false;
            statButton.Enabled = false;
        }

        private void InitializeContents(string userId)
        {
            var managerUser = _adminService.GetManagerUserById(userId);
            if (managerUser == null)
                throw new ArgumentException("Not valid userId!");

            var departmentId = managerUser.DepartmentId;
            var department = _departmentService.GetById(departmentId);
            if (department == null)
                throw new ArgumentException("There is no department to handle!");

            var rootNode = CreateNode(department);
            departmentView.Nodes.Add(rootNode);
            departmentView.ExpandAll();

            departmentViewForPhones.Nodes.Add((TreeNode)rootNode.Clone());
            departmentViewForPhones.ExpandAll();
        }

        private TreeNode CreateNode(IDepartment department)
        {
            var treeNode = new TreeNode(department.Name);
            treeNode.Tag = department;
            foreach (var subDepartment in _departmentService.GetByParentId(department.Id))
            {
                treeNode.Nodes.Add(CreateNode(subDepartment));
            }
            return treeNode;
        }


        private void departmentView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            addEmployeeButton.Enabled = true;

            var currentDepartment = (IDepartment)e.Node.Tag;
            var wrappedList = new List<EmployeeWrapperItem>();
            foreach (var employee in _employeeService.GetByDepartmentId(currentDepartment.Id))
            {
                var userInfo = _adminService.GetUserInfoByEmployeeId(employee.Id);
                wrappedList.Add(new EmployeeWrapperItem(employee, userInfo));
            }

            employeeSource.DataSource = wrappedList;
            employeeSource.ResetBindings(false);
        }

        private void departmentViewForPhones_AfterSelect(object sender, TreeViewEventArgs e)
        {
            addPhoneButton.Enabled = true;

            var currentDepartment = (IDepartment)e.Node.Tag;
            var wrappedList = new List<PhoneWrapItem>();
            foreach (var phone in _phoneService.GetByDepartmentId(currentDepartment.Id))
            {
                var employee = _employeeService.GetEmployeeById(phone.EmployeeId);
                wrappedList.Add(new PhoneWrapItem(phone, employee));
            }

            phoneSource.DataSource = wrappedList;
            employeeSource.ResetBindings(false);
        }

        private void employeeSource_CurrentChanged(object sender, EventArgs e)
        {
            bool enabled = (employeeSource.Current != null);
            changeEmployeeButton.Enabled = enabled;
            removeEmployeeButton.Enabled = enabled;

            if (enabled)
            {
                var currentEmployee = (EmployeeWrapperItem)employeeSource.Current;
                var userInfo = currentEmployee.UserInfo;
                if (userInfo != null && userInfo.Type != UserType.Employee)//can handle only employee 
                {
                    changeEmployeeButton.Enabled = false;
                    removeEmployeeButton.Enabled = false;
                }
            }
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            var currentDepartment = (IDepartment)departmentViewForPhones.SelectedNode.Tag;
            var departmentId = currentDepartment.Id;
            var employees = _employeeService.GetByDepartmentId(departmentId);
            var phoneEditForm = new PhoneEditForm(employees);
            phoneEditForm.Confirmed += (s, a) => CreatedPhone(s, a, departmentId);
            phoneEditForm.ShowDialog();
        }

        void CreatedPhone(object sender, EventArgs e, string departmentId)
        {
            var phoneEditForm = (PhoneEditForm)sender;
            var number = phoneEditForm.Phone;
            if (string.IsNullOrWhiteSpace(number))
            {
                phoneEditForm.ShowError("Введите номер!");
                return;
            }

            var employee = phoneEditForm.CurrentEmployee;
            var phone = _phoneService.CreatePhone(number, departmentId, employee?.Id);
            phoneSource.Add(new PhoneWrapItem(phone, employee));
            phoneSource.ResetBindings(false);
            phoneEditForm.DialogResult = DialogResult.OK;
        }

        private void changePhoneButton_Click(object sender, EventArgs e)
        {
            var currentPhoneWrap = (PhoneWrapItem)phoneSource.Current;
            var currentDepartment = (IDepartment)departmentViewForPhones.SelectedNode.Tag;
            var departmentId = currentDepartment.Id;
            var employees = _employeeService.GetByDepartmentId(departmentId);
            var phoneEditForm = new PhoneEditForm(employees);
            phoneEditForm.Phone = currentPhoneWrap.Phone;

            var employee = currentPhoneWrap.EmployeeItem;
            if (employee != null)
                phoneEditForm.CurrentEmployee = currentPhoneWrap.EmployeeItem;

            phoneEditForm.Confirmed += (s, a) => UpdatedPhone(s, a, currentPhoneWrap);
            phoneEditForm.ShowDialog();
        }

        void UpdatedPhone(object sender, EventArgs e, PhoneWrapItem phoneWrap)
        {
            var phoneEditForm = (PhoneEditForm)sender;
            var number = phoneEditForm.Phone;
            if (string.IsNullOrWhiteSpace(number))
            {
                phoneEditForm.ShowError("Введите номер!");
                return;
            }

            var phone = phoneWrap.PhoneItem;
            phone.Number = number;
            var employeeId = phoneEditForm?.CurrentEmployee?.Id;
            phone.EmployeeId = employeeId;

            IEmployee employee = null;
            if (employeeId != null)
            {
                employee = _employeeService.GetEmployeeById(employeeId);
            }

            _phoneService.UpdatePhone(phone);
            phoneWrap.PhoneItem = phone;
            phoneWrap.EmployeeItem = employee;

            phoneEditForm.DialogResult = DialogResult.OK;
            phoneSource.ResetBindings(false);
        }

        private void removePhoneButton_Click(object sender, EventArgs e)
        {
            var phoneWrap = (PhoneWrapItem)phoneSource.Current;
            var phone = phoneWrap.PhoneItem;
            _phoneService.DeletePhone(phone.Id);
            phoneSource.RemoveCurrent();
        }

        private void phoneSource_CurrentChanged(object sender, EventArgs e)
        {
            bool enabled = (phoneSource.Current != null);
            changePhoneButton.Enabled = enabled;
            removePhoneButton.Enabled = enabled;
            statButton.Enabled = enabled;
        }

        private bool ValidateEmployee(EditEmployeeUserForm form)
        {
            if (string.IsNullOrWhiteSpace(form.FirstName))
            {
                form.ShowError("Введите имя!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(form.LastName))
            {
                form.ShowError("Введите фамилию!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(form.Place))
            {
                form.ShowError("Введите должность!");
                return false;
            }

            DateTime dateTime;
            if (!DateTime.TryParse(form.Birthday, out dateTime))
            {
                form.ShowError("Некорректно задана дата рождения");
                return false;
            }
            return true;
        }

        private bool ValidateUser(EditEmployeeUserForm form, string oldUserName = null)
        {
            if (!form.IsUserAvailable)
            {
                return true; 
            }
            else if (string.IsNullOrWhiteSpace(form.Login))
            {
                form.ShowError("Введите логин!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(form.Password))
            {
                form.ShowError("Введите пароль!");
                return false;
            }
            else
            {

                if (oldUserName == null || oldUserName != form.Login)
                {
                    if (_adminService.ContainsUser(form.Login))
                    {
                        form.ShowError("Такой пользователь уже есть в системе");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            var currentDepartment = (IDepartment)departmentView.SelectedNode.Tag;
            var editForm = new EditEmployeeUserForm();
            editForm.Confirmed += (s, a) => CreateEmployeeConfirmed(s, a, currentDepartment.Id);
            editForm.ShowDialog();
        }

        void CreateEmployeeConfirmed(object sender, EventArgs e, string departmentId)
        {
            var editForm = (EditEmployeeUserForm)sender;
            if (ValidateEmployee(editForm) && ValidateUser(editForm))
            {
                var firstName = editForm.FirstName;
                var lastName = editForm.LastName;
                var patronym = editForm.Patronym;
                var birthday = editForm.Birthday;
                var place = editForm.Place;
                var sysDate = DateTime.Parse(editForm.Birthday);
                var date = new BLL.Date(sysDate.Day, sysDate.Month, sysDate.Year);
                var newEmployee = _employeeService.CreateEmployee
                    (
                    firstName, lastName, patronym,
                    date, place, departmentId
                    );

                if (editForm.IsUserAvailable)
                {
                    var login = editForm.Login;
                    var password = editForm.Password;
                    _adminService.CreateEmployeeUser(login, password, newEmployee.Id);
                }

                var userInfo = _adminService.GetUserInfoByEmployeeId(newEmployee.Id);
                employeeSource.Add(new EmployeeWrapperItem(newEmployee, userInfo));
                employeeSource.ResetBindings(true);
                editForm.DialogResult = DialogResult.OK;
            }
        }

        private void changeEmployeeButton_Click(object sender, EventArgs e)
        {
            var currentDepartment = (IDepartment)departmentView.SelectedNode.Tag;
            var currentEmployeeWrap = (EmployeeWrapperItem)employeeSource.Current;
            var currentEmployee = currentEmployeeWrap.Item;
            var editForm = new EditEmployeeUserForm();
            editForm.FirstName = currentEmployee.FirstName;
            editForm.LastName = currentEmployee.LastName;
            editForm.Patronym = currentEmployee.Patronym;
            editForm.Birthday = currentEmployee.BirthDate.ToString();
            editForm.Place = currentEmployee.Place;

            IEmployeeUser employeeUser = null;
            var userInfo = _adminService.GetUserInfoByEmployeeId(currentEmployee.Id);
            if (userInfo != null)
            {
                employeeUser = _adminService.GetEmployeeUserById(userInfo.UserId);
                editForm.IsUserAvailable = true;
                editForm.Login = employeeUser.Login;
                editForm.Password = employeeUser.Password;
            }
            editForm.Confirmed += (s, a) => UpdateEmployeeConfirmed(s, a, employeeUser, currentEmployeeWrap,
                currentDepartment.Id);
            editForm.ShowDialog();
        }

        void UpdateEmployeeConfirmed(object sender, EventArgs e, IEmployeeUser oldUser, 
            EmployeeWrapperItem currentEmployeeWrap, string departmentId)
        {
            
            var editForm = (EditEmployeeUserForm)sender;
            if (ValidateEmployee(editForm) && ValidateUser(editForm, oldUser?.Login))
            {
                var employeeId = currentEmployeeWrap.Item.Id;

                var firstName = editForm.FirstName;
                var lastName = editForm.LastName;
                var patronym = editForm.Patronym;
                var birthday = editForm.Birthday;
                var place = editForm.Place;
                var sysDate = DateTime.Parse(editForm.Birthday);
                var date = new BLL.Date(sysDate.Day, sysDate.Month, sysDate.Year);

                var currentEmployee = currentEmployeeWrap.Item;
                currentEmployee.FirstName = firstName;
                currentEmployee.LastName = lastName;
                currentEmployee.Patronym = patronym;
                currentEmployee.BirthDate = date;
                currentEmployee.Place = place;
                _employeeService.UpdateEmployee(currentEmployee);

                //handling users
                //
                if (editForm.IsUserAvailable)
                {
                    var login = editForm.Login;
                    var password = editForm.Password;
                    if (oldUser != null)
                    {
                        oldUser.Login = login;
                        oldUser.Password = password;
                        _adminService.UpdateEmployeeUser(oldUser);
                    }
                    else
                    {
                        _adminService.CreateEmployeeUser(login, password, employeeId);
                    }
                }
                else
                {
                    if (oldUser != null)
                    {
                        _adminService.DeleteUser(oldUser.UserId);
                    }
                }

                var userInfo = _adminService.GetUserInfoByEmployeeId(employeeId);
                currentEmployeeWrap.Item = currentEmployee;
                currentEmployeeWrap.UserInfo = userInfo;
                employeeSource.ResetBindings(true);
                editForm.DialogResult = DialogResult.OK;
            }
        }

        private void removeEmployeeButton_Click(object sender, EventArgs e)
        {
            var employeeWrap = (EmployeeWrapperItem)employeeSource.Current;
            var employee = employeeWrap.Item;
            _employeeService.DeleteEmployee(employee.Id);
            employeeSource.RemoveCurrent();
        }

        private void statButton_Click(object sender, EventArgs e)
        {
            var phone = (PhoneWrapItem)phoneSource.Current;
            var statForm = new UI.StatisticUI.Forms.PersonalStatistic();
            statForm.Employee = phone.Name;
            statForm.Department = departmentViewForPhones.SelectedNode.Text;
            statForm.Phone = phone.Phone;

            statForm.Items = _statService.GetByPhoneId(phone.PhoneItem.Id);
            statForm.ShowDialog();
        }
    }
}
