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
    public partial class PhoneEditForm : Form, IPhoneEditView
    {
        public PhoneEditForm()
        {
            InitializeComponent();
        }

        public Department Department
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public Phone Phone
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
