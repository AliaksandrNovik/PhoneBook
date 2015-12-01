namespace UI.ManagerUI
{
    partial class ManagerForm
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
            this.foo = new System.Windows.Forms.TabControl();
            this.unitTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.departmentView = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.headGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.headPlace = new System.Windows.Forms.Label();
            this.headName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.removeDepartment = new System.Windows.Forms.Button();
            this.changeDepartment = new System.Windows.Forms.Button();
            this.addDepartment = new System.Windows.Forms.Button();
            this.employeeTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.employeeDepartmentView = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.changeEmployee = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Button();
            this.removeEmployee = new System.Windows.Forms.Button();
            this.employeeTable = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.phoneDepartmentView = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.phoneTable = new System.Windows.Forms.DataGridView();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullEmployeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.changePhone = new System.Windows.Forms.Button();
            this.addPhone = new System.Windows.Forms.Button();
            this.statPhoneButton = new System.Windows.Forms.Button();
            this.removePhone = new System.Windows.Forms.Button();
            this.foo.SuspendLayout();
            this.unitTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.headGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.employeeTab.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSource)).BeginInit();
            this.phoneTab.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneSource)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // foo
            // 
            this.foo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foo.Controls.Add(this.unitTab);
            this.foo.Controls.Add(this.employeeTab);
            this.foo.Controls.Add(this.phoneTab);
            this.foo.Location = new System.Drawing.Point(1, 1);
            this.foo.Margin = new System.Windows.Forms.Padding(4);
            this.foo.Name = "foo";
            this.foo.SelectedIndex = 0;
            this.foo.Size = new System.Drawing.Size(1226, 642);
            this.foo.TabIndex = 0;
            // 
            // unitTab
            // 
            this.unitTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.unitTab.Controls.Add(this.tableLayoutPanel1);
            this.unitTab.Controls.Add(this.removeDepartment);
            this.unitTab.Controls.Add(this.changeDepartment);
            this.unitTab.Controls.Add(this.addDepartment);
            this.unitTab.Location = new System.Drawing.Point(4, 25);
            this.unitTab.Margin = new System.Windows.Forms.Padding(4);
            this.unitTab.Name = "unitTab";
            this.unitTab.Padding = new System.Windows.Forms.Padding(4);
            this.unitTab.Size = new System.Drawing.Size(1218, 613);
            this.unitTab.TabIndex = 0;
            this.unitTab.Text = "Подразделения";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.departmentView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 556);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // departmentView
            // 
            this.departmentView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentView.FullRowSelect = true;
            this.departmentView.Location = new System.Drawing.Point(3, 3);
            this.departmentView.Name = "departmentView";
            this.departmentView.Size = new System.Drawing.Size(512, 550);
            this.departmentView.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.headGroupBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(521, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 437);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // headGroupBox
            // 
            this.headGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.headGroupBox.Location = new System.Drawing.Point(3, 3);
            this.headGroupBox.Name = "headGroupBox";
            this.headGroupBox.Size = new System.Drawing.Size(290, 98);
            this.headGroupBox.TabIndex = 11;
            this.headGroupBox.TabStop = false;
            this.headGroupBox.Text = "Начальник";
            this.headGroupBox.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.headPlace, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.headName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(278, 71);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headPlace
            // 
            this.headPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headPlace.AutoSize = true;
            this.headPlace.Location = new System.Drawing.Point(142, 35);
            this.headPlace.Name = "headPlace";
            this.headPlace.Size = new System.Drawing.Size(133, 36);
            this.headPlace.TabIndex = 1;
            this.headPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // headName
            // 
            this.headName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headName.AutoSize = true;
            this.headName.Location = new System.Drawing.Point(142, 0);
            this.headName.Name = "headName";
            this.headName.Size = new System.Drawing.Size(133, 35);
            this.headName.TabIndex = 2;
            this.headName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Должность";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeDepartment
            // 
            this.removeDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeDepartment.AutoSize = true;
            this.removeDepartment.Location = new System.Drawing.Point(224, 574);
            this.removeDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.removeDepartment.Name = "removeDepartment";
            this.removeDepartment.Size = new System.Drawing.Size(100, 28);
            this.removeDepartment.TabIndex = 7;
            this.removeDepartment.Text = "Удалить";
            this.removeDepartment.UseVisualStyleBackColor = true;
            this.removeDepartment.Click += new System.EventHandler(this.removeDepartment_Click);
            // 
            // changeDepartment
            // 
            this.changeDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeDepartment.AutoSize = true;
            this.changeDepartment.Location = new System.Drawing.Point(116, 574);
            this.changeDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.changeDepartment.Name = "changeDepartment";
            this.changeDepartment.Size = new System.Drawing.Size(100, 28);
            this.changeDepartment.TabIndex = 6;
            this.changeDepartment.Text = "Изменить";
            this.changeDepartment.UseVisualStyleBackColor = true;
            this.changeDepartment.Click += new System.EventHandler(this.changeDepartment_Click);
            // 
            // addDepartment
            // 
            this.addDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addDepartment.AutoSize = true;
            this.addDepartment.Location = new System.Drawing.Point(8, 574);
            this.addDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.addDepartment.Name = "addDepartment";
            this.addDepartment.Size = new System.Drawing.Size(100, 28);
            this.addDepartment.TabIndex = 5;
            this.addDepartment.Text = "Добавить";
            this.addDepartment.UseVisualStyleBackColor = true;
            this.addDepartment.Click += new System.EventHandler(this.addDepartment_Click);
            // 
            // employeeTab
            // 
            this.employeeTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.employeeTab.Controls.Add(this.tableLayoutPanel4);
            this.employeeTab.Location = new System.Drawing.Point(4, 25);
            this.employeeTab.Margin = new System.Windows.Forms.Padding(4);
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.Padding = new System.Windows.Forms.Padding(4);
            this.employeeTab.Size = new System.Drawing.Size(1218, 613);
            this.employeeTab.TabIndex = 1;
            this.employeeTab.Text = "Сотрудники";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel4.Controls.Add(this.employeeDepartmentView, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1204, 599);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // employeeDepartmentView
            // 
            this.employeeDepartmentView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeDepartmentView.Location = new System.Drawing.Point(3, 3);
            this.employeeDepartmentView.Name = "employeeDepartmentView";
            this.employeeDepartmentView.Size = new System.Drawing.Size(445, 593);
            this.employeeDepartmentView.TabIndex = 0;
            this.employeeDepartmentView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.employeeDepartmentView_AfterSelect);
            this.employeeDepartmentView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.employeeDepartmentView_MouseUp);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.employeeTable, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(454, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(747, 593);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.changeEmployee, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.addEmployee, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.removeEmployee, 2, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 546);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(741, 44);
            this.tableLayoutPanel9.TabIndex = 11;
            // 
            // changeEmployee
            // 
            this.changeEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.changeEmployee.AutoSize = true;
            this.changeEmployee.Location = new System.Drawing.Point(104, 8);
            this.changeEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.changeEmployee.Name = "changeEmployee";
            this.changeEmployee.Size = new System.Drawing.Size(92, 28);
            this.changeEmployee.TabIndex = 11;
            this.changeEmployee.Text = "Изменить";
            this.changeEmployee.UseVisualStyleBackColor = true;
            // 
            // addEmployee
            // 
            this.addEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addEmployee.AutoSize = true;
            this.addEmployee.Location = new System.Drawing.Point(4, 8);
            this.addEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(92, 28);
            this.addEmployee.TabIndex = 10;
            this.addEmployee.Text = "Добавить";
            this.addEmployee.UseVisualStyleBackColor = true;
            // 
            // removeEmployee
            // 
            this.removeEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.removeEmployee.AutoSize = true;
            this.removeEmployee.Location = new System.Drawing.Point(204, 8);
            this.removeEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.removeEmployee.Name = "removeEmployee";
            this.removeEmployee.Size = new System.Drawing.Size(92, 28);
            this.removeEmployee.TabIndex = 12;
            this.removeEmployee.Text = "Удалить";
            this.removeEmployee.UseVisualStyleBackColor = true;
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
            this.birthdayDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.Place});
            this.employeeTable.DataSource = this.employeeSource;
            this.employeeTable.Location = new System.Drawing.Point(3, 3);
            this.employeeTable.Name = "employeeTable";
            this.employeeTable.RowTemplate.Height = 24;
            this.employeeTable.Size = new System.Drawing.Size(741, 537);
            this.employeeTable.TabIndex = 9;
            this.employeeTable.SelectionChanged += new System.EventHandler(this.employeeTable_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "Подразделение";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Place
            // 
            this.Place.DataPropertyName = "Place";
            this.Place.HeaderText = "Должность";
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            // 
            // employeeSource
            // 
            this.employeeSource.DataSource = typeof(UI.ManagerUI.EmployeeWrap);
            // 
            // phoneTab
            // 
            this.phoneTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.phoneTab.Controls.Add(this.tableLayoutPanel6);
            this.phoneTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneTab.Location = new System.Drawing.Point(4, 25);
            this.phoneTab.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTab.Name = "phoneTab";
            this.phoneTab.Padding = new System.Windows.Forms.Padding(4);
            this.phoneTab.Size = new System.Drawing.Size(1218, 613);
            this.phoneTab.TabIndex = 2;
            this.phoneTab.Text = "Тел. номера";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel6.Controls.Add(this.phoneDepartmentView, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(11, 7);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1204, 599);
            this.tableLayoutPanel6.TabIndex = 8;
            // 
            // phoneDepartmentView
            // 
            this.phoneDepartmentView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneDepartmentView.Location = new System.Drawing.Point(3, 3);
            this.phoneDepartmentView.Name = "phoneDepartmentView";
            this.phoneDepartmentView.Size = new System.Drawing.Size(445, 593);
            this.phoneDepartmentView.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.phoneTable, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(454, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(747, 593);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // phoneTable
            // 
            this.phoneTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTable.AutoGenerateColumns = false;
            this.phoneTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phoneTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneNumberDataGridViewTextBoxColumn,
            this.fullEmployeeNameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn1,
            this.placeDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn1});
            this.phoneTable.DataSource = this.phoneSource;
            this.phoneTable.Location = new System.Drawing.Point(3, 3);
            this.phoneTable.Name = "phoneTable";
            this.phoneTable.RowTemplate.Height = 24;
            this.phoneTable.Size = new System.Drawing.Size(741, 537);
            this.phoneTable.TabIndex = 9;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Тел. номер";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullEmployeeNameDataGridViewTextBoxColumn
            // 
            this.fullEmployeeNameDataGridViewTextBoxColumn.DataPropertyName = "FullEmployeeName";
            this.fullEmployeeNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fullEmployeeNameDataGridViewTextBoxColumn.Name = "fullEmployeeNameDataGridViewTextBoxColumn";
            this.fullEmployeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn1
            // 
            this.birthdayDataGridViewTextBoxColumn1.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn1.HeaderText = "Дата рождения";
            this.birthdayDataGridViewTextBoxColumn1.Name = "birthdayDataGridViewTextBoxColumn1";
            this.birthdayDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentNameDataGridViewTextBoxColumn1
            // 
            this.departmentNameDataGridViewTextBoxColumn1.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn1.HeaderText = "Подразделение";
            this.departmentNameDataGridViewTextBoxColumn1.Name = "departmentNameDataGridViewTextBoxColumn1";
            this.departmentNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // phoneSource
            // 
            this.phoneSource.DataSource = typeof(UI.ManagerUI.PhoneWrap);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.changePhone, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.addPhone, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.statPhoneButton, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.removePhone, 2, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 546);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(741, 44);
            this.tableLayoutPanel8.TabIndex = 10;
            // 
            // changePhone
            // 
            this.changePhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.changePhone.AutoSize = true;
            this.changePhone.Location = new System.Drawing.Point(104, 8);
            this.changePhone.Margin = new System.Windows.Forms.Padding(4);
            this.changePhone.Name = "changePhone";
            this.changePhone.Size = new System.Drawing.Size(92, 28);
            this.changePhone.TabIndex = 11;
            this.changePhone.Text = "Изменить";
            this.changePhone.UseVisualStyleBackColor = true;
            // 
            // addPhone
            // 
            this.addPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addPhone.AutoSize = true;
            this.addPhone.Location = new System.Drawing.Point(4, 8);
            this.addPhone.Margin = new System.Windows.Forms.Padding(4);
            this.addPhone.Name = "addPhone";
            this.addPhone.Size = new System.Drawing.Size(92, 28);
            this.addPhone.TabIndex = 10;
            this.addPhone.Text = "Добавить";
            this.addPhone.UseVisualStyleBackColor = true;
            // 
            // statPhoneButton
            // 
            this.statPhoneButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.statPhoneButton.AutoSize = true;
            this.statPhoneButton.Location = new System.Drawing.Point(644, 8);
            this.statPhoneButton.Name = "statPhoneButton";
            this.statPhoneButton.Size = new System.Drawing.Size(94, 27);
            this.statPhoneButton.TabIndex = 13;
            this.statPhoneButton.Text = "Статистика";
            this.statPhoneButton.UseVisualStyleBackColor = true;
            // 
            // removePhone
            // 
            this.removePhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.removePhone.AutoSize = true;
            this.removePhone.Location = new System.Drawing.Point(204, 8);
            this.removePhone.Margin = new System.Windows.Forms.Padding(4);
            this.removePhone.Name = "removePhone";
            this.removePhone.Size = new System.Drawing.Size(92, 28);
            this.removePhone.TabIndex = 12;
            this.removePhone.Text = "Удалить";
            this.removePhone.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 641);
            this.Controls.Add(this.foo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер";
            this.foo.ResumeLayout(false);
            this.unitTab.ResumeLayout(false);
            this.unitTab.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.headGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.employeeTab.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSource)).EndInit();
            this.phoneTab.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phoneTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneSource)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl foo;
        private System.Windows.Forms.TabPage employeeTab;
        private System.Windows.Forms.TabPage phoneTab;
        private System.Windows.Forms.TabPage unitTab;
        private System.Windows.Forms.Button removeDepartment;
        private System.Windows.Forms.Button changeDepartment;
        private System.Windows.Forms.Button addDepartment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView departmentView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox headGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label headPlace;
        private System.Windows.Forms.Label headName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TreeView employeeDepartmentView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView employeeTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TreeView phoneDepartmentView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.DataGridView phoneTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button removePhone;
        private System.Windows.Forms.Button changePhone;
        private System.Windows.Forms.Button addPhone;
        private System.Windows.Forms.Button statPhoneButton;
        private System.Windows.Forms.BindingSource employeeSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.BindingSource phoneSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullEmployeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button changeEmployee;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Button removeEmployee;
    }
}