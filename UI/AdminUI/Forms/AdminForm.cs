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

namespace UI.AdminUI
{
    public partial class AdminForm : Form, IAdminPassiveView
    {
        private readonly ApplicationContext _context;

        public AdminForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public event DepartmentCreateDelegate DepartmentCreateCalled;
        public event DepartmentUpdateDelegate DepartmentDeleteCalled;
        public event DepartmentUpdateDelegate DepartmentUpdateCalled;

        public event EmployeeCreateDelegate EmployeeCreateCalled;
        public event EmployeeUpdateDelegate EmployeeUpdateCalled;
        public event EmployeeUpdateDelegate EmployeeDeleteCalled;

        public event EventHandler AdminCreateCalled;
        public event AdminUserDelegate AdminDeleteCalled;
        public event AdminUserDelegate AdminUpdateCalled;

        public event CreationContextDelegate EmployeeUserCreateCalled;
        public event EmployeeUserDelegate EmployeeUserDeleteCalled;
        public event EmployeeUserDelegate EmployeeUserUpdateCalled;

        public event CreationContextDelegate ManagerUserCreateCalled;
        public event ManagerUserDelegate ManagerUserDeleteCalled;
        public event ManagerUserDelegate ManagerUserUpdateCalled;        

        private void addDepartmentButton_Click(object sender, EventArgs e)
        {
            if (DepartmentCreateCalled != null)
            {
                
            }
        }

        private void changeDepartmentButton_Click(object sender, EventArgs e)
        {

        }

        private void removeDepartmentButton_Click(object sender, EventArgs e)
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

        /*
        void IView.Show()
        {
            _context.MainForm = this;
            base.Show();
        }
        */
    }
}
