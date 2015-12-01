using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UI.Views;
using UI.AppController;
using UI.Basics;

namespace UI.ManagerUI
{
    public partial class ManagerForm : Form, IManagerPassiveView
    {
        private readonly ApplicationContext _context;

        public ManagerForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            /*
            addDepartment.Enabled = false;
            changeDepartment.Enabled = false;
            removeDepartment.Enabled = false;

            addEmployee.Enabled = false;
            changeEmployee.Enabled = false;
            removeEmployee.Enabled = false;

            addPhone.Enabled = false;
            changePhone.Enabled = false;
            removePhone.Enabled = false;
            statPhoneButton.Enabled = false;
            */
        }
       
        
        Department _data;
        public Department CompanyStructure
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
                FillTreeView(departmentView);
                FillTreeView(employeeDepartmentView);
                FillTreeView(phoneDepartmentView);
            }
        }

        #region FillDepartmentView
        void FillTreeView(TreeView tree)
        {
            if (_data != null)
            {
                var rootNode = CreateNode(_data);
                if (rootNode != null)
                {
                    tree.Nodes.Add(rootNode);
                }
            }
        }

        TreeNode CreateNode(Department department)
        {
            if (department != null)
            {
                TreeNode node = new TreeNode();
                node.Text = department.Name;
                node.Tag = department;
                foreach (var subDepartment in department.SubordinateDepartments)
                {
                    var subNode = CreateNode(subDepartment);
                    if (subNode != null)
                    {
                        node.Nodes.Add(subNode);
                    }
                }

                return node;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region FillEmployeeView

        #endregion

        #region DepartmentViewMethods
        public event DepartmentCreateDelegate DepartmentCreateCalled;
        public event DepartmentUpdateDelegate DepartmentDeleteCalled;
        public event DepartmentUpdateDelegate DepartmentUpdateCalled;

        private void addDepartment_Click(object sender, EventArgs e)
        {
            if (DepartmentCreateCalled != null)
            {
                var current = (Department)departmentView.SelectedNode?.Tag;
                var args = new DepartmentCreateArgs(current);
                DepartmentCreateCalled(args);
            }
        }

        private void changeDepartment_Click(object sender, EventArgs e)
        {
            if (DepartmentUpdateCalled != null)
            {
                var current = (Department)departmentView.SelectedNode?.Tag;
                var args = new DepartmentUpdateArgs(current);
                DepartmentUpdateCalled(args);
            }
        }

        private void removeDepartment_Click(object sender, EventArgs e)
        {
            if (DepartmentDeleteCalled != null)
            {
                var current = (Department)departmentView.SelectedNode?.Tag;
                var args = new DepartmentUpdateArgs(current);
                DepartmentDeleteCalled(args);
            }
        }

        private void departmentView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var current = (Department)departmentView.SelectedNode.Tag;
            if (current == null)
            {
                addDepartment.Enabled = false;
            }
            else
            {
                addDepartment.Enabled = true;
            }
        }

        private void departmentView_MouseUp(object sender, MouseEventArgs e)
        {
            var current = (Department)departmentView.SelectedNode.Tag;
            if (current == null)
            {
                addDepartment.Enabled = false;
            }
            else
            {
                addDepartment.Enabled = true;
            }
        }
        #endregion

        #region EmployeeViewMethods
        public event EmployeeCreateDelegate EmployeeCreateCalled;
        public event EmployeeUpdateDelegate EmployeeDeleteCalled;
        public event EmployeeUpdateDelegate EmployeeUpdateCalled;

        private void addEmployee_Click(object sender, EventArgs e)
        {
            if (EmployeeCreateCalled != null)
            {
                var currentDepartment = (Department)employeeDepartmentView.SelectedNode.Tag;
                EmployeeCreateCalled(new EmployeeCreateArgs(currentDepartment));
            }
        }

        private void changeEmployee_Click(object sender, EventArgs e)
        {
            if (EmployeeUpdateCalled != null)
            {
                var currentEmployee = (Employee)employeeSource.Current;
                EmployeeUpdateCalled(new EmployeeUpdateArgs(currentEmployee));
            }
        }

        private void removeEmployee_Click(object sender, EventArgs e)
        {
            if (EmployeeDeleteCalled != null)
            {
                var currentEmployee = (Employee)employeeSource.Current;
                EmployeeDeleteCalled(new EmployeeUpdateArgs(currentEmployee));
            }
        }

        private void employeeDepartmentView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var department = (Department)e.Node?.Tag;
            if (department == null)
            {
                addDepartment.Enabled = false;
            }
            else
            {
                addDepartment.Enabled = true;
            }
        }

        private void employeeDepartmentView_MouseUp(object sender, MouseEventArgs e)
        {
            var currentDepartment = (Department)employeeDepartmentView.SelectedNode.Tag;
            if (currentDepartment == null)
            {
                addEmployee.Enabled = false;
            }
            else
            {
                addEmployee.Enabled = true;
            }
        }

        private void employeeTable_SelectionChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region PhoneViewMethods
        public event PhoneCreateDelegate PhoneCreateCalled;
        public event PhoneUpdateDelegate PhoneDeleteCalled;
        public event PhoneUpdateDelegate PhoneUpdateCalled;


        private void addPhone_Click(object sender, EventArgs e)
        {

        }

        private void changePhone_Click(object sender, EventArgs e)
        {

        }

        private void removePhone_Click(object sender, EventArgs e)
        {

        }

        #endregion

        void IView.Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        
    }
}
