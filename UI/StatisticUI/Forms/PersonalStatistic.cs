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
using Novacode;
using System.Diagnostics;

using System.IO;


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
                departmentLine.Text = value;
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

        private void toWord_Click(object sender, EventArgs e)
        {
            string fileName = "Report.docx";
            if (File.Exists(fileName))
            {
                try
                {
                    File.Delete(fileName);
                }
                catch
                {

                }
            }
            var doc = DocX.Create(fileName);
            doc.InsertParagraph("Телефон: " + Phone);
            doc.InsertParagraph("Сотрудник: " + Employee);
            doc.InsertParagraph("Подразделение: " + Department);

            List<string> headers = new List<string>();
            foreach (DataGridViewColumn column in phoneStatTable.Columns)
            {
                headers.Add(column.HeaderText);
            }

            var statList = (IReadOnlyCollection<ICallSession>)statSource.DataSource;
            Table t = doc.AddTable(statList.Count + 1, headers.Count);
            int currentRow = 0;
            for (int cellIndex = 0; cellIndex < headers.Count; ++cellIndex)
            {
                t.Rows[0].Cells[cellIndex].Paragraphs.First().Append(headers[cellIndex]);
            }
            ++currentRow;

            foreach (var phone in statList)
            {
                t.Rows[currentRow].Cells[0].Paragraphs.First().Append(phone.DateAndTime.ToString());
                t.Rows[currentRow].Cells[1].Paragraphs.First().Append(phone.TargetPhone);
                t.Rows[currentRow].Cells[2].Paragraphs.First().Append(phone.DurationInSeconds.ToString());
                t.Rows[currentRow].Cells[3].Paragraphs.First().Append(phone.PricePerMinute.ToString());
                t.Rows[currentRow].Cells[4].Paragraphs.First().Append(phone.TotalPrice.ToString());
                ++currentRow;
            }
            doc.InsertTable(t);
            doc.Save();

            Process.Start("WINWORD.EXE", fileName);
        }
    }
}
