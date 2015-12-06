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
    public partial class UserEditDialog : Form
    {
        public UserEditDialog()
        {
            InitializeComponent();
        }

        public void ShowError(string msg)
        {
            MessageBox.Show(this, msg, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string Login
        {
            get
            {
                return loginBox.Text;
            }
            set
            {
                loginBox.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return passwordBox.Text; 
            }
            set
            {
                passwordBox.Text = value;
            }
        }

        public EventHandler Confirmed;
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (Confirmed != null)
            {
                Confirmed(this, e);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
