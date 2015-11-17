using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UI.View;
namespace UI.Forms
{
    public partial class AdminForm : Form, IManagerView
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        event Action IManagerView.addEmployee
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action IManagerView.deleteEmployee
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action IManagerView.editEmployee
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        void IVew.Close()
        {
            throw new NotImplementedException();
        }

        void IVew.Show()
        {
            throw new NotImplementedException();
        }
    }
}
