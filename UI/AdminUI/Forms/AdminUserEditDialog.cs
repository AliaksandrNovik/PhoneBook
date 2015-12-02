using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.AdminUI
{
    public partial class AdminUserEditDialog : Form
    {
        public AdminUserEditDialog()
        {
            InitializeComponent();
        }

        public EventHandler SubmitCalled;

        public string Login
        {
            get
            {
                return loginLine.Text;
            }
            set
            {
                loginLine.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return passwordLine.Text;
            }
            set
            {
                passwordLine.Text = value;
            }
        }

        public void ShowError(string msg)
        {
            MessageBox.Show(this, msg, "Войти", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
           // this.DialogResult = DialogResult.OK;
            if (SubmitCalled != null)
            {
                SubmitCalled(this, e);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
