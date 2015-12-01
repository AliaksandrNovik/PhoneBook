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

        private List<PhoneStatItemWrap> _items = new List<PhoneStatItemWrap>();
        public IReadOnlyCollection<StatisticItem> PhoneCalls
        {
            set
            {
                int sum = 0;
                _items.Clear();
                phoneStatSource.DataSource = _items;
                foreach (var newItem in value)
                {
                    _items.Add(new PhoneStatItemWrap(newItem));
                    sum += newItem.TotalPrice;
                }
                phoneStatSource.ResetBindings(false);

                summaryPrice.Text = sum.ToString();
            }
        }

        void IView.Show()
        {
            Application.Run(_context);
        }
    }
}
