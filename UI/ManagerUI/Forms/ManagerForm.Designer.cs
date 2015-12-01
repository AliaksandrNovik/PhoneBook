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
            this.phoneDepartmentView = new System.Windows.Forms.TabControl();
            this.unitTab = new System.Windows.Forms.TabPage();
            this.removeDepartment = new System.Windows.Forms.Button();
            this.changeDepartment = new System.Windows.Forms.Button();
            this.addDepartment = new System.Windows.Forms.Button();
            this.employeeTab = new System.Windows.Forms.TabPage();
            this.removeEmployee = new System.Windows.Forms.Button();
            this.changeEmployee = new System.Windows.Forms.Button();
            this.phoneTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.departmentView = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.headGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.headPlace = new System.Windows.Forms.Label();
            this.headName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.employeeDepartmentView = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.addEmployee = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.statPhoneButton = new System.Windows.Forms.Button();
            this.phoneDepartmentView.SuspendLayout();
            this.unitTab.SuspendLayout();
            this.employeeTab.SuspendLayout();
            this.phoneTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.headGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // phoneDepartmentView
            // 
            this.phoneDepartmentView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneDepartmentView.Controls.Add(this.unitTab);
            this.phoneDepartmentView.Controls.Add(this.employeeTab);
            this.phoneDepartmentView.Controls.Add(this.phoneTab);
            this.phoneDepartmentView.Location = new System.Drawing.Point(1, 1);
            this.phoneDepartmentView.Margin = new System.Windows.Forms.Padding(4);
            this.phoneDepartmentView.Name = "phoneDepartmentView";
            this.phoneDepartmentView.SelectedIndex = 0;
            this.phoneDepartmentView.Size = new System.Drawing.Size(965, 642);
            this.phoneDepartmentView.TabIndex = 0;
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
            this.unitTab.Size = new System.Drawing.Size(957, 613);
            this.unitTab.TabIndex = 0;
            this.unitTab.Text = "Подразделения";
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
            this.employeeTab.Size = new System.Drawing.Size(957, 613);
            this.employeeTab.TabIndex = 1;
            this.employeeTab.Text = "Сотрудники";
            // 
            // removeEmployee
            // 
            this.removeEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.removeEmployee.AutoSize = true;
            this.removeEmployee.Location = new System.Drawing.Point(220, 4);
            this.removeEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.removeEmployee.Name = "removeEmployee";
            this.removeEmployee.Size = new System.Drawing.Size(100, 28);
            this.removeEmployee.TabIndex = 6;
            this.removeEmployee.Text = "Удалить";
            this.removeEmployee.UseVisualStyleBackColor = true;
            this.removeEmployee.Click += new System.EventHandler(this.removeEmployee_Click);
            // 
            // changeEmployee
            // 
            this.changeEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.changeEmployee.AutoSize = true;
            this.changeEmployee.Location = new System.Drawing.Point(112, 4);
            this.changeEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.changeEmployee.Name = "changeEmployee";
            this.changeEmployee.Size = new System.Drawing.Size(100, 28);
            this.changeEmployee.TabIndex = 5;
            this.changeEmployee.Text = "Изменить";
            this.changeEmployee.UseVisualStyleBackColor = true;
            this.changeEmployee.Click += new System.EventHandler(this.changeEmployee_Click);
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
            this.phoneTab.Size = new System.Drawing.Size(957, 613);
            this.phoneTab.TabIndex = 2;
            this.phoneTab.Text = "Тел. номера";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 556);
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
            this.departmentView.Size = new System.Drawing.Size(444, 550);
            this.departmentView.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.headGroupBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(453, 3);
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(947, 599);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // employeeDepartmentView
            // 
            this.employeeDepartmentView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeDepartmentView.Location = new System.Drawing.Point(3, 3);
            this.employeeDepartmentView.Name = "employeeDepartmentView";
            this.employeeDepartmentView.Size = new System.Drawing.Size(349, 593);
            this.employeeDepartmentView.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(358, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(586, 593);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // addEmployee
            // 
            this.addEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addEmployee.AutoSize = true;
            this.addEmployee.Location = new System.Drawing.Point(4, 4);
            this.addEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(100, 28);
            this.addEmployee.TabIndex = 4;
            this.addEmployee.Text = "Добавить";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.addEmployee);
            this.flowLayoutPanel1.Controls.Add(this.changeEmployee);
            this.flowLayoutPanel1.Controls.Add(this.removeEmployee);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 546);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(580, 44);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(580, 537);
            this.dataGridView1.TabIndex = 9;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel6.Controls.Add(this.treeView2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(11, 7);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(939, 599);
            this.tableLayoutPanel6.TabIndex = 8;
            // 
            // treeView2
            // 
            this.treeView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView2.Location = new System.Drawing.Point(3, 3);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(346, 593);
            this.treeView2.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(355, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(581, 593);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(575, 537);
            this.dataGridView2.TabIndex = 9;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel8.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.statPhoneButton, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 546);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(575, 44);
            this.tableLayoutPanel8.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(4, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(119, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(234, 8);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // statPhoneButton
            // 
            this.statPhoneButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.statPhoneButton.AutoSize = true;
            this.statPhoneButton.Location = new System.Drawing.Point(478, 8);
            this.statPhoneButton.Name = "statPhoneButton";
            this.statPhoneButton.Size = new System.Drawing.Size(94, 27);
            this.statPhoneButton.TabIndex = 13;
            this.statPhoneButton.Text = "Статистика";
            this.statPhoneButton.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 641);
            this.Controls.Add(this.phoneDepartmentView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер";
            this.phoneDepartmentView.ResumeLayout(false);
            this.unitTab.ResumeLayout(false);
            this.unitTab.PerformLayout();
            this.employeeTab.ResumeLayout(false);
            this.phoneTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.headGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl phoneDepartmentView;
        private System.Windows.Forms.TabPage employeeTab;
        private System.Windows.Forms.TabPage phoneTab;
        private System.Windows.Forms.TabPage unitTab;
        private System.Windows.Forms.Button removeDepartment;
        private System.Windows.Forms.Button changeDepartment;
        private System.Windows.Forms.Button addDepartment;
        private System.Windows.Forms.Button removeEmployee;
        private System.Windows.Forms.Button changeEmployee;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button statPhoneButton;
    }
}