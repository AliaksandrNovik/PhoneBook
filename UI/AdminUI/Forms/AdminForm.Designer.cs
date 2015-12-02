﻿namespace UI.AdminUI
{
    partial class AdminForm
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
            this.userTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.departmentGroupBox = new System.Windows.Forms.GroupBox();
            this.departmentView = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addDepartment = new System.Windows.Forms.Button();
            this.changeDepartment = new System.Windows.Forms.Button();
            this.removeDepartment = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.changeEmployee = new System.Windows.Forms.Button();
            this.removeEmployee = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Button();
            this.employeeGroupBox = new System.Windows.Forms.GroupBox();
            this.employeeTable = new System.Windows.Forms.DataGridView();
            this.removeDepartmentButton = new System.Windows.Forms.Button();
            this.changeDepartmentButton = new System.Windows.Forms.Button();
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.removeEmployeeButton = new System.Windows.Forms.Button();
            this.changeEmployeeButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Найти = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.departmentGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.employeeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userTab
            // 
            this.userTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTab.Controls.Add(this.tabPage1);
            this.userTab.Controls.Add(this.tabPage2);
            this.userTab.Location = new System.Drawing.Point(3, 15);
            this.userTab.Margin = new System.Windows.Forms.Padding(4);
            this.userTab.Name = "userTab";
            this.userTab.SelectedIndex = 0;
            this.userTab.Size = new System.Drawing.Size(836, 420);
            this.userTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.removeDepartmentButton);
            this.tabPage1.Controls.Add(this.changeDepartmentButton);
            this.tabPage1.Controls.Add(this.addDepartmentButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(828, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Структура компании";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(815, 377);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.departmentGroupBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(290, 371);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // departmentGroupBox
            // 
            this.departmentGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentGroupBox.Controls.Add(this.departmentView);
            this.departmentGroupBox.Location = new System.Drawing.Point(3, 3);
            this.departmentGroupBox.Name = "departmentGroupBox";
            this.departmentGroupBox.Size = new System.Drawing.Size(284, 315);
            this.departmentGroupBox.TabIndex = 1;
            this.departmentGroupBox.TabStop = false;
            this.departmentGroupBox.Text = "Структура подразделений";
            // 
            // departmentView
            // 
            this.departmentView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentView.HideSelection = false;
            this.departmentView.Location = new System.Drawing.Point(0, 21);
            this.departmentView.Name = "departmentView";
            this.departmentView.Size = new System.Drawing.Size(284, 294);
            this.departmentView.TabIndex = 0;
            this.departmentView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.departmentView_AfterSelect);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.addDepartment);
            this.flowLayoutPanel1.Controls.Add(this.changeDepartment);
            this.flowLayoutPanel1.Controls.Add(this.removeDepartment);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 324);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 44);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // addDepartment
            // 
            this.addDepartment.AutoSize = true;
            this.addDepartment.Location = new System.Drawing.Point(3, 3);
            this.addDepartment.Name = "addDepartment";
            this.addDepartment.Size = new System.Drawing.Size(82, 27);
            this.addDepartment.TabIndex = 0;
            this.addDepartment.Text = "Добавить";
            this.addDepartment.UseVisualStyleBackColor = true;
            this.addDepartment.Click += new System.EventHandler(this.addDepartment_Click);
            // 
            // changeDepartment
            // 
            this.changeDepartment.AutoSize = true;
            this.changeDepartment.Location = new System.Drawing.Point(91, 3);
            this.changeDepartment.Name = "changeDepartment";
            this.changeDepartment.Size = new System.Drawing.Size(82, 27);
            this.changeDepartment.TabIndex = 1;
            this.changeDepartment.Text = "Изменить";
            this.changeDepartment.UseVisualStyleBackColor = true;
            this.changeDepartment.Click += new System.EventHandler(this.changeDepartment_Click);
            // 
            // removeDepartment
            // 
            this.removeDepartment.AutoSize = true;
            this.removeDepartment.Location = new System.Drawing.Point(179, 3);
            this.removeDepartment.Name = "removeDepartment";
            this.removeDepartment.Size = new System.Drawing.Size(75, 27);
            this.removeDepartment.TabIndex = 2;
            this.removeDepartment.Text = "Удалить";
            this.removeDepartment.UseVisualStyleBackColor = true;
            this.removeDepartment.Click += new System.EventHandler(this.removeDepartment_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.employeeGroupBox, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(299, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(513, 371);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.removeEmployee);
            this.flowLayoutPanel2.Controls.Add(this.changeEmployee);
            this.flowLayoutPanel2.Controls.Add(this.addEmployee);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 324);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(507, 44);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // changeEmployee
            // 
            this.changeEmployee.AutoSize = true;
            this.changeEmployee.Location = new System.Drawing.Point(341, 3);
            this.changeEmployee.Name = "changeEmployee";
            this.changeEmployee.Size = new System.Drawing.Size(82, 27);
            this.changeEmployee.TabIndex = 4;
            this.changeEmployee.Text = "Изменить";
            this.changeEmployee.UseVisualStyleBackColor = true;
            this.changeEmployee.Click += new System.EventHandler(this.changeEmployee_Click);
            // 
            // removeEmployee
            // 
            this.removeEmployee.AutoSize = true;
            this.removeEmployee.Location = new System.Drawing.Point(429, 3);
            this.removeEmployee.Name = "removeEmployee";
            this.removeEmployee.Size = new System.Drawing.Size(75, 27);
            this.removeEmployee.TabIndex = 5;
            this.removeEmployee.Text = "Удалить";
            this.removeEmployee.UseVisualStyleBackColor = true;
            this.removeEmployee.Click += new System.EventHandler(this.removeEmployee_Click);
            // 
            // addEmployee
            // 
            this.addEmployee.AutoSize = true;
            this.addEmployee.Location = new System.Drawing.Point(253, 3);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(82, 27);
            this.addEmployee.TabIndex = 3;
            this.addEmployee.Text = "Добавить";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // employeeGroupBox
            // 
            this.employeeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeGroupBox.Controls.Add(this.employeeTable);
            this.employeeGroupBox.Location = new System.Drawing.Point(3, 3);
            this.employeeGroupBox.Name = "employeeGroupBox";
            this.employeeGroupBox.Size = new System.Drawing.Size(507, 315);
            this.employeeGroupBox.TabIndex = 1;
            this.employeeGroupBox.TabStop = false;
            this.employeeGroupBox.Text = "Сотрудники";
            // 
            // employeeTable
            // 
            this.employeeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeTable.AutoGenerateColumns = false;
            this.employeeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn});
            this.employeeTable.DataSource = this.employeeSource;
            this.employeeTable.Location = new System.Drawing.Point(6, 21);
            this.employeeTable.Name = "employeeTable";
            this.employeeTable.RowTemplate.Height = 24;
            this.employeeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeTable.Size = new System.Drawing.Size(495, 294);
            this.employeeTable.TabIndex = 0;
            // 
            // removeDepartmentButton
            // 
            this.removeDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeDepartmentButton.Location = new System.Drawing.Point(228, 404);
            this.removeDepartmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeDepartmentButton.Name = "removeDepartmentButton";
            this.removeDepartmentButton.Size = new System.Drawing.Size(100, 28);
            this.removeDepartmentButton.TabIndex = 5;
            this.removeDepartmentButton.Text = "Удалить";
            this.removeDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // changeDepartmentButton
            // 
            this.changeDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeDepartmentButton.Location = new System.Drawing.Point(120, 404);
            this.changeDepartmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeDepartmentButton.Name = "changeDepartmentButton";
            this.changeDepartmentButton.Size = new System.Drawing.Size(100, 28);
            this.changeDepartmentButton.TabIndex = 4;
            this.changeDepartmentButton.Text = "Изменить";
            this.changeDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addDepartmentButton.Location = new System.Drawing.Point(12, 404);
            this.addDepartmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Size = new System.Drawing.Size(100, 28);
            this.addDepartmentButton.TabIndex = 3;
            this.addDepartmentButton.Text = "Добавить";
            this.addDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.removeEmployeeButton);
            this.tabPage2.Controls.Add(this.changeEmployeeButton);
            this.tabPage2.Controls.Add(this.addEmployeeButton);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.Найти);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(828, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сотрудники";
            // 
            // removeEmployeeButton
            // 
            this.removeEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeEmployeeButton.Location = new System.Drawing.Point(228, 374);
            this.removeEmployeeButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeEmployeeButton.Name = "removeEmployeeButton";
            this.removeEmployeeButton.Size = new System.Drawing.Size(100, 28);
            this.removeEmployeeButton.TabIndex = 8;
            this.removeEmployeeButton.Text = "Удалить";
            this.removeEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // changeEmployeeButton
            // 
            this.changeEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeEmployeeButton.Location = new System.Drawing.Point(120, 374);
            this.changeEmployeeButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeEmployeeButton.Name = "changeEmployeeButton";
            this.changeEmployeeButton.Size = new System.Drawing.Size(100, 28);
            this.changeEmployeeButton.TabIndex = 7;
            this.changeEmployeeButton.Text = "Изменить";
            this.changeEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addEmployeeButton.Location = new System.Drawing.Point(12, 374);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(4);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(100, 28);
            this.addEmployeeButton.TabIndex = 6;
            this.addEmployeeButton.Text = "Добавить";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 57);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(709, 309);
            this.dataGridView2.TabIndex = 4;
            // 
            // Найти
            // 
            this.Найти.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Найти.Location = new System.Drawing.Point(572, 21);
            this.Найти.Margin = new System.Windows.Forms.Padding(4);
            this.Найти.Name = "Найти";
            this.Найти.Size = new System.Drawing.Size(150, 28);
            this.Найти.TabIndex = 3;
            this.Найти.Text = "Найти";
            this.Найти.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(13, 21);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(554, 27);
            this.textBox2.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeSource
            // 
            this.employeeSource.DataSource = typeof(UI.AdminUI.EmployeeWrapperItem);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 434);
            this.Controls.Add(this.userTab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администрирование";
            this.userTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.departmentGroupBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.employeeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl userTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button removeDepartmentButton;
        private System.Windows.Forms.Button changeDepartmentButton;
        private System.Windows.Forms.Button addDepartmentButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button removeEmployeeButton;
        private System.Windows.Forms.Button changeEmployeeButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Найти;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox departmentGroupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addDepartment;
        private System.Windows.Forms.Button changeDepartment;
        private System.Windows.Forms.Button removeDepartment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button changeEmployee;
        private System.Windows.Forms.Button removeEmployee;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.GroupBox employeeGroupBox;
        private System.Windows.Forms.DataGridView employeeTable;
        private System.Windows.Forms.TreeView departmentView;
        private System.Windows.Forms.BindingSource employeeSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
    }
}