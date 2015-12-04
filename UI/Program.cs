using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

using UI.LoginUI;
using BLL;
using BLL.Repository;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var context = new ApplicationContext();
            var loginForm = new LoginForm(new Services.Implementation.LoginService(), new ApplicationContext());
            loginForm.Show();            
        }
    }
}
