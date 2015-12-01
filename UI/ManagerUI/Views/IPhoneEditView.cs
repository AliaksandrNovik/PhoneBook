using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Basics;

namespace UI.ManagerUI
{
    public interface IPhoneEditView : IDialogView
    {
        Phone Phone
        { get; set; }

        Department Department
        { set; }
    }
}
