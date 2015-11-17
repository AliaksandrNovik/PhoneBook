using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UI.AppController;
using UI.Views;
using Services.Interfaces;
using UI.Forms;

namespace UI.Presenters
{
    public class EmployeePresenter : BasePresener<IEmployeeView>
    {
        public EmployeePresenter(IApplicationController controller, IEmployeeView view, IEmployeeService service) :
            base(controller, view)
        {

        }
    }
}
