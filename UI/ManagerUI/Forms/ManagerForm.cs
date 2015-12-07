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

namespace UI.ManagerUI
{
    public partial class ManagerForm : Form
    {
        private IAdminService _adminService = new AdminService();
        private IReadOnlyDepartmentService _departmentService = new DepartmentService();

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
            departmentViewForPhones.Nodes.Add((TreeNode)rootNode.Clone());
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

        }

        private void employeeSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
