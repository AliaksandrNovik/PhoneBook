using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UI.AppController;


namespace UI.Views
{
    public interface IPhoneBookView : IView
    {
        event Action OwnStatisticCallEvent;
    }
}
