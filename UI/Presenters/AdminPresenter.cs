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
    public class AdminPresenter : BasePresener<IAdminView>
    {
        public AdminPresenter(IApplicationController controller, IAdminView view, IAdminService service) :
            base(controller, view)
        { }
    }
}
