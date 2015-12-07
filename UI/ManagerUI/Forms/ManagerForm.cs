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

        public ManagerForm(string userId)
        {
            InitializeComponent();
            InitializeContents(userId);

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

        }

        private void removePhoneButton_Click(object sender, EventArgs e)
        {
            var phoneWrap = (PhoneWrapItem)phoneSource.Current;
            var phone = phoneWrap.PhoneItem;
            _phoneService.DeletePhone(phone.Id);
            phoneSource.RemoveCurrent();
        }
    }
}
