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
            this.phoneSource = new System.Windows.Forms.BindingSource(this.components);
            this.allPhonesTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.searchButton = new System.Windows.Forms.Button();
            this.phoneTable = new System.Windows.Forms.DataGridView();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchLine = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.phoneSource)).BeginInit();
            this.allPhonesTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTable)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneSource
            // 
            this.phoneSource.DataSource = typeof(UI.EmployeeUI.PhoneWrapItem);
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
            this.allPhonesTab.Size = new System.Drawing.Size(930, 470);
            this.allPhonesTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.searchButton);
            this.tabPage1.Controls.Add(this.phoneTable);
            this.tabPage1.Controls.Add(this.searchLine);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(922, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Все телефоны";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(922, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Личные телефоны";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(766, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 26);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
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
            this.phoneTable.Size = new System.Drawing.Size(910, 401);
            this.phoneTable.TabIndex = 10;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Тел. номер";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
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
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.searchLine.Size = new System.Drawing.Size(754, 22);
            this.searchLine.TabIndex = 9;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 494);
            this.Controls.Add(this.allPhonesTab);
            this.Name = "EmployeeForm";
            this.Text = "Телефонная книга";
            ((System.ComponentModel.ISupportInitialize)(this.phoneSource)).EndInit();
            this.allPhonesTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTable)).EndInit();
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
    }
}