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
using UI.Basics;
using UI.Views;


namespace UI.EmployeeUI
{
    public partial class EmployeeForm : Form, IEmployeeView
    {
        private readonly ApplicationContext _context;
        public EmployeeForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        List<PhoneWrapItem> _phoneItems;
        Department _department;
        public Department CompanyStructure
        {
            get
            {
                return _department;
            }

            set
            {
                _department = value;
                ProcessDepartment(_department);
            }
        }

        private void ProcessDepartment(Department department)
        {
            if (department != null)
            {
                foreach (var phone in department.Phones)
                {
                    if (phone != null)
                    {
                        var phoneWrap = new PhoneWrapItem(phone, department);
                        _phoneItems.Add(phoneWrap);
                    }
                }

                foreach (var subDepartment in department.SubordinateDepartments)
                {
                    ProcessDepartment(subDepartment);
                }
            }
        }

        private void UpdateBindings(List<PhoneWrapItem> items)
        {
            phoneSource.DataSource = items;
            phoneSource.ResetBindings(false);
        }

        public event Action OwnStatisticCalled;

        private void selfStatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OwnStatisticCalled != null)
            {
                OwnStatisticCalled();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string value = searchLine.Text;
            if (value == null || value.Equals(""))
            {
                UpdateBindings(_phoneItems);
            }
            else
            {
                var filteredList = new List<PhoneWrapItem>();
                foreach (var item in _phoneItems)
                {
                    if (item != null)
                    {
                        if (item.ContainsValue(value))
                        {
                            filteredList.Add(item);
                        }
                    }
                }
                UpdateBindings(filteredList);
            }
        }

        public void ShowError(string msg)
        {
            throw new NotImplementedException();
        }

        /*void IView.Show()
        {
            _context.MainForm = this;
            base.Show();
        }
        */
    }
}
