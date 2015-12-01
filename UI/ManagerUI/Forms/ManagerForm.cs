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
                FillDepartment();
            }
        }

        #region FillDepartmentView
        void FillDepartment()
        {
            if (_data != null)
            {
                var rootNode = CreateNode(_data);
                if (rootNode != null)
                {
                    departmentView.Nodes.Add(rootNode);
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

        #region DepartmentViewMethods
        public event DepartmentCreateDelegate DepartmentCreateCalled;
        public event DepartmentUpdateDelegate DepartmentDeleteCalled;
        public event DepartmentUpdateDelegate DepartmentUpdateCalled;

        private void addDepartment_Click(object sender, EventArgs e)
        {
            if (DepartmentCreateCalled != null)
            {
                var parent = GetCurrentParentDepartmentInDepartmentView();
                var args = new DepartmentCreateArgs(parent);
                DepartmentCreateCalled(args);
            }
        }

        private void changeDepartment_Click(object sender, EventArgs e)
        {
            if (DepartmentUpdateCalled != null)
            {
                var current = GetCurrentDepartmentInDepartmentView();
                var args = new DepartmentUpdateArgs(current);
                DepartmentUpdateCalled(args);
            }
        }

        private void removeDepartment_Click(object sender, EventArgs e)
        {
            if (DepartmentDeleteCalled != null)
            {
                var current = GetCurrentDepartmentInDepartmentView();
                var args = new DepartmentUpdateArgs(current);
                DepartmentDeleteCalled(args);
            }
        }

        private void departmentView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = e.Node;
            SetDepartment(node);
        }

        private void departmentView_MouseUp(object sender, MouseEventArgs e)
        {
            var node = departmentView.SelectedNode;
            SetDepartment(node);
        }

        private Department _currentParentDepartment;
        private Department GetCurrentParentDepartmentInDepartmentView()
        {
            return _currentParentDepartment;
        }

        private Department _currentDepartment;
        private Department GetCurrentDepartmentInDepartmentView()
        {
            return _currentDepartment;
        }

        private void SetDepartment(TreeNode node)
        {
            _currentDepartment = (Department)node?.Tag;
            _currentParentDepartment = (Department)node?.Tag;
            var head = _currentParentDepartment?.Head;
            if (head != null)
            {
                headName.Text = head.FirstName + " " + head.LastName + " " + head.Patronym;
                headPlace.Text = head.Place;
                headGroupBox.Visible = true;
            }
            else
            {
                headGroupBox.Visible = false;
            }
        }
        #endregion

        #region EmployeeViewMethods
        public event EmployeeCreateDelegate EmployeeCreateCalled;
        public event EmployeeUpdateDelegate EmployeeDeleteCalled;
        public event EmployeeUpdateDelegate EmployeeUpdateCalled;

        private void addEmployee_Click(object sender, EventArgs e)
        {

        }

        private void changeEmployee_Click(object sender, EventArgs e)
        {

        }

        private void removeEmployee_Click(object sender, EventArgs e)
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


    }
}
