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

namespace UI.LoginUI
{
    public partial class LoginForm : Form
    {
        private ApplicationContext _context;
        private readonly ILoginService _service;
        public LoginForm(ILoginService service, ApplicationContext context)
        {
            _service = service;
            _context = context;
            InitializeComponent();
        }

        public string Password
        {
            get
            {
                return passwordLine.Text;
            }
        }

        public string Login
        {
            get
            {
                return loginLine.Text;
            }
        }
        
        public void Run()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        private void ShowError(string errorMessage)
        {
            MessageBox.Show(this, errorMessage, "Вход", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var login = loginLine.Text;
            var password = passwordLine.Text;
            if (string.IsNullOrEmpty(login))
            {
                ShowError("Введите логин!");
            }
            else if (string.IsNullOrEmpty(password))
            {
                ShowError("Введите пароль!");

            }
            else
            {
                var userInfo = _service.Login(login, password);
                if (userInfo == null)
                {
                    ShowError("Неправильная пара логин-пароль");
                }
                else
                {
                    Form form = null;
                    switch (userInfo.Type)
                    {
                        case UserType.Admin:
                            form = new AdminUI.AdminForm();
                            break;
                        case UserType.Employee:
                            form = new EmployeeUI.EmployeeForm(userInfo.UserId);
                            break;
                        case UserType.Manager:
                            form = new ManagerUI.ManagerForm(userInfo.UserId);
                            break;
                    }
                    if (form != null)
                    {
                        this.Hide();
                        form.Show();
                        form.FormClosing += (closeSender, closeArgs) =>
                         { this.Show(); };
                    }
                }
            }
        }
    }
}
