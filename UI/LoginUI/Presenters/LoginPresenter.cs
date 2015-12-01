using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.AppController;
using Services.Facade;

namespace UI.LoginUI
{
    public class LoginPresenter : BasePresener<ILoginView>
    {
        private readonly ILoginService _service;
        public LoginPresenter(IApplicationController controller, ILoginView view, ILoginService service) : base(controller, view)
        {
            _service = service;
            this.View.SubmitPressed += () => LoggedIn();
        }

        private void LoggedIn()
        {
            var userInfo = _service.Login(View.Login, View.Password);
            if (userInfo != null)
            {
                var userId = userInfo.UserId;
                View.Close();
                switch (userInfo.Type)
                {
                    case UserType.Admin:

                        break;
                    case UserType.Employee:
                        this.Controller.Run<UI.EmployeeUI.EmployeePresenter, EntityId>(userId);
                        break;
                    case UserType.Manager:
                        break;
                }

            }
            else
            {
                this.View.ShowError("Неверный логин и/или пароль");
            }
        }
    }
}
