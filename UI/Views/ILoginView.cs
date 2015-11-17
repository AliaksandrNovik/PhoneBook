using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.ApplicationController;

namespace UI.View
{
    public interface ILoginView : IView
    {
        string Login { get; }
        string Password { get; }

        //log in button is pressed
        event Action Submit;

        //TODO specify responsibility
        void ShowError(string errorMessage);
    }
}
