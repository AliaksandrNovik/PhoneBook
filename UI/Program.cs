using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using UI.Forms;
using UI.AppController;

using UI.View;
using UI.Presenters;
using Services.Interfaces;

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

            var controller = new ApplicationController(new LightInjectAdapder());
            controller.RegisterView<ILoginView, LoginForm>()
                .RegisterService<ILoginService, DummyLogin>()
                .RegisterInstance(new ApplicationContext());

            controller.Run<LoginPresenter>();
        }
    }
}
