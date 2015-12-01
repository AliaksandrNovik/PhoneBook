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
            this.tabWidget = new System.Windows.Forms.TabControl();
            this.unitTab = new System.Windows.Forms.TabPage();
            this.removeDepartment = new System.Windows.Forms.Button();
            this.changeDepartment = new System.Windows.Forms.Button();
            this.addDepartment = new System.Windows.Forms.Button();
            this.employeeTab = new System.Windows.Forms.TabPage();
            this.removeEmployee = new System.Windows.Forms.Button();
            this.changeEmployee = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.phoneTab = new System.Windows.Forms.TabPage();
            this.changePhone = new System.Windows.Forms.Button();
            this.addPhone = new System.Windows.Forms.Button();
            this.removePhone = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.departmentView = new System.Windows.Forms.TreeView();
            this.headGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.headPlace = new System.Windows.Forms.Label();
            this.headName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabWidget.SuspendLayout();
            this.unitTab.SuspendLayout();
            this.employeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.phoneTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.headGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabWidget
            // 
            this.tabWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabWidget.Controls.Add(this.unitTab);
            this.tabWidget.Controls.Add(this.employeeTab);
            this.tabWidget.Controls.Add(this.phoneTab);
            this.tabWidget.Location = new System.Drawing.Point(1, 1);
            this.tabWidget.Margin = new System.Windows.Forms.Padding(4);
            this.tabWidget.Name = "tabWidget";
            this.tabWidget.SelectedIndex = 0;
            this.tabWidget.Size = new System.Drawing.Size(711, 529);
            this.tabWidget.TabIndex = 0;
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
            this.unitTab.Size = new System.Drawing.Size(703, 500);
            this.unitTab.TabIndex = 0;
            this.unitTab.Text = "Подразделения";
            // 
            // removeDepartment
            // 
            this.removeDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeDepartment.Location = new System.Drawing.Point(224, 461);
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
            this.changeDepartment.Location = new System.Drawing.Point(116, 461);
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
            this.addDepartment.Location = new System.Drawing.Point(8, 461);
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
            this.employeeTab.Controls.Add(this.removeEmployee);
            this.employeeTab.Controls.Add(this.changeEmployee);
            this.employeeTab.Controls.Add(this.addEmployee);
            this.employeeTab.Controls.Add(this.dataGridView2);
            this.employeeTab.Controls.Add(this.button2);
            this.employeeTab.Controls.Add(this.textBox2);
            this.employeeTab.Location = new System.Drawing.Point(4, 25);
            this.employeeTab.Margin = new System.Windows.Forms.Padding(4);
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.Padding = new System.Windows.Forms.Padding(4);
            this.employeeTab.Size = new System.Drawing.Size(1030, 420);
            this.employeeTab.TabIndex = 1;
            this.employeeTab.Text = "Сотрудники";
            // 
            // removeEmployee
            // 
            this.removeEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeEmployee.Location = new System.Drawing.Point(224, 337);
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
            this.changeEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeEmployee.Location = new System.Drawing.Point(116, 337);
            this.changeEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.changeEmployee.Name = "changeEmployee";
            this.changeEmployee.Size = new System.Drawing.Size(100, 28);
            this.changeEmployee.TabIndex = 5;
            this.changeEmployee.Text = "Изменить";
            this.changeEmployee.UseVisualStyleBackColor = true;
            this.changeEmployee.Click += new System.EventHandler(this.changeEmployee_Click);
            // 
            // addEmployee
            // 
            this.addEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addEmployee.Location = new System.Drawing.Point(8, 337);
            this.addEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(100, 28);
            this.addEmployee.TabIndex = 4;
            this.addEmployee.Text = "Добавить";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 43);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(735, 286);
            this.dataGridView2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(559, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(8, 8);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(543, 27);
            this.textBox2.TabIndex = 1;
            // 
            // phoneTab
            // 
            this.phoneTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.phoneTab.Controls.Add(this.changePhone);
            this.phoneTab.Controls.Add(this.addPhone);
            this.phoneTab.Controls.Add(this.removePhone);
            this.phoneTab.Controls.Add(this.dataGridView3);
            this.phoneTab.Controls.Add(this.button1);
            this.phoneTab.Controls.Add(this.textBox1);
            this.phoneTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneTab.Location = new System.Drawing.Point(4, 25);
            this.phoneTab.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTab.Name = "phoneTab";
            this.phoneTab.Padding = new System.Windows.Forms.Padding(4);
            this.phoneTab.Size = new System.Drawing.Size(1030, 420);
            this.phoneTab.TabIndex = 2;
            this.phoneTab.Text = "Тел. номера";
            // 
            // changePhone
            // 
            this.changePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changePhone.Location = new System.Drawing.Point(116, 337);
            this.changePhone.Margin = new System.Windows.Forms.Padding(4);
            this.changePhone.Name = "changePhone";
            this.changePhone.Size = new System.Drawing.Size(100, 28);
            this.changePhone.TabIndex = 5;
            this.changePhone.Text = "Изменить";
            this.changePhone.UseVisualStyleBackColor = true;
            this.changePhone.Click += new System.EventHandler(this.changePhone_Click);
            // 
            // addPhone
            // 
            this.addPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addPhone.Location = new System.Drawing.Point(8, 337);
            this.addPhone.Margin = new System.Windows.Forms.Padding(4);
            this.addPhone.Name = "addPhone";
            this.addPhone.Size = new System.Drawing.Size(100, 28);
            this.addPhone.TabIndex = 4;
            this.addPhone.Text = "Добавить";
            this.addPhone.UseVisualStyleBackColor = true;
            this.addPhone.Click += new System.EventHandler(this.addPhone_Click);
            // 
            // removePhone
            // 
            this.removePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removePhone.Location = new System.Drawing.Point(224, 337);
            this.removePhone.Margin = new System.Windows.Forms.Padding(4);
            this.removePhone.Name = "removePhone";
            this.removePhone.Size = new System.Drawing.Size(100, 28);
            this.removePhone.TabIndex = 3;
            this.removePhone.Text = "Удалить";
            this.removePhone.UseVisualStyleBackColor = true;
            this.removePhone.Click += new System.EventHandler(this.removePhone_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(8, 43);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(735, 286);
            this.dataGridView3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(559, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(4, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(547, 27);
            this.textBox1.TabIndex = 0;
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
            this.tableLayoutPanel1.Controls.Add(this.headGroupBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 443);
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
            this.departmentView.Size = new System.Drawing.Size(336, 437);
            this.departmentView.TabIndex = 9;
            // 
            // headGroupBox
            // 
            this.headGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.headGroupBox.Location = new System.Drawing.Point(345, 3);
            this.headGroupBox.Name = "headGroupBox";
            this.headGroupBox.Size = new System.Drawing.Size(290, 98);
            this.headGroupBox.TabIndex = 10;
            this.headGroupBox.TabStop = false;
            this.headGroupBox.Text = "Начальник";
            this.headGroupBox.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.headPlace, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.headName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 71);
            this.tableLayoutPanel2.TabIndex = 0;
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
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 528);
            this.Controls.Add(this.tabWidget);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.tabWidget.ResumeLayout(false);
            this.unitTab.ResumeLayout(false);
            this.employeeTab.ResumeLayout(false);
            this.employeeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.phoneTab.ResumeLayout(false);
            this.phoneTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.headGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabWidget;
        private System.Windows.Forms.TabPage employeeTab;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage phoneTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage unitTab;
        private System.Windows.Forms.Button removeDepartment;
        private System.Windows.Forms.Button changeDepartment;
        private System.Windows.Forms.Button addDepartment;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button removeEmployee;
        private System.Windows.Forms.Button changeEmployee;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Button changePhone;
        private System.Windows.Forms.Button addPhone;
        private System.Windows.Forms.Button removePhone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView departmentView;
        private System.Windows.Forms.GroupBox headGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label headPlace;
        private System.Windows.Forms.Label headName;
        private System.Windows.Forms.Label label4;
    }
}