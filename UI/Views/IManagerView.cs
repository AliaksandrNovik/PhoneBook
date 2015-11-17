using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.AppController;
namespace UI.View
{
    public interface IManagerView: IView
     {
        event Action addEmployee;
        event Action deleteEmployee;
        event Action editEmployee;
    }
}
