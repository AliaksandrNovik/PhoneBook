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
    public partial class EditEmployeeForm : Form
    {
        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        #region properties
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
                return this.birthDay.Text;
            }
            set
            {
                this.birthDay.Text = value;
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
