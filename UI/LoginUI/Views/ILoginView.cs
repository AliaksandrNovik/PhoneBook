using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.AppController;

namespace UI.Views
{
    public interface ILoginView : IView
    {
        string Login { get; }
        string Password { get; }

        event Action SubmitPressed;

        void ShowError(string errorMessage);
    }
}
