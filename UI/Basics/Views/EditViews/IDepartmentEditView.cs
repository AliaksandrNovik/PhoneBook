using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Basics
{
    public interface IDepartmentEditView : IDialogView
    {
        Department Department
        { get; set; }
    }
}
