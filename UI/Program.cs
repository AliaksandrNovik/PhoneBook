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
using UI.Views;
using UI.Basics;

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

            /*var controller = new ApplicationController(new LightInjectAdapder());
            controller.RegisterView<ILoginView, LoginForm>()
                .RegisterService<ILoginService, DummyLogin>()
                .RegisterInstance(new ApplicationContext())
                .RegisterView<IEmployeeView, EmployeeForm>()
                .RegisterService<IEmployeeService, DummyEmployeeService>()
                .RegisterView<IAdminView, AdminForm>()
                .RegisterService<IAdminService, DummyAdminService>()
                .RegisterView<IManagerView, ManagerForm>()
                .RegisterService<IManagerService, DummyManagerService>();

            controller.Run<LoginPresenter>();*/
            #region TEST_PHONE_STAT
            var form = new PhoneStatisticForm(new ApplicationContext());
            form.Phone = "+375447174032";
            form.Employee = "Вусик Кирилл Владимирович";
            form.Department = "Отдел маркетинга";

            IList<StatisticItem> calls = new List<StatisticItem>();
            for (int i = 0; i < 100; ++i)
            {
                StatisticItem item = new StatisticItem(DateTime.Now, 3, "+375443337722", 58, 15);
                calls.Add(item);
            }
            form.PhoneCalls = new ReadOnlyCollection<StatisticItem>(calls);

            form.Show();
            calls.Insert(0, new StatisticItem(DateTime.Now, 15, "Fuck!", 58, 15));
            form.PhoneCalls = new ReadOnlyCollection<StatisticItem>(calls);
            #endregion
            Application.Run();
            
        }
    }
}
