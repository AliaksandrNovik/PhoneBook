using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.AppController;

namespace UI.Basics
{
    public interface IDialogView : IView
    {
        event Action Confirmed;
        event Action Canceled;
    }
}
