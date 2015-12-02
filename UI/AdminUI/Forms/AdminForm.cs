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
        }


        private void addDepartmentButton_Click(object sender, EventArgs e)
        {
            
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

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var adminUserDialog = new AdminUserEditDialog();
            adminUserDialog.SubmitCalled += (s, a) => Create(s, a);
            adminUserDialog.ShowDialog();
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
        /*
        void IView.Show()
        {
            
            base.Show();
        }
        */
    }
}
