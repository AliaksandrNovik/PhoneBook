using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UI.AppController;

namespace UI.Basics
{
    public interface IPassiveCompanyStructView : IView
    {
        Department CompanyStructure //pass there root
        { get; set; }
    }
}
