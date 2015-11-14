using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class PhoneBook : UserControl
    {
        public PhoneBook()
        {
            InitializeComponent();
        }
        public void SetTableData(DataTable dataTable)
        {
            phonesTable.DataSource = dataTable;
        }
    }
}
