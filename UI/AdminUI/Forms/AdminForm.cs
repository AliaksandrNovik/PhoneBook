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


        private void changeDepartmentButton_Click(object sender, EventArgs e)
        {

        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {

        }

        private void changeEmployeeButton_Click(object sender, EventArgs e)
        {

        }

        private void removeEmployeeButton_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
        private void addDepartment_Click(object sender, EventArgs e)
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

        private void removeDepartment_Click(object sender, EventArgs e)
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

        #endregion
    }
}
