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
            this.searchButton = new System.Windows.Forms.Button();
            this.phoneTable = new System.Windows.Forms.DataGridView();
            this.selfStatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchLine = new System.Windows.Forms.TextBox();
            this.statisticStrip = new System.Windows.Forms.MenuStrip();
            this.phoneSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTable)).BeginInit();
            this.statisticStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(618, 34);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 26);
            this.searchButton.TabIndex = 8;
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
            this.phoneTable.Location = new System.Drawing.Point(12, 64);
            this.phoneTable.Name = "phoneTable";
            this.phoneTable.RowTemplate.Height = 24;
            this.phoneTable.Size = new System.Drawing.Size(756, 256);
            this.phoneTable.TabIndex = 7;
            // 
            // selfStatToolStripMenuItem
            // 
            this.selfStatToolStripMenuItem.Name = "selfStatToolStripMenuItem";
            this.selfStatToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.selfStatToolStripMenuItem.Text = "Личная статистика";
            // 
            // searchLine
            // 
            this.searchLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLine.Location = new System.Drawing.Point(12, 36);
            this.searchLine.Name = "searchLine";
            this.searchLine.Size = new System.Drawing.Size(600, 22);
            this.searchLine.TabIndex = 6;
            // 
            // statisticStrip
            // 
            this.statisticStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statisticStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selfStatToolStripMenuItem});
            this.statisticStrip.Location = new System.Drawing.Point(0, 0);
            this.statisticStrip.Name = "statisticStrip";
            this.statisticStrip.Size = new System.Drawing.Size(780, 28);
            this.statisticStrip.TabIndex = 5;
            this.statisticStrip.Text = "menuStrip1";
            // 
            // phoneSource
            // 
            this.phoneSource.DataSource = typeof(UI.EmployeeUI.PhoneWrapItem);
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
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 332);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.phoneTable);
            this.Controls.Add(this.searchLine);
            this.Controls.Add(this.statisticStrip);
            this.Name = "EmployeeForm";
            this.Text = "Телефонная книга";
            ((System.ComponentModel.ISupportInitialize)(this.phoneTable)).EndInit();
            this.statisticStrip.ResumeLayout(false);
            this.statisticStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView phoneTable;
        private System.Windows.Forms.ToolStripMenuItem selfStatToolStripMenuItem;
        private System.Windows.Forms.TextBox searchLine;
        private System.Windows.Forms.MenuStrip statisticStrip;
        private System.Windows.Forms.BindingSource phoneSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
    }
}