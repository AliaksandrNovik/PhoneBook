using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UI.AppController;
using UI.Views;


namespace UI.Forms
{
    public partial class EmployeeForm : Form, IEmployeeView
    {
        private readonly ApplicationContext _context;

        public EmployeeForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        void IView.Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
