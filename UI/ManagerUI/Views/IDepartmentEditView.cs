using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Basics;

namespace UI.ManagerUI
{
    public interface IDepartmentEditView : IDialogView
    {
        Department Department
        { get; set; }
    }
}
