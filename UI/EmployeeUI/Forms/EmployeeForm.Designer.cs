namespace UI.EmployeeUI
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.allPhonesTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.searchButton = new System.Windows.Forms.Button();
            this.phoneTable = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchLine = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.adminTable = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.statisticButton = new System.Windows.Forms.Button();
            this.phonesList = new System.Windows.Forms.TreeView();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneSource = new System.Windows.Forms.BindingSource(this.components);
            this.allPhonesTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.adminTable.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneSource)).BeginInit();
            this.SuspendLayout();
            // 
            // allPhonesTab
            // 
            this.allPhonesTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allPhonesTab.Controls.Add(this.tabPage1);
            this.allPhonesTab.Controls.Add(this.tabPage2);
            this.allPhonesTab.Location = new System.Drawing.Point(12, 12);
            this.allPhonesTab.Name = "allPhonesTab";
            this.allPhonesTab.SelectedIndex = 0;
            this.allPhonesTab.Size = new System.Drawing.Size(915, 437);
            this.allPhonesTab.TabIndex = 0;
            this.allPhonesTab.SelectedIndexChanged += new System.EventHandler(this.allPhonesTab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.searchButton);
            this.tabPage1.Controls.Add(this.phoneTable);
            this.tabPage1.Controls.Add(this.searchLine);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Все телефоны";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(751, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 26);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // phoneTable
            // 
            this.phoneTable.AllowUserToAddRows = false;
            this.phoneTable.AllowUserToDeleteRows = false;
            this.phoneTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTable.AutoGenerateColumns = false;
            this.phoneTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phoneTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneDataGridViewTextBoxColumn,
            this.FullName,
            this.BirthDate,
            this.placeDataGridViewTextBoxColumn,
            this.Department});
            this.phoneTable.DataSource = this.phoneSource;
            this.phoneTable.Location = new System.Drawing.Point(6, 34);
            this.phoneTable.Name = "phoneTable";
            this.phoneTable.RowTemplate.Height = 24;
            this.phoneTable.Size = new System.Drawing.Size(895, 368);
            this.phoneTable.TabIndex = 10;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Дата рождения";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Подразделение";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // searchLine
            // 
            this.searchLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLine.Location = new System.Drawing.Point(6, 6);
            this.searchLine.Name = "searchLine";
            this.searchLine.Size = new System.Drawing.Size(739, 22);
            this.searchLine.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.adminTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Личные телефоны";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // adminTable
            // 
            this.adminTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminTable.ColumnCount = 1;
            this.adminTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.adminTable.Controls.Add(this.flowLayoutPanel5, 0, 1);
            this.adminTable.Controls.Add(this.phonesList, 0, 0);
            this.adminTable.Location = new System.Drawing.Point(6, 6);
            this.adminTable.Name = "adminTable";
            this.adminTable.RowCount = 2;
            this.adminTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.adminTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.adminTable.Size = new System.Drawing.Size(898, 396);
            this.adminTable.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel5.Controls.Add(this.statisticButton);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 349);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(892, 44);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // statisticButton
            // 
            this.statisticButton.AutoSize = true;
            this.statisticButton.Location = new System.Drawing.Point(3, 3);
            this.statisticButton.Name = "statisticButton";
            this.statisticButton.Size = new System.Drawing.Size(94, 27);
            this.statisticButton.TabIndex = 3;
            this.statisticButton.Text = "Статистика";
            this.statisticButton.UseVisualStyleBackColor = true;
            this.statisticButton.Click += new System.EventHandler(this.statisticButton_Click);
            // 
            // phonesList
            // 
            this.phonesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phonesList.HideSelection = false;
            this.phonesList.Location = new System.Drawing.Point(3, 3);
            this.phonesList.Name = "phonesList";
            this.phonesList.Size = new System.Drawing.Size(892, 340);
            this.phonesList.TabIndex = 5;
            this.phonesList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.phonesList_AfterSelect);
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Тел. номер";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneSource
            // 
            this.phoneSource.DataSource = typeof(UI.EmployeeUI.PhoneWrapItem);
            // 
            // EmployeeForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 461);
            this.Controls.Add(this.allPhonesTab);
            this.Name = "EmployeeForm";
            this.Text = "Телефонная книга";
            this.allPhonesTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.adminTable.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource phoneSource;
        private System.Windows.Forms.TabControl allPhonesTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView phoneTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.TextBox searchLine;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel adminTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button statisticButton;
        private System.Windows.Forms.TreeView phonesList;
    }
}