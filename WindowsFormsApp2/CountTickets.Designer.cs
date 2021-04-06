
namespace WindowsFormsApp2
{
    partial class CountTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountTickets));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getCountTicketsDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new WindowsFormsApp2.cinemaDataSet();
            this.getCountTicketsDatesTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.getCountTicketsDatesTableAdapter();
            this.period = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.getCountTicketsDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CountTickets";
            reportDataSource1.Value = this.getCountTicketsDatesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.CountTickets.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(650, 334);
            this.reportViewer1.TabIndex = 0;
            // 
            // getCountTicketsDatesBindingSource
            // 
            this.getCountTicketsDatesBindingSource.DataMember = "getCountTicketsDates";
            this.getCountTicketsDatesBindingSource.DataSource = this.cinemaDataSet;
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "cinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getCountTicketsDatesTableAdapter
            // 
            this.getCountTicketsDatesTableAdapter.ClearBeforeFill = true;
            // 
            // period
            // 
            this.period.AutoSize = true;
            this.period.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.period.ForeColor = System.Drawing.Color.MidnightBlue;
            this.period.Location = new System.Drawing.Point(305, 3);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(51, 19);
            this.period.TabIndex = 1;
            this.period.Text = "label1";
            // 
            // CountTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 334);
            this.Controls.Add(this.period);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CountTickets";
            this.Text = "Купленные билеты";
            this.Load += new System.EventHandler(this.CountTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getCountTicketsDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getCountTicketsDatesBindingSource;
        private cinemaDataSet cinemaDataSet;
        private cinemaDataSetTableAdapters.getCountTicketsDatesTableAdapter getCountTicketsDatesTableAdapter;
        private System.Windows.Forms.Label period;
    }
}