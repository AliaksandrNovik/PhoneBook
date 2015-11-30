using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UI.AppController;
using UI.CompanyStructure.Entities;

namespace UI.CompanyStructure.Views
{
    public interface IPassiveCompanyStructView : IView
    {
        Department CompanyStructure //pass there root
        { get; set; }

        int MaxViewDepth//specify detailization of departments
        { get; set; }
    }
}
