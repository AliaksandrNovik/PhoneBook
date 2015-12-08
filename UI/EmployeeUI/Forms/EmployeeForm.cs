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
using Services.Implementation;

namespace UI.EmployeeUI
{
    public partial class EmployeeForm : Form
    {
        private IReadOnlyDepartmentService _departmentService = new DepartmentService();
        private IReadOnlyEmployeeService _employeeService = new EmployeeService();
        private IReadOnlyPhoneService _phoneService = new PhoneService();

        public EmployeeForm(string userId)
        {
            InitializeComponent();
            var phoneWraps = ReadData();
            phoneSource.DataSource = phoneWraps;
            phoneSource.ResetBindings(false);
        }

        private List<PhoneWrapItem> ReadData()
        {
            List<PhoneWrapItem> phoneWraps = new List<PhoneWrapItem>();
            foreach (var phone in _phoneService.GetAll())
            {
                var departmentId = phone.DepartmentId;
                IDepartment department = null;
                if (departmentId != null)
                    department = _departmentService.GetById(departmentId);

                var employeeId = phone.EmployeeId;
                IEmployee employee = null;
                if (employeeId != null)
                    employee = _employeeService.GetEmployeeById(employeeId);


                var phoneWrap = new PhoneWrapItem(department, employee, phone);
                phoneWraps.Add(phoneWrap);
            }

            return phoneWraps;
        }

        private List<PhoneWrapItem> Filter(string text)
        {
            return ReadData().Where(x => x.Contains(text)).ToList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var textToSearch = searchLine.Text;
            if (string.IsNullOrWhiteSpace(textToSearch))
            {
                phoneSource.DataSource = ReadData();
                phoneSource.ResetBindings(false);
            }
            else
            {
                phoneSource.DataSource = Filter(textToSearch);
                phoneSource.ResetBindings(false);
            }
        }
    }
}
