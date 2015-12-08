using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.Facade;

namespace UI.StatisticUI.Forms
{
    public partial class PersonalStatistic : Form
    {
        public PersonalStatistic()
        {
            InitializeComponent();
        }

        public string Phone
        {
            get
            {
                return phoneLine.Text;
            }
            set
            {
                phoneLine.Text = value;
            }
        }

        public string Department
        {
            get
            {
                return departmentLine.Text;
            }
            set
            {
                employeeLine.Text = value;
            }
        }

        public string Employee
        {
            get
            {
                return employeeLine.Text;
            }
            set
            {
                employeeLine.Text = value;
            }
        }

        public IReadOnlyCollection<ICallSession> Items
        {
            set
            {
                statSource.DataSource = value;
                statSource.ResetBindings(false);

                int total = 0;
                foreach (var phoneStat in value)
                {
                    total += phoneStat.TotalPrice;
                }
                summaryPrice.Text = total.ToString();
            }
        }
    }
}
