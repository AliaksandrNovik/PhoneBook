﻿using System;
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
        private IAdminService _adminService = new AdminService();
        private IStatisticService _statService = new StatisticService();

        private string _employeeName;
        private string _departmentName;
        public EmployeeForm(string userId)
        {
            InitializeComponent();

            //all phones
            var phoneWraps = ReadData();
            phoneSource.DataSource = phoneWraps;
            phoneSource.ResetBindings(false);

            //personal
            var employeeUser = _adminService.GetEmployeeUserById(userId);
            var employeeId = employeeUser.EmployeeId;
            FillPersonalPhones(employeeUser.EmployeeId);
            statisticButton.Enabled = false;

            var employee = _employeeService.GetEmployeeById(employeeId);
            _employeeName = employee.LastName + " " + employee.FirstName + " " + employee.Patronym;

            var department = _departmentService.GetById(employee.DepartmentId);
            _departmentName = department.Name;
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


        private void FillPersonalPhones(string employeeId)
        {
            foreach (var phone in _phoneService.GetByEmployeeId(employeeId))
            {
                var treeNode = new TreeNode(phone.Number);
                treeNode.Tag = phone;
                phonesList.Nodes.Add(treeNode);
            }
        }

        private void phonesList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            statisticButton.Enabled = true;
        }

        private void allPhonesTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allPhonesTab.SelectedIndex == 0)
            {
                phoneTable.Focus();
            }
            else
            {
                phonesList.Focus();
            }
        }

        private void statisticButton_Click(object sender, EventArgs e)
        {
            var statForm = new UI.StatisticUI.Forms.PersonalStatistic();
            var currentPhone = (IPhone)phonesList.SelectedNode.Tag;
            statForm.Phone = currentPhone.Number;
            statForm.Employee = _employeeName;
            statForm.Department = _departmentName;
            statForm.Items = _statService.GetByPhoneId(currentPhone.Id);
            statForm.Show();
        }

        private void searchButton_Click_1(object sender, EventArgs e)
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
