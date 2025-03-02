namespace PrintQtrylyReport
{
    partial class QtrlyReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qtrlysalescommearnedvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData_QtrlySPCommReport = new PrintQtrylyReport.AppData_QtrlySPCommReport();
            this.qtrly_sales_comm_earned_vTableAdapter = new PrintQtrylyReport.AppData_QtrlySPCommReportTableAdapters.qtrly_sales_comm_earned_vTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.salespersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quarterlyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissionEarnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.appDataQtrSalReport = new PrintQtrylyReport.AppDataQtrSalReport();
            this.qtrlysalescommearnedvBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qtrly_sales_comm_earned_vTableAdapter1 = new PrintQtrylyReport.AppDataQtrSalReportTableAdapters.qtrly_sales_comm_earned_vTableAdapter();
            this.salespersonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quarterlyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissionEarnedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtrlysalescommearnedvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData_QtrlySPCommReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataQtrSalReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtrlysalescommearnedvBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salespersonDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.quarterlyDataGridViewTextBoxColumn,
            this.commissionEarnedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.qtrlysalescommearnedvBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 91);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // qtrlysalescommearnedvBindingSource
            // 
            this.qtrlysalescommearnedvBindingSource.DataMember = "qtrly_sales_comm_earned_v";
            this.qtrlysalescommearnedvBindingSource.DataSource = this.appData_QtrlySPCommReport;
            // 
            // appData_QtrlySPCommReport
            // 
            this.appData_QtrlySPCommReport.DataSetName = "AppData_QtrlySPCommReport";
            this.appData_QtrlySPCommReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qtrly_sales_comm_earned_vTableAdapter
            // 
            this.qtrly_sales_comm_earned_vTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quarterly Sales Person Commission Report";
            // 
            // salespersonDataGridViewTextBoxColumn
            // 
            this.salespersonDataGridViewTextBoxColumn.DataPropertyName = "sales_person";
            this.salespersonDataGridViewTextBoxColumn.HeaderText = "Sales Person";
            this.salespersonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salespersonDataGridViewTextBoxColumn.Name = "salespersonDataGridViewTextBoxColumn";
            this.salespersonDataGridViewTextBoxColumn.Width = 175;
            // 
            // prodnameDataGridViewTextBoxColumn
            // 
            this.prodnameDataGridViewTextBoxColumn.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.prodnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodnameDataGridViewTextBoxColumn.Name = "prodnameDataGridViewTextBoxColumn";
            this.prodnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quarterlyDataGridViewTextBoxColumn
            // 
            this.quarterlyDataGridViewTextBoxColumn.DataPropertyName = "Quarterly";
            this.quarterlyDataGridViewTextBoxColumn.HeaderText = "Quarter";
            this.quarterlyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quarterlyDataGridViewTextBoxColumn.Name = "quarterlyDataGridViewTextBoxColumn";
            this.quarterlyDataGridViewTextBoxColumn.Width = 60;
            // 
            // commissionEarnedDataGridViewTextBoxColumn
            // 
            this.commissionEarnedDataGridViewTextBoxColumn.DataPropertyName = "Commission_Earned";
            this.commissionEarnedDataGridViewTextBoxColumn.HeaderText = "Commission Earned $";
            this.commissionEarnedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commissionEarnedDataGridViewTextBoxColumn.Name = "commissionEarnedDataGridViewTextBoxColumn";
            this.commissionEarnedDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salespersonDataGridViewTextBoxColumn1,
            this.prodnameDataGridViewTextBoxColumn1,
            this.quarterlyDataGridViewTextBoxColumn1,
            this.commissionEarnedDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.qtrlysalescommearnedvBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(59, 119);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(888, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // appDataQtrSalReport
            // 
            this.appDataQtrSalReport.DataSetName = "AppDataQtrSalReport";
            this.appDataQtrSalReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qtrlysalescommearnedvBindingSource1
            // 
            this.qtrlysalescommearnedvBindingSource1.DataMember = "qtrly_sales_comm_earned_v";
            this.qtrlysalescommearnedvBindingSource1.DataSource = this.appDataQtrSalReport;
            // 
            // qtrly_sales_comm_earned_vTableAdapter1
            // 
            this.qtrly_sales_comm_earned_vTableAdapter1.ClearBeforeFill = true;
            // 
            // salespersonDataGridViewTextBoxColumn1
            // 
            this.salespersonDataGridViewTextBoxColumn1.DataPropertyName = "sales_person";
            this.salespersonDataGridViewTextBoxColumn1.HeaderText = "Sales Person";
            this.salespersonDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.salespersonDataGridViewTextBoxColumn1.Name = "salespersonDataGridViewTextBoxColumn1";
            this.salespersonDataGridViewTextBoxColumn1.Width = 125;
            // 
            // prodnameDataGridViewTextBoxColumn1
            // 
            this.prodnameDataGridViewTextBoxColumn1.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn1.HeaderText = "Product Name";
            this.prodnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prodnameDataGridViewTextBoxColumn1.Name = "prodnameDataGridViewTextBoxColumn1";
            this.prodnameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // quarterlyDataGridViewTextBoxColumn1
            // 
            this.quarterlyDataGridViewTextBoxColumn1.DataPropertyName = "Quarterly";
            this.quarterlyDataGridViewTextBoxColumn1.HeaderText = "Quarter";
            this.quarterlyDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.quarterlyDataGridViewTextBoxColumn1.Name = "quarterlyDataGridViewTextBoxColumn1";
            this.quarterlyDataGridViewTextBoxColumn1.Width = 125;
            // 
            // commissionEarnedDataGridViewTextBoxColumn1
            // 
            this.commissionEarnedDataGridViewTextBoxColumn1.DataPropertyName = "Commission_Earned";
            this.commissionEarnedDataGridViewTextBoxColumn1.HeaderText = "Commission Earned $";
            this.commissionEarnedDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.commissionEarnedDataGridViewTextBoxColumn1.Name = "commissionEarnedDataGridViewTextBoxColumn1";
            this.commissionEarnedDataGridViewTextBoxColumn1.Width = 170;
            // 
            // QtrlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 533);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QtrlyReport";
            this.Text = "QtrlyReport";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtrlysalescommearnedvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData_QtrlySPCommReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataQtrSalReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtrlysalescommearnedvBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AppData_QtrlySPCommReport appData_QtrlySPCommReport;
        private System.Windows.Forms.BindingSource qtrlysalescommearnedvBindingSource;
        private AppData_QtrlySPCommReportTableAdapters.qtrly_sales_comm_earned_vTableAdapter qtrly_sales_comm_earned_vTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salespersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quarterlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commissionEarnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private AppDataQtrSalReport appDataQtrSalReport;
        private System.Windows.Forms.BindingSource qtrlysalescommearnedvBindingSource1;
        private AppDataQtrSalReportTableAdapters.qtrly_sales_comm_earned_vTableAdapter qtrly_sales_comm_earned_vTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salespersonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quarterlyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commissionEarnedDataGridViewTextBoxColumn1;
    }
}

