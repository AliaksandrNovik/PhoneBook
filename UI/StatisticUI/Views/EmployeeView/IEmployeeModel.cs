using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Views
{
    public delegate void UpdateEventHandler();

    public interface IEmployeeModel
    {
        ICollection<IEmployeeViewItem> Items
        {
            get; set;
        }

        event UpdateEventHandler Updated;
    }
}
