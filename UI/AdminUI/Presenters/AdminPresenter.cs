using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.AppController;

namespace UI.AdminUI
{
    class AdminPresenter : BasePresener<IAdminPassiveView>
    {
        public AdminPresenter(IApplicationController controller, IAdminPassiveView view) : base(controller, view)
        {}
    }
}
