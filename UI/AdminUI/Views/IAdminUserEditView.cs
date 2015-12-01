using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Basics;

namespace UI.AdminUI
{
    public interface IAdminUserEditView : IUserEditView
    {
        UserInfo User
        { get; set; }
    }
}
