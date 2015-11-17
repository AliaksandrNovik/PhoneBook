using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UI.AppController;
using UI.View;
using Services.Interfaces;
using UI.Forms;

namespace UI.Presenters
{
    public class LoginPresenter : BasePresener<ILoginView>
    {
        private readonly ILoginService _service;

        public LoginPresenter(IApplicationController controller, ILoginView view, ILoginService service):
            base(controller, view)
        {
            _service = service;

            View.Submit += () => ProcessSubmit(View.Login, View.Password);
        }

        private void ProcessSubmit(string login, string password)
        {
            //TODO set next window
            View.Close();
            var form = new EmployeeForm();
            form.Show();
        }
    }
}
