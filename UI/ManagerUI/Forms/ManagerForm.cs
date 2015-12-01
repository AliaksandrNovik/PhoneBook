using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UI.Views;
using UI.AppController;

namespace UI.ManagerUI
{
    public partial class ManagerForm : Form//, IManagerView
    {
        private readonly ApplicationContext _context;

        public ManagerForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        /*
        void IView.Show()
        {
            _context.MainForm = this;
            base.Show();
        }
        */
    }
}
