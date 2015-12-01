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
            this.userTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.removeDepartmentButton = new System.Windows.Forms.Button();
            this.changeDepartmentButton = new System.Windows.Forms.Button();
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.removeEmployeeButton = new System.Windows.Forms.Button();
            this.changeEmployeeButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Найти = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менеджерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.changeButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.userTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userTab
            // 
            this.userTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTab.Controls.Add(this.tabPage1);
            this.userTab.Controls.Add(this.tabPage2);
            this.userTab.Controls.Add(this.tabPage3);
            this.userTab.Location = new System.Drawing.Point(3, 15);
            this.userTab.Margin = new System.Windows.Forms.Padding(4);
            this.userTab.Name = "userTab";
            this.userTab.SelectedIndex = 0;
            this.userTab.Size = new System.Drawing.Size(741, 435);
            this.userTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.removeDepartmentButton);
            this.tabPage1.Controls.Add(this.changeDepartmentButton);
            this.tabPage1.Controls.Add(this.addDepartmentButton);
            this.tabPage1.Controls.Add(this.Find);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(807, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Подразделения";
            // 
            // removeDepartmentButton
            // 
            this.removeDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeDepartmentButton.Location = new System.Drawing.Point(228, 440);
            this.removeDepartmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeDepartmentButton.Name = "removeDepartmentButton";
            this.removeDepartmentButton.Size = new System.Drawing.Size(100, 28);
            this.removeDepartmentButton.TabIndex = 5;
            this.removeDepartmentButton.Text = "Удалить";
            this.removeDepartmentButton.UseVisualStyleBackColor = true;
            this.removeDepartmentButton.Click += new System.EventHandler(this.removeDepartmentButton_Click);
            // 
            // changeDepartmentButton
            // 
            this.changeDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeDepartmentButton.Location = new System.Drawing.Point(120, 440);
            this.changeDepartmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeDepartmentButton.Name = "changeDepartmentButton";
            this.changeDepartmentButton.Size = new System.Drawing.Size(100, 28);
            this.changeDepartmentButton.TabIndex = 4;
            this.changeDepartmentButton.Text = "Изменить";
            this.changeDepartmentButton.UseVisualStyleBackColor = true;
            this.changeDepartmentButton.Click += new System.EventHandler(this.changeDepartmentButton_Click);
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addDepartmentButton.Location = new System.Drawing.Point(12, 440);
            this.addDepartmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Size = new System.Drawing.Size(100, 28);
            this.addDepartmentButton.TabIndex = 3;
            this.addDepartmentButton.Text = "Добавить";
            this.addDepartmentButton.UseVisualStyleBackColor = true;
            this.addDepartmentButton.Click += new System.EventHandler(this.addDepartmentButton_Click);
            // 
            // Find
            // 
            this.Find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Find.Location = new System.Drawing.Point(646, 21);
            this.Find.Margin = new System.Windows.Forms.Padding(4);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(150, 28);
            this.Find.TabIndex = 1;
            this.Find.Text = "Найти";
            this.Find.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(13, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(628, 27);
            this.textBox1.TabIndex = 0;
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
            this.tabPage2.Size = new System.Drawing.Size(733, 406);
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
            this.removeEmployeeButton.Click += new System.EventHandler(this.removeEmployeeButton_Click);
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
            this.changeEmployeeButton.Click += new System.EventHandler(this.changeEmployeeButton_Click);
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
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
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
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(13, 55);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(784, 378);
            this.treeView1.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.removeButton);
            this.tabPage3.Controls.Add(this.changeButton);
            this.tabPage3.Controls.Add(this.userGridView);
            this.tabPage3.Controls.Add(this.menuStrip1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(733, 406);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пользователи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникToolStripMenuItem,
            this.менеджерToolStripMenuItem,
            this.администраторToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // сотрудникToolStripMenuItem
            // 
            this.сотрудникToolStripMenuItem.Name = "сотрудникToolStripMenuItem";
            this.сотрудникToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.сотрудникToolStripMenuItem.Text = "Сотрудник";
            // 
            // менеджерToolStripMenuItem
            // 
            this.менеджерToolStripMenuItem.Name = "менеджерToolStripMenuItem";
            this.менеджерToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.менеджерToolStripMenuItem.Text = "Менеджер";
            // 
            // администраторToolStripMenuItem
            // 
            this.администраторToolStripMenuItem.Name = "администраторToolStripMenuItem";
            this.администраторToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.администраторToolStripMenuItem.Text = "Администратор";
            // 
            // userGridView
            // 
            this.userGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(7, 35);
            this.userGridView.Name = "userGridView";
            this.userGridView.RowTemplate.Height = 24;
            this.userGridView.Size = new System.Drawing.Size(716, 333);
            this.userGridView.TabIndex = 1;
            // 
            // changeButton
            // 
            this.changeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeButton.AutoSize = true;
            this.changeButton.Location = new System.Drawing.Point(7, 374);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(82, 27);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.AutoSize = true;
            this.removeButton.Location = new System.Drawing.Point(95, 374);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 27);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 449);
            this.Controls.Add(this.userTab);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администрирование";
            this.userTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl userTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менеджерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администраторToolStripMenuItem;
    }
}