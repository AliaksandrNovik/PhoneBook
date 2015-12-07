namespace UI.EmployeeUI.Forms
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
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selfStatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchLine = new System.Windows.Forms.TextBox();
            this.statisticStrip = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statisticStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(367, 34);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 26);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(505, 197);
            this.dataGridView1.TabIndex = 7;
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
            this.searchLine.Size = new System.Drawing.Size(349, 22);
            this.searchLine.TabIndex = 6;
            // 
            // statisticStrip
            // 
            this.statisticStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statisticStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selfStatToolStripMenuItem});
            this.statisticStrip.Location = new System.Drawing.Point(0, 0);
            this.statisticStrip.Name = "statisticStrip";
            this.statisticStrip.Size = new System.Drawing.Size(529, 28);
            this.statisticStrip.TabIndex = 5;
            this.statisticStrip.Text = "menuStrip1";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 273);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchLine);
            this.Controls.Add(this.statisticStrip);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statisticStrip.ResumeLayout(false);
            this.statisticStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem selfStatToolStripMenuItem;
        private System.Windows.Forms.TextBox searchLine;
        private System.Windows.Forms.MenuStrip statisticStrip;
    }
}