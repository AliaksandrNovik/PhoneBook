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
    public partial class EditDepartmentForm : Form
    {
        public EditDepartmentForm()
        {
            InitializeComponent();
        }

        public string DepartmentName
        {
            get
            {
                return this.nameLine.Text;
            }
            set
            {
                this.nameLine.Text = value;
            }
        }

        public void ShowError(string msg)
        {
            MessageBox.Show(this, msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
