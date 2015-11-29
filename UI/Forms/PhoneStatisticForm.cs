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

namespace UI.Forms
{
    public partial class PhoneStatisticForm : Form, IPhoneStatisticView
    {
        private readonly ApplicationContext _context;
        public PhoneStatisticForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public string Department
        {
            set
            {
                departmentLine.Text = value;
            }
        }

        public string Employee
        {
            set
            {
                employeeLine.Text = value;
            }
        }

        public string Phone
        {
            set
            {
                phoneLine.Text = value;
            }
        }

        public IReadOnlyCollection<StatisticItem> PhoneCalls
        {
            set
            {
                phoneStatSource.DataSource = value;
            }
        }

        void IView.Show()
        {
            Application.Run(_context);
        }
    }
}
