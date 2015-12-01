using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UI.AppController;

namespace UI.Views
{
    /// <summary>
    /// declares "read-only" interfaces for employees
    /// </summary>
    public interface IEmployeeView : IView
    {
        event Action PersonalStatistic;

        void SetData(IEmployeeModel viewItems);

        void SetPersonalStatistic(PersonalStatistc) 
    }
}
