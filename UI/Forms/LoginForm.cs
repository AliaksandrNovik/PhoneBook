using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UI.View;

namespace UI.Forms
{
    public partial class LoginForm : Form, ILoginView
    {
        public LoginForm()
        {
            InitializeComponent();

            submitButton.Click += (sender, args) => Invoke(Submit);
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

        public event Action Submit;

        //TODO  
        public void ShowError(string errorMessage)
        {
            throw new NotImplementedException();
        }
    }
}
