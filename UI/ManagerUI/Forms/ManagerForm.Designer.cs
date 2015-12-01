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
            this.button6 = new System.Windows.Forms.Button();
            this.changeDepartmentButton = new System.Windows.Forms.Button();
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchDepartmentButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.tabWidget.SuspendLayout();
            this.unitTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.employeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.phoneTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.tabWidget.Size = new System.Drawing.Size(759, 405);
            this.tabWidget.TabIndex = 0;
            // 
            // unitTab
            // 
            this.unitTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.unitTab.Controls.Add(this.button6);
            this.unitTab.Controls.Add(this.changeDepartmentButton);
            this.unitTab.Controls.Add(this.addDepartmentButton);
            this.unitTab.Controls.Add(this.dataGridView1);
            this.unitTab.Controls.Add(this.searchDepartmentButton);
            this.unitTab.Controls.Add(this.textBox3);
            this.unitTab.Location = new System.Drawing.Point(4, 25);
            this.unitTab.Margin = new System.Windows.Forms.Padding(4);
            this.unitTab.Name = "unitTab";
            this.unitTab.Padding = new System.Windows.Forms.Padding(4);
            this.unitTab.Size = new System.Drawing.Size(751, 376);
            this.unitTab.TabIndex = 0;
            this.unitTab.Text = "Подразделения";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Location = new System.Drawing.Point(224, 337);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 7;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // changeDepartmentButton
            // 
            this.changeDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeDepartmentButton.Location = new System.Drawing.Point(116, 337);
            this.changeDepartmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeDepartmentButton.Name = "changeDepartmentButton";
            this.changeDepartmentButton.Size = new System.Drawing.Size(100, 28);
            this.changeDepartmentButton.TabIndex = 6;
            this.changeDepartmentButton.Text = "Изменить";
            this.changeDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addDepartmentButton.Location = new System.Drawing.Point(8, 337);
            this.addDepartmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Size = new System.Drawing.Size(100, 28);
            this.addDepartmentButton.TabIndex = 5;
            this.addDepartmentButton.Text = "Добавить";
            this.addDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 286);
            this.dataGridView1.TabIndex = 4;
            // 
            // searchDepartmentButton
            // 
            this.searchDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDepartmentButton.Location = new System.Drawing.Point(559, 8);
            this.searchDepartmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchDepartmentButton.Name = "searchDepartmentButton";
            this.searchDepartmentButton.Size = new System.Drawing.Size(184, 27);
            this.searchDepartmentButton.TabIndex = 3;
            this.searchDepartmentButton.Text = "Найти";
            this.searchDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(8, 8);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(543, 27);
            this.textBox3.TabIndex = 1;
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
            this.employeeTab.Size = new System.Drawing.Size(751, 376);
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
            this.phoneTab.Size = new System.Drawing.Size(751, 376);
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
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 404);
            this.Controls.Add(this.tabWidget);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.tabWidget.ResumeLayout(false);
            this.unitTab.ResumeLayout(false);
            this.unitTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.employeeTab.ResumeLayout(false);
            this.employeeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.phoneTab.ResumeLayout(false);
            this.phoneTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button changeDepartmentButton;
        private System.Windows.Forms.Button addDepartmentButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchDepartmentButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button removeEmployee;
        private System.Windows.Forms.Button changeEmployee;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Button changePhone;
        private System.Windows.Forms.Button addPhone;
        private System.Windows.Forms.Button removePhone;
    }
}