using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UI.AppController;
using Services.Facade;
using Services.Implementation;

namespace UI.AdminUI
{
    public partial class AdminForm : Form
    {
        private IDepartmentService _departmentService = new DepartmentService();
        private IEmployeeService _employeeService = new EmployeeService();
        public AdminForm()
        {
            InitializeComponent();
            FillDepartmentView();
        }


        #region Fill department view
        private void FillDepartmentView()
        {
            var rootId = _departmentService.GetRootId();
            foreach (var subDepartment in _departmentService.GetByParentId(rootId))
            {
                departmentView.Nodes.Add(CreateNode(subDepartment));
            }
            departmentView.ExpandAll();
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
        #endregion

        #region Handling departments
        void CreateDepartment(string name)
        {
            var treeNode = new TreeNode(name);

            //create hash for employees
            //
            var parent = departmentView.SelectedNode;
            if (parent == null)
            {
                var rootId = _departmentService.GetRootId();
                var newDepartment = _departmentService.Create(name, rootId);
                treeNode.Tag = newDepartment;
                departmentView.Nodes.Add(treeNode);
            }
            else
            {
                var parentDepartment = (Department)parent.Tag;
                var newDepartment = _departmentService.Create(name, parentDepartment.Id);
                treeNode.Tag = newDepartment;
                parent.Nodes.Add(treeNode);
            }
            //departmentViewForUsers.Nodes.Add(treeNode);
            departmentView.ExpandAll();
        }

        private void addDeparmentButton_Click(object sender, EventArgs e)
        {
            var currentDepartment = departmentView.SelectedNode;           
            var departmentEditForm = new EditDepartmentForm();
            departmentEditForm.Confirmed += (s, a) => CreateDepartmentConfirmed(s, a);
            departmentEditForm.ShowDialog();
        }

        private void CreateDepartmentConfirmed(object sender, EventArgs e)
        {
            var departmentEditForm = (EditDepartmentForm)sender;
            if (departmentEditForm != null)
            {
                var newName = departmentEditForm.DepartmentName;
                if (string.IsNullOrEmpty(newName))
                {
                    departmentEditForm.ShowError("Название не может быть пустым!");
                }
                else
                {
                    CreateDepartment(newName);
                    departmentEditForm.DialogResult = DialogResult.OK;
                }
            }
        }

        private void changeDepartmentButton_Click(object sender, EventArgs e)
        {
            var currentDepartment = departmentView.SelectedNode;
            if (currentDepartment != null)
            {
                var departmentEditForm = new EditDepartmentForm();
                departmentEditForm.Text = "Подразделение "+ currentDepartment.Text;
                departmentEditForm.DepartmentName = currentDepartment.Text;
                departmentEditForm.Confirmed += (s, a) => UpdateDepartmentConfirmed(s, a);
                departmentEditForm.ShowDialog();
            }
        }

        private void UpdateDepartmentConfirmed(object sender, EventArgs e)
        {
            var departmentEditForm = (EditDepartmentForm)sender;
            if (departmentEditForm != null)
            {
                var newName = departmentEditForm.DepartmentName;
                if (string.IsNullOrEmpty(newName))
                {
                    departmentEditForm.ShowError("Название не может быть пустым!");
                }
                else
                {
                    //update nodes
                    //
                    var currentNode = departmentView.SelectedNode;
                    currentNode.Text = newName;

                    //update data
                    //
                    var currentDepartment = (Department)currentNode.Tag;
                    currentDepartment.Name = newName;
                    _departmentService.Update(currentDepartment);
                    departmentEditForm.DialogResult = DialogResult.OK;
                }
            }
        }

        private void removeDepartmentButton_Click(object sender, EventArgs e)
        {
            var currentNode = departmentView.SelectedNode;
            if (currentNode != null)
            {
                var department = (Department)currentNode.Tag;
                departmentView.Nodes.Remove(currentNode);
                _departmentService.Delete(department);
            }
        }
        #endregion


        #region EmployeeEdit
        private void departmentView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var currentDictionary = (Department)e.Node.Tag;
            var wrappedList = new List<EmployeeWrapperItem>();
            foreach (var employee in _employeeService.GetByDepartmentId(currentDictionary.Id))
            {
                wrappedList.Add(new EmployeeWrapperItem(employee));
            }

            employeeSource.DataSource = wrappedList;
            employeeSource.ResetBindings(false);
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            var currentDepartment = departmentView.SelectedNode;
            var employeeEditForm = new EditEmployeeForm();
            employeeEditForm.Confirmed += (s, a) => CreateEmployeeConfirmed(s, a);
            employeeEditForm.ShowDialog();
        }

        private void CreateEmployeeConfirmed(object sender, EventArgs e)
        {
            //employee params
            //
            var employeeEditForm = (EditEmployeeForm)sender;
            if (ValidateEmployee(employeeEditForm))
            {
                var firstName = employeeEditForm.FirstName;
                var lastName = employeeEditForm.LastName;
                var patronym = employeeEditForm.Patronym;
                var birthday = employeeEditForm.Birthday;
                var place = employeeEditForm.Place;
                var sysDate = DateTime.Parse(employeeEditForm.Birthday);
                var date = new BLL.Date(sysDate.Day, sysDate.Month, sysDate.Year);

                //departmentId
                var currentDepartment = (Department)departmentView.SelectedNode.Tag;
                var newEmployee = _employeeService.CreateEmployee(firstName, lastName, patronym, date, place, currentDepartment.Id);
                employeeSource.Add(new EmployeeWrapperItem(newEmployee));
                employeeSource.ResetBindings(false);
                employeeEditForm.DialogResult = DialogResult.OK;
            }
        }

        private bool ValidateEmployee(EditEmployeeForm form)
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

        private void changeEmployeeButton_Click(object sender, EventArgs e)
        {
            var currentDepartment = (Department)departmentView.SelectedNode.Tag;
            var currentEmployee = (EmployeeWrapperItem)employeeSource.Current;
            if (currentEmployee != null)
            {
                var employeeEditForm = new EditEmployeeForm();
                employeeEditForm.FirstName = currentEmployee.Item.FirstName;
                employeeEditForm.LastName = currentEmployee.Item.LastName;
                employeeEditForm.Patronym = currentEmployee.Item.Patronym;
                employeeEditForm.Birthday = currentEmployee.Item.BirthDate.ToString();
                employeeEditForm.Place = currentEmployee.Item.Place;
                employeeEditForm.Confirmed += (s, a) => UpdateEmployeeConfirmed(s, a);
                employeeEditForm.ShowDialog();
            }
        }

        private void UpdateEmployeeConfirmed(object sender, EventArgs e)
        {
            var employeeEditForm = (EditEmployeeForm)sender;
            if (ValidateEmployee(employeeEditForm))
            {              
                var currentDepartment = (Department)departmentView.SelectedNode.Tag;
                var currentEmployeeWrap = (EmployeeWrapperItem)employeeSource.Current;
                var currentEmployee = currentEmployeeWrap.Item;
                currentEmployee.FirstName = employeeEditForm.FirstName;
                currentEmployee.LastName = employeeEditForm.LastName;
                currentEmployee.Patronym = employeeEditForm.Patronym;
                currentEmployee.Place = employeeEditForm.Place;
                var birthday = employeeEditForm.Birthday;
                var sysDate = DateTime.Parse(employeeEditForm.Birthday);
                var date = new BLL.Date(sysDate.Day, sysDate.Month, sysDate.Year);
                currentEmployee.BirthDate = date;
                _employeeService.UpdateEmployee(currentEmployee);
                employeeSource.ResetBindings(false);
                employeeEditForm.DialogResult = DialogResult.OK;
            }            
        }

        private void removeEmployeeButton_Click(object sender, EventArgs e)
        {
            var currentEmployeeWrap = (EmployeeWrapperItem)employeeSource.Current;
            _employeeService.DeleteEmployee(currentEmployeeWrap.Item.Id);
            employeeSource.RemoveCurrent();            
        }
        #endregion

    }
}
