namespace UI.StatisticUI.Forms
{
    partial class PersonalStatistic
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneLine = new System.Windows.Forms.Label();
            this.departmentLine = new System.Windows.Forms.Label();
            this.employeeLine = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.summaryPrice = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.phoneStatTable = new System.Windows.Forms.DataGridView();
            this.dateAndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationInSecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerMinuteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statSource = new System.Windows.Forms.BindingSource(this.components);
            this.toWord = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStatTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.61238F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.38762F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.phoneLine, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.departmentLine, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.employeeLine, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 61);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Подразделение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сотрудник";
            // 
            // phoneLine
            // 
            this.phoneLine.AutoSize = true;
            this.phoneLine.Location = new System.Drawing.Point(127, 0);
            this.phoneLine.Name = "phoneLine";
            this.phoneLine.Size = new System.Drawing.Size(0, 17);
            this.phoneLine.TabIndex = 3;
            // 
            // departmentLine
            // 
            this.departmentLine.AutoSize = true;
            this.departmentLine.Location = new System.Drawing.Point(127, 20);
            this.departmentLine.Name = "departmentLine";
            this.departmentLine.Size = new System.Drawing.Size(0, 17);
            this.departmentLine.TabIndex = 4;
            // 
            // employeeLine
            // 
            this.employeeLine.AutoSize = true;
            this.employeeLine.Location = new System.Drawing.Point(127, 40);
            this.employeeLine.Name = "employeeLine";
            this.employeeLine.Size = new System.Drawing.Size(0, 17);
            this.employeeLine.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.summaryPrice,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 365);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(772, 33);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 28);
            this.toolStripStatusLabel1.Text = "ИТОГО";
            // 
            // summaryPrice
            // 
            this.summaryPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.summaryPrice.Name = "summaryPrice";
            this.summaryPrice.Size = new System.Drawing.Size(685, 28);
            this.summaryPrice.Spring = true;
            this.summaryPrice.Text = "0";
            this.summaryPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(5, 28);
            // 
            // phoneStatTable
            // 
            this.phoneStatTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneStatTable.AutoGenerateColumns = false;
            this.phoneStatTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phoneStatTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneStatTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateAndTimeDataGridViewTextBoxColumn,
            this.targetPhoneDataGridViewTextBoxColumn,
            this.durationInSecondsDataGridViewTextBoxColumn,
            this.pricePerMinuteDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.phoneStatTable.DataSource = this.statSource;
            this.phoneStatTable.Location = new System.Drawing.Point(5, 74);
            this.phoneStatTable.Name = "phoneStatTable";
            this.phoneStatTable.RowTemplate.Height = 24;
            this.phoneStatTable.Size = new System.Drawing.Size(755, 249);
            this.phoneStatTable.TabIndex = 6;
            // 
            // dateAndTimeDataGridViewTextBoxColumn
            // 
            this.dateAndTimeDataGridViewTextBoxColumn.DataPropertyName = "DateAndTime";
            this.dateAndTimeDataGridViewTextBoxColumn.HeaderText = "Дата и время";
            this.dateAndTimeDataGridViewTextBoxColumn.Name = "dateAndTimeDataGridViewTextBoxColumn";
            this.dateAndTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // targetPhoneDataGridViewTextBoxColumn
            // 
            this.targetPhoneDataGridViewTextBoxColumn.DataPropertyName = "TargetPhone";
            this.targetPhoneDataGridViewTextBoxColumn.HeaderText = "Абонент";
            this.targetPhoneDataGridViewTextBoxColumn.Name = "targetPhoneDataGridViewTextBoxColumn";
            this.targetPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationInSecondsDataGridViewTextBoxColumn
            // 
            this.durationInSecondsDataGridViewTextBoxColumn.DataPropertyName = "DurationInSeconds";
            this.durationInSecondsDataGridViewTextBoxColumn.HeaderText = "Длительность, сек";
            this.durationInSecondsDataGridViewTextBoxColumn.Name = "durationInSecondsDataGridViewTextBoxColumn";
            this.durationInSecondsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pricePerMinuteDataGridViewTextBoxColumn
            // 
            this.pricePerMinuteDataGridViewTextBoxColumn.DataPropertyName = "PricePerMinute";
            this.pricePerMinuteDataGridViewTextBoxColumn.HeaderText = "Тариф, руб./мин.";
            this.pricePerMinuteDataGridViewTextBoxColumn.Name = "pricePerMinuteDataGridViewTextBoxColumn";
            this.pricePerMinuteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Сумма, руб.";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statSource
            // 
            this.statSource.DataSource = typeof(Services.Facade.ICallSession);
            // 
            // toWord
            // 
            this.toWord.Location = new System.Drawing.Point(685, 329);
            this.toWord.Name = "toWord";
            this.toWord.Size = new System.Drawing.Size(75, 23);
            this.toWord.TabIndex = 7;
            this.toWord.Text = "Word";
            this.toWord.UseVisualStyleBackColor = true;
            this.toWord.Click += new System.EventHandler(this.toWord_Click);
            // 
            // PersonalStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 398);
            this.Controls.Add(this.toWord);
            this.Controls.Add(this.phoneStatTable);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "PersonalStatistic";
            this.Text = "Статистика";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStatTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label phoneLine;
        private System.Windows.Forms.Label departmentLine;
        private System.Windows.Forms.Label employeeLine;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel summaryPrice;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.DataGridView phoneStatTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationInSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerMinuteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource statSource;
        private System.Windows.Forms.Button toWord;
    }
}