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

namespace UI.ManagerUI
{
    public partial class EditEmployeeUserForm : Form
    {
        public EditEmployeeUserForm()
        {
            InitializeComponent();
            userAvailable.Checked = false;
            loginBox.Enabled = IsUserAvailable;
            passwordBox.Enabled = IsUserAvailable;
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

        #region employee
        public string FirstName
        {
            get
            {
                return this.firstName.Text;
            }
            set
            {
                this.firstName.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName.Text;
            }
            set
            {
                this.lastName.Text = value;
            }
        }

        public string Patronym
        {
            get
            {
                return this.patronymName.Text;
            }
            set
            {
                this.patronymName.Text = value;
            }
        }

        public string Birthday
        {
            get
            {
                return this.birthday.Text;
            }
            set
            {
                this.birthday.Text = value;
            }
        }

        public string Place
        {
            get
            {
                return this.place.Text;
            }
            set
            {
                this.place.Text = value;
            }
        }
        #endregion

        public bool IsUserAvailable
        {
            get
            {
                return userAvailable.Checked;
            }
            set
            {
                userAvailable.Checked = value;
            }
        }

        private void userAvailable_CheckedChanged(object sender, EventArgs e)
        {
            bool IsUserAvailable = userAvailable.Checked;
            loginBox.Enabled = IsUserAvailable;
            passwordBox.Enabled = IsUserAvailable;
        }

        public event EventHandler Confirmed;

        public void ShowError(string msg)
        {
            MessageBox.Show(this, msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

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
