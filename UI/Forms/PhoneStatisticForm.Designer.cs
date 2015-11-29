namespace UI.Forms
{
    partial class PhoneStatisticForm
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
            this.phoneStatGridView = new System.Windows.Forms.DataGridView();
            this.phoneStatSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateAndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationInSecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerMinuteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStatGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStatSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.phoneLine, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.departmentLine, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.employeeLine, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 61);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.phoneLine.Location = new System.Drawing.Point(134, 0);
            this.phoneLine.Name = "phoneLine";
            this.phoneLine.Size = new System.Drawing.Size(0, 17);
            this.phoneLine.TabIndex = 3;
            // 
            // departmentLine
            // 
            this.departmentLine.AutoSize = true;
            this.departmentLine.Location = new System.Drawing.Point(134, 20);
            this.departmentLine.Name = "departmentLine";
            this.departmentLine.Size = new System.Drawing.Size(0, 17);
            this.departmentLine.TabIndex = 4;
            // 
            // employeeLine
            // 
            this.employeeLine.AutoSize = true;
            this.employeeLine.Location = new System.Drawing.Point(134, 40);
            this.employeeLine.Name = "employeeLine";
            this.employeeLine.Size = new System.Drawing.Size(0, 17);
            this.employeeLine.TabIndex = 5;
            // 
            // phoneStatGridView
            // 
            this.phoneStatGridView.AllowUserToAddRows = false;
            this.phoneStatGridView.AllowUserToDeleteRows = false;
            this.phoneStatGridView.AllowUserToOrderColumns = true;
            this.phoneStatGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneStatGridView.AutoGenerateColumns = false;
            this.phoneStatGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phoneStatGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.phoneStatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneStatGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateAndTimeDataGridViewTextBoxColumn,
            this.durationInSecondsDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.pricePerMinuteDataGridViewTextBoxColumn,
            this.summaryPriceDataGridViewTextBoxColumn});
            this.phoneStatGridView.DataSource = this.phoneStatSource;
            this.phoneStatGridView.Location = new System.Drawing.Point(12, 79);
            this.phoneStatGridView.Name = "phoneStatGridView";
            this.phoneStatGridView.ReadOnly = true;
            this.phoneStatGridView.RowTemplate.Height = 24;
            this.phoneStatGridView.Size = new System.Drawing.Size(806, 384);
            this.phoneStatGridView.TabIndex = 1;
            // 
            // phoneStatSource
            // 
            this.phoneStatSource.AllowNew = false;
            this.phoneStatSource.DataSource = typeof(UI.Views.StatisticItem);
            // 
            // dateAndTimeDataGridViewTextBoxColumn
            // 
            this.dateAndTimeDataGridViewTextBoxColumn.DataPropertyName = "DateAndTime + DurationInSeconds";
            this.dateAndTimeDataGridViewTextBoxColumn.HeaderText = "Дата и время";
            this.dateAndTimeDataGridViewTextBoxColumn.Name = "dateAndTimeDataGridViewTextBoxColumn";
            this.dateAndTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateAndTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // durationInSecondsDataGridViewTextBoxColumn
            // 
            this.durationInSecondsDataGridViewTextBoxColumn.DataPropertyName = "DurationInSeconds";
            this.durationInSecondsDataGridViewTextBoxColumn.HeaderText = "Длительность, сек";
            this.durationInSecondsDataGridViewTextBoxColumn.Name = "durationInSecondsDataGridViewTextBoxColumn";
            this.durationInSecondsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Абонент";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pricePerMinuteDataGridViewTextBoxColumn
            // 
            this.pricePerMinuteDataGridViewTextBoxColumn.DataPropertyName = "PricePerMinute";
            this.pricePerMinuteDataGridViewTextBoxColumn.HeaderText = "Тариф, руб/мин";
            this.pricePerMinuteDataGridViewTextBoxColumn.Name = "pricePerMinuteDataGridViewTextBoxColumn";
            this.pricePerMinuteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summaryPriceDataGridViewTextBoxColumn
            // 
            this.summaryPriceDataGridViewTextBoxColumn.DataPropertyName = "SummaryPrice";
            this.summaryPriceDataGridViewTextBoxColumn.HeaderText = "Сумма, руб.";
            this.summaryPriceDataGridViewTextBoxColumn.Name = "summaryPriceDataGridViewTextBoxColumn";
            this.summaryPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PhoneStatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 475);
            this.Controls.Add(this.phoneStatGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PhoneStatisticForm";
            this.Text = "PhoneStatisticForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStatGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStatSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label phoneLine;
        private System.Windows.Forms.Label departmentLine;
        private System.Windows.Forms.Label employeeLine;
        private System.Windows.Forms.DataGridView phoneStatGridView;
        private System.Windows.Forms.BindingSource phoneStatSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationInSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerMinuteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryPriceDataGridViewTextBoxColumn;
    }
}