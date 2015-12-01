using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Basics;

namespace UI.ManagerUI
{
    public partial class EmployeeEditForm : Form, IEmployeeEditView
    {
        public EmployeeEditForm()
        {
            InitializeComponent();
        }

        public Employee Employee
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public event Action Canceled;
        public event Action Confirmed;
    }
}
