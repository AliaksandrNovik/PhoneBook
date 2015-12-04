namespace UI.AdminUI
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
            this.sructTab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.employeeGroupBox = new System.Windows.Forms.GroupBox();
            this.employeeTable = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.removeEmployeeButton = new System.Windows.Forms.Button();
            this.changeEmployeeButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.departmentGroupBox = new System.Windows.Forms.GroupBox();
            this.departmentView = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.removeDepartmentButton = new System.Windows.Forms.Button();
            this.changeDepartmentButton = new System.Windows.Forms.Button();
            this.addDeparmentButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.assignManagerUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.departmentViewForUsers = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.assignUserButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.employeeTableViewForUsers = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.adminList = new System.Windows.Forms.ListView();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSource = new System.Windows.Forms.BindingSource(this.components);
            this.sructTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.employeeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.departmentGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableViewForUsers)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sructTab
            // 
            this.sructTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sructTab.Controls.Add(this.tabPage1);
            this.sructTab.Controls.Add(this.tabPage2);
            this.sructTab.Controls.Add(this.tabPage3);
            this.sructTab.Location = new System.Drawing.Point(12, 12);
            this.sructTab.Name = "sructTab";
            this.sructTab.SelectedIndex = 0;
            this.sructTab.Size = new System.Drawing.Size(962, 394);
            this.sructTab.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(954, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пользователи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.86047F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.13953F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 353);
            this.tableLayoutPanel1.TabIndex = 6;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(397, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(542, 347);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // employeeGroupBox
            // 
            this.employeeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeGroupBox.Controls.Add(this.employeeTable);
            this.employeeGroupBox.Location = new System.Drawing.Point(3, 3);
            this.employeeGroupBox.Name = "employeeGroupBox";
            this.employeeGroupBox.Size = new System.Drawing.Size(536, 291);
            this.employeeGroupBox.TabIndex = 2;
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
            this.employeeTable.Size = new System.Drawing.Size(524, 270);
            this.employeeTable.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.addEmployeeButton);
            this.flowLayoutPanel2.Controls.Add(this.changeEmployeeButton);
            this.flowLayoutPanel2.Controls.Add(this.removeEmployeeButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 300);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(536, 44);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // removeEmployeeButton
            // 
            this.removeEmployeeButton.AutoSize = true;
            this.removeEmployeeButton.Location = new System.Drawing.Point(179, 3);
            this.removeEmployeeButton.Name = "removeEmployeeButton";
            this.removeEmployeeButton.Size = new System.Drawing.Size(75, 27);
            this.removeEmployeeButton.TabIndex = 5;
            this.removeEmployeeButton.Text = "Удалить";
            this.removeEmployeeButton.UseVisualStyleBackColor = true;
            this.removeEmployeeButton.Click += new System.EventHandler(this.removeEmployeeButton_Click);
            // 
            // changeEmployeeButton
            // 
            this.changeEmployeeButton.AutoSize = true;
            this.changeEmployeeButton.Location = new System.Drawing.Point(91, 3);
            this.changeEmployeeButton.Name = "changeEmployeeButton";
            this.changeEmployeeButton.Size = new System.Drawing.Size(82, 27);
            this.changeEmployeeButton.TabIndex = 4;
            this.changeEmployeeButton.Text = "Изменить";
            this.changeEmployeeButton.UseVisualStyleBackColor = true;
            this.changeEmployeeButton.Click += new System.EventHandler(this.changeEmployeeButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.AutoSize = true;
            this.addEmployeeButton.Location = new System.Drawing.Point(3, 3);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(82, 27);
            this.addEmployeeButton.TabIndex = 3;
            this.addEmployeeButton.Text = "Добавить";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.departmentGroupBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(388, 347);
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
            this.departmentGroupBox.Size = new System.Drawing.Size(382, 291);
            this.departmentGroupBox.TabIndex = 3;
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
            this.departmentView.Size = new System.Drawing.Size(382, 270);
            this.departmentView.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.addDeparmentButton);
            this.flowLayoutPanel1.Controls.Add(this.changeDepartmentButton);
            this.flowLayoutPanel1.Controls.Add(this.removeDepartmentButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 300);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(382, 44);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // removeDepartmentButton
            // 
            this.removeDepartmentButton.AutoSize = true;
            this.removeDepartmentButton.Location = new System.Drawing.Point(179, 3);
            this.removeDepartmentButton.Name = "removeDepartmentButton";
            this.removeDepartmentButton.Size = new System.Drawing.Size(75, 27);
            this.removeDepartmentButton.TabIndex = 2;
            this.removeDepartmentButton.Text = "Удалить";
            this.removeDepartmentButton.UseVisualStyleBackColor = true;
            this.removeDepartmentButton.Click += new System.EventHandler(this.removeDepartmentButton_Click);
            // 
            // changeDepartmentButton
            // 
            this.changeDepartmentButton.AutoSize = true;
            this.changeDepartmentButton.Location = new System.Drawing.Point(91, 3);
            this.changeDepartmentButton.Name = "changeDepartmentButton";
            this.changeDepartmentButton.Size = new System.Drawing.Size(82, 27);
            this.changeDepartmentButton.TabIndex = 1;
            this.changeDepartmentButton.Text = "Изменить";
            this.changeDepartmentButton.UseVisualStyleBackColor = true;
            this.changeDepartmentButton.Click += new System.EventHandler(this.changeDepartmentButton_Click);
            // 
            // addDeparmentButton
            // 
            this.addDeparmentButton.AutoSize = true;
            this.addDeparmentButton.Location = new System.Drawing.Point(3, 3);
            this.addDeparmentButton.Name = "addDeparmentButton";
            this.addDeparmentButton.Size = new System.Drawing.Size(82, 27);
            this.addDeparmentButton.TabIndex = 0;
            this.addDeparmentButton.Text = "Добавить";
            this.addDeparmentButton.UseVisualStyleBackColor = true;
            this.addDeparmentButton.Click += new System.EventHandler(this.addDeparmentButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(954, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Структура подразделения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.86047F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.13953F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(942, 353);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(388, 347);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.assignManagerUser);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 300);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(382, 44);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // assignManagerUser
            // 
            this.assignManagerUser.AutoSize = true;
            this.assignManagerUser.Location = new System.Drawing.Point(3, 3);
            this.assignManagerUser.Name = "assignManagerUser";
            this.assignManagerUser.Size = new System.Drawing.Size(167, 27);
            this.assignManagerUser.TabIndex = 0;
            this.assignManagerUser.Text = "Назначить менеджера";
            this.assignManagerUser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.departmentViewForUsers);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 291);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Структура подразделений";
            // 
            // departmentViewForUsers
            // 
            this.departmentViewForUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentViewForUsers.HideSelection = false;
            this.departmentViewForUsers.Location = new System.Drawing.Point(0, 21);
            this.departmentViewForUsers.Name = "departmentViewForUsers";
            this.departmentViewForUsers.Size = new System.Drawing.Size(382, 270);
            this.departmentViewForUsers.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel4, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(397, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(542, 347);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.Controls.Add(this.assignUserButton);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 300);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(536, 44);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // assignUserButton
            // 
            this.assignUserButton.AutoSize = true;
            this.assignUserButton.Location = new System.Drawing.Point(3, 3);
            this.assignUserButton.Name = "assignUserButton";
            this.assignUserButton.Size = new System.Drawing.Size(193, 27);
            this.assignUserButton.TabIndex = 3;
            this.assignUserButton.Text = "Назначить пользователя";
            this.assignUserButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.employeeTableViewForUsers);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 291);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сотрудники";
            // 
            // employeeTableViewForUsers
            // 
            this.employeeTableViewForUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeTableViewForUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeTableViewForUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTableViewForUsers.Location = new System.Drawing.Point(6, 21);
            this.employeeTableViewForUsers.Name = "employeeTableViewForUsers";
            this.employeeTableViewForUsers.RowTemplate.Height = 24;
            this.employeeTableViewForUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeTableViewForUsers.Size = new System.Drawing.Size(524, 270);
            this.employeeTableViewForUsers.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(954, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Администраторы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.flowLayoutPanel5, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.adminList, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(942, 353);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // adminList
            // 
            this.adminList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminList.Location = new System.Drawing.Point(3, 3);
            this.adminList.Name = "adminList";
            this.adminList.Size = new System.Drawing.Size(936, 297);
            this.adminList.TabIndex = 0;
            this.adminList.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel5.Controls.Add(this.button1);
            this.flowLayoutPanel5.Controls.Add(this.button2);
            this.flowLayoutPanel5.Controls.Add(this.button3);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 306);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(936, 44);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(91, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(179, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
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
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // employeeSource
            // 
            this.employeeSource.DataSource = typeof(UI.AdminUI.EmployeeWrapperItem);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 418);
            this.Controls.Add(this.sructTab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администрирование";
            this.sructTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.employeeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.departmentGroupBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableViewForUsers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl sructTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addDeparmentButton;
        private System.Windows.Forms.Button changeDepartmentButton;
        private System.Windows.Forms.Button removeDepartmentButton;
        private System.Windows.Forms.GroupBox departmentGroupBox;
        private System.Windows.Forms.TreeView departmentView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button changeEmployeeButton;
        private System.Windows.Forms.Button removeEmployeeButton;
        private System.Windows.Forms.GroupBox employeeGroupBox;
        private System.Windows.Forms.DataGridView employeeTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button assignManagerUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView departmentViewForUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button assignUserButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView employeeTableViewForUsers;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView adminList;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeSource;
    }
}