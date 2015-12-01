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
    public partial class AdminUserEditForm : Form, IAdminUserEditView
    {
        private readonly ApplicationContext _context;
        public AdminUserEditForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        UserInfo _info;
        public UserInfo User
        {
            get
            {
                _info.Login = loginLine.Text;
                _info.Password = loginLine.Text;
                return _info;
            }
            set
            {
                _info = value;
                loginLine.Text = _info.Login;
                loginLine.Text = _info.Password;
            }
        }      

        public void SetError(string msg)
        {
            MessageBox.Show(this, msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //buttons
        //
        public event Action Canceled;
        public event Action Confirmed;
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (Confirmed != null)
            {
                Confirmed();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (Canceled != null)
            {
                Canceled();
            }
        }
    }
}
