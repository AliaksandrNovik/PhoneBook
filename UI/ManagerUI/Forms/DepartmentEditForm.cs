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
    public partial class DepartmentEditForm : Form, IDepartmentEditView
    {
        public DepartmentEditForm()
        {
            InitializeComponent();
        }

        private Department _department;
        public Department Department
        {
            get
            {
                if (_department != null)
                {
                    _department.Head = null;
                    _department.Name = nameLine.Text;
                    var currentIndex = this.employeeComboBox.SelectedIndex;
                    if (_employeeMap.ContainsKey(currentIndex))
                    {
                        _department.Head = _employeeMap.Values.First();
                    }
                }
                return _department;
            }

            set
            {
                _department = value;
                this.nameLine.Text = _department?.Name;
            }
        }

        private Dictionary<int, Employee> _employeeMap;
        private void FillComboBox()
        {
            _employeeMap.Clear();
            this.employeeComboBox.Items.Clear();
            this.employeeComboBox.Items.Insert(0, "(Нет)");

            int index = 1;
            int currentIndex = 0;
            var employeeList = _department?.Employees;
            if (employeeList != null)
            {
                var head = _department.Head;
                foreach (var employee in employeeList)
                {
                    _employeeMap.Add(index, employee);
                    this.employeeComboBox.Items.Add(employee.GetFullName());
                    if (head != null)
                    {
                        if (head.Equals(employee))
                        {
                            currentIndex = index;
                        }
                    }
                    ++index;
                }
             }
            this.employeeComboBox.SelectedIndex = currentIndex;
        }

        public event Action Confirmed;
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (Confirmed != null)
            {
                Confirmed();
            }
        }

        public event Action Canceled;
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (Canceled != null)
            {
                Canceled();
            }
        }
    }
}
