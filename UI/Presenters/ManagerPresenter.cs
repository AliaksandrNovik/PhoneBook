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
    public class ManagerPresenter : BasePresener<IManagerView>
    {
        public ManagerPresenter(IApplicationController controller, IManagerView view, IManagerService service) :
            base(controller, view)
        {

        }
    }
}
