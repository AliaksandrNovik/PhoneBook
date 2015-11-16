namespace UI.Forms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selfStatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneBook = new UI.Controls.PhoneBook();
            this.process1 = new System.Diagnostics.Process();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selfStatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selfStatToolStripMenuItem
            // 
            this.selfStatToolStripMenuItem.Name = "selfStatToolStripMenuItem";
            this.selfStatToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.selfStatToolStripMenuItem.Text = "Личная статистика";
            // 
            // phoneBook
            // 
            this.phoneBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.phoneBook.Location = new System.Drawing.Point(0, 28);
            this.phoneBook.Margin = new System.Windows.Forms.Padding(0);
            this.phoneBook.Name = "phoneBook";
            this.phoneBook.Padding = new System.Windows.Forms.Padding(10);
            this.phoneBook.Size = new System.Drawing.Size(479, 216);
            this.phoneBook.TabIndex = 0;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 253);
            this.Controls.Add(this.phoneBook);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "EmployeeForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selfStatToolStripMenuItem;
        private Controls.PhoneBook phoneBook;
        private System.Diagnostics.Process process1;
    }
}