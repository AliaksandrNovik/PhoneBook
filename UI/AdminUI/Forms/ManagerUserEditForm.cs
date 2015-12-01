using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Basics;

namespace UI.AdminUI.Forms
{
    public partial class ManagerUserEditForm : Form, IManagerUserEditView
    {
        public ManagerUserEditForm()
        {
            InitializeComponent();
        }

        private Employee _currentEmployee;
        List<Department> _availableDepartments;
        public IReadOnlyCollection<Department> AvailableDepartments
        {
            get
            {
                return _availableDepartments; 
            }

            set
            {
                _availableDepartments = new List<Department>(value);
                departmentSource.DataSource = _availableDepartments;
                departmentSource.ResetBindings(false);                
            }
        }

        List<Employee> _availableEmployees;
        public IReadOnlyCollection<Employee> AvailableEmployees
        {
            get
            {
                return _availableEmployees;
            }

            set
            {
                _availableEmployees = new List<Employee>(value);
                var wrappedItems = new List<EmployeeWrapperItem>();
                EmployeeWrapperItem currentEmployeeWrap = null;

                int index = 0;
                int currentIndex = -1;
                foreach (var employee in _availableEmployees)
                {
                    var employeeWrapItem = new EmployeeWrapperItem(employee);
                    wrappedItems.Add(employeeWrapItem);
                    if (_currentEmployee!= null && _currentEmployee.Equals(employee))
                    {
                        currentIndex = index;
                        currentEmployeeWrap = employeeWrapItem;
                    }
                    ++index;
                }
                employeeSource.DataSource = wrappedItems;
                if (currentIndex >= 0)
                {
                    employeeSource.Position = currentIndex;
                }
            }
        }

        private ManagerUser _user;
        public ManagerUser User
        {
            get
            {
                if (_user != null)
                {
                    var department = (Department)departmentSource.Current;
                    var employeeWrap = (EmployeeWrapperItem)departmentSource.Current;
                    var employee = employeeWrap?.Employee;
                    _user.Department = department;
                    _user.Employee = employee;
                    _user.UserInfo.Login = loginLine.Text;
                    _user.UserInfo.Password = loginLine.Text;
                    return _user;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _user = value;
                loginLine.Text = _user?.UserInfo?.Login;
                passwordLine.Text = _user?.UserInfo?.Password;
                var department = _user.Department;
                if (department != null)
                {
                    int departmentIndex = _availableDepartments.IndexOf(department);
                    if (departmentIndex >= 0)
                    {
                        departmentSource.Position = departmentIndex;
                        departmentSource.ResetBindings(false);
                    }
                }
                _currentEmployee = _user.Employee;
            }
        }

        //buttons
        //
        public event Action Canceled;
        public event Action Confirmed;
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (Confirmed != null)
            {
                Confirmed();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (Canceled != null)
            {
                Canceled();
            }
        }


        //Department changed
        //
        public event DepartmentDelegate DepartmentSet;

        public void SetError(string msg)
        {
            throw new NotImplementedException();
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentDepartment = (Department)departmentSource.Current;
            if (currentDepartment != null)
            {
                DepartmentSet(new DepartmentArgs(currentDepartment));
            }
        }
    }
}
