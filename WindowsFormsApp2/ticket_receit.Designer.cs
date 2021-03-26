namespace WindowsFormsApp2
{
    partial class ticket_receit
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ticket_receit));
            this.ticket_receitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new WindowsFormsApp2.cinemaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ticket_receitTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.ticket_receitTableAdapter();
            this.getticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ticket_receitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getticketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ticket_receitBindingSource
            // 
            this.ticket_receitBindingSource.DataMember = "ticket_receit";
            this.ticket_receitBindingSource.DataSource = this.cinemaDataSet;
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "cinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ticket_receitBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.tickets.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(355, 466);
            this.reportViewer1.TabIndex = 0;
            // 
            // ticket_receitTableAdapter
            // 
            this.ticket_receitTableAdapter.ClearBeforeFill = true;
            // 
            // getticketBindingSource
            // 
            this.getticketBindingSource.DataMember = "get_ticket";
            this.getticketBindingSource.DataSource = this.cinemaDataSet;
            // 
            // ticket_receit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 490);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ticket_receit";
            this.Text = "БИЛЕТ";
            this.Load += new System.EventHandler(this.ticket_receit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticket_receitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getticketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ticket_receitBindingSource;
        private cinemaDataSet cinemaDataSet;
        private cinemaDataSetTableAdapters.ticket_receitTableAdapter ticket_receitTableAdapter;
        private System.Windows.Forms.BindingSource getticketBindingSource;
    }
}