using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Basics;

namespace UI.EmployeeUI
{
    public interface IEmployeeView : IPassiveCompanyStructView
    {
        event Action OwnStatisticCalled;

        void ShowError(string msg);
    }
}
