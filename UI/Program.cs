using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

using UI.Forms;
using UI.AppController;

using UI.AdminUI;
using UI.EmployeeUI;
using UI.ManagerUI;
using UI.LoginUI;
using UI.Views;
using UI.Basics;
using Services.Facade;

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
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new ApplicationController(new LightInjectAdapder());
            controller.RegisterView<IEmployeeView, EmployeeForm>()
                .RegisterView<ILoginView, LoginForm>()
                .RegisterView<IManagerPassiveView, ManagerForm>()
            .RegisterInstance(new ApplicationContext())
            .RegisterService<ILoginService, LoginService>()
            .RegisterService<IReadOnlyPhoneService, PhoneService>()
             .RegisterService<IReadOnlyDepartmentService, DepartmentService>()
             .RegisterService<IReadOnlyEmployeeService, EmployeeService>();

            controller.Run<ManagerPresenter, Services.Facade.String>(null);                        
        }
    }
}
