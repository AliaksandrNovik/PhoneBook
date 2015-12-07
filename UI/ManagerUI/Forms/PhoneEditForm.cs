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

namespace UI.ManagerUI
{
    public partial class PhoneEditForm : Form
    {
        class ComboBoxWrap
        {
            public ComboBoxWrap()
            { }

            public ComboBoxWrap(IEmployee item)
            {
                this.Item = item;

            }

            public string Name
            {
                get
                {
                    if (Item != null)
                    {
                        return Item.FirstName
                        + " " + Item.LastName
                        + " " + Item.Patronym
                        + ", " + Item.Place;
                    }
                    else
                    {
                        return "(не задан)";
                    }
                }
            }

            public IEmployee Item
            { get; set; }
        }

        public PhoneEditForm(IReadOnlyCollection<IEmployee> employees)
        {
            InitializeComponent();

            List<ComboBoxWrap> comboBoxItemList = new List<ComboBoxWrap>();
            foreach (var employee in employees)
            {
                comboBoxItemList.Add(new ComboBoxWrap(employee));
            }
            comboBoxItemList.Insert(0, new ComboBoxWrap());

            employeeComboBox.DataSource = comboBoxItemList;
            employeeComboBox.DisplayMember = "Name";
        }

        public string Phone
        {
            get
            {
                return this.phoneBox.Text;
            }
            set
            {
                this.phoneBox.Text = Phone;
            }
        }

        public IEmployee CurrentEmployee
        {
            get
            {
                if (employeeComboBox.SelectedIndex == 0)
                {
                    return null;
                }
                else
                {
                    var employee = (ComboBoxWrap)employeeComboBox.SelectedItem;
                    return employee.Item;
                }
            }
            set
            {
                int currentIndex = 0;
                int index = 0;
                foreach (object wrap in employeeComboBox.Items)
                {
                    if (index == 0)
                    {
                        index++;
                        continue;
                    }

                    var comboBoxWrap = (ComboBoxWrap)wrap;
                    if (comboBoxWrap.Item == value)
                    {
                        currentIndex = index;
                        break;
                    }
                }

                employeeComboBox.SelectedIndex = currentIndex;
            }
        }

        public void ShowError(string msg)
        {
            MessageBox.Show(this, msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public EventHandler Confirmed;
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (Confirmed != null)
            {
                Confirmed(this, e);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
