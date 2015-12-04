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

namespace UI.AdminUI
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            departmentView.Nodes.Add("Компания");
        }                      

        private void Create(object sender, EventArgs e)
        {
            var dialog = (AdminUserEditDialog)sender;
            bool valid = !string.IsNullOrEmpty(dialog.Login) && !string.IsNullOrEmpty(dialog.Password);
            Console.Write(valid);
            if (valid.Equals(true))
            {
                //todo
                dialog.Close();
            }
        }

        #region DepartmentEdit
        private void addDeparmentButton_Click(object sender, EventArgs e)
        {
            var currentDepartment = departmentView.SelectedNode;
            if (currentDepartment != null)
            {
                var departmentEditForm = new EditDepartmentForm();
                departmentEditForm.Confirmed += (s, a) => CreateDepartmentConfirmed(s, a);
                departmentEditForm.ShowDialog();
            }
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
                    AddDepartment(new TreeNode(newName));
                    departmentEditForm.DialogResult = DialogResult.OK;
                }
            }
        }

        void AddDepartment(TreeNode department)
        {
            if (department != null)
            {
                var parent = departmentView.SelectedNode;
                if (parent != null)
                {
                    Console.WriteLine(parent.Level.ToString());
                    if (parent.Level > 2)
                    {
                        parent = parent.Parent;
                        if (parent != null)
                        {
                            parent.Nodes.Add(department);
                        }
                    }
                    else
                    {
                        parent.Nodes.Add(department);
                    }
                }
                departmentView.ExpandAll();
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
                    var currentDepartment = departmentView.SelectedNode;
                    currentDepartment.Text = newName;
                    departmentEditForm.DialogResult = DialogResult.OK;
                }
            }
        }

        private void removeDepartmentButton_Click(object sender, EventArgs e)
        {
            var currentDepartment = departmentView.SelectedNode;
            if (currentDepartment != null)
            {
                if (currentDepartment.Parent != null)
                {
                    departmentView.Nodes.Remove(currentDepartment);
                }
            }
        }
        #endregion


        #region EmployeeEdit
        #endregion
        Dictionary<TreeNode, List<EmployeeWrapperItem>> _employeeDict = new Dictionary<TreeNode, List<EmployeeWrapperItem>>();
        private void departmentView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var currentDepartment = e.Node;
            if (currentDepartment != null)
            {
                if (_employeeDict.ContainsKey(currentDepartment))
                {
                    employeeSource.DataSource = _employeeDict[currentDepartment];
                }
                else
                {
                    employeeSource.DataSource = null;
                }
            }
            else
            {
                employeeSource.DataSource = null;
            }
            employeeSource.ResetBindings(false);
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            var currentDepartment = departmentView.SelectedNode;
            if (currentDepartment != null)
            {
                var employeeEditForm = new EditEmployeeForm();
                employeeEditForm.Confirmed += (s, a) => CreateEmployeeConfirmed(s, a);
                employeeEditForm.ShowDialog();
            }
        }

        private void CreateEmployeeConfirmed(object sender, EventArgs e)
        {
            var employeeEditForm = (EditEmployeeForm)sender;
            var firstName = employeeEditForm.FirstName;
            var lastName = employeeEditForm.LastName;
            var patronym = employeeEditForm.Patronym;
            var birthday = employeeEditForm.Birthday;
            var place = employeeEditForm.Place;
            employeeSource.Add(new EmployeeWrapperItem(firstName, lastName, patronym, birthday, place));
            employeeSource.ResetBindings(false);
            employeeEditForm.DialogResult = DialogResult.OK;
        }

        private void changeEmployeeButton_Click(object sender, EventArgs e)
        {
            var currentDepartment = departmentView.SelectedNode;
            if (currentDepartment != null)
            {
                var currentEmployee = (EmployeeWrapperItem)employeeSource.Current;
                if (currentEmployee != null)
                {
                    var employeeEditForm = new EditEmployeeForm();
                    employeeEditForm.FirstName = currentEmployee.FirstName;
                    employeeEditForm.LastName = currentEmployee.LastName;
                    employeeEditForm.Patronym = currentEmployee.Patronym;
                    employeeEditForm.Birthday = currentEmployee.BirthDate;
                    employeeEditForm.Place = currentEmployee.Place;
                    employeeEditForm.Confirmed += (s, a) => UpdateEmployeeConfirmed(s, a);
                    employeeEditForm.ShowDialog();
                }
            }
        }

        private void UpdateEmployeeConfirmed(object sender, EventArgs e)
        {
            var employeeEditForm = (EditEmployeeForm)sender;

            var currentEmployee = (EmployeeWrapperItem)employeeSource.Current;
            currentEmployee.FirstName = employeeEditForm.FirstName;
            currentEmployee.LastName = employeeEditForm.LastName;
            currentEmployee.Patronym = employeeEditForm.Patronym;
            currentEmployee.BirthDate = employeeEditForm.Birthday;
            currentEmployee.Place = employeeEditForm.Place;
            employeeSource.ResetBindings(false);
            employeeEditForm.DialogResult = DialogResult.OK;
        }

        private void removeEmployeeButton_Click(object sender, EventArgs e)
        {
            employeeSource.RemoveCurrent();            
        }
    }
}
