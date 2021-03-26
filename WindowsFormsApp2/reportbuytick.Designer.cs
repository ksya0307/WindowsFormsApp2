namespace WindowsFormsApp2
{
    partial class reportbuytick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportbuytick));
            this.report_buy_ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new WindowsFormsApp2.cinemaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.report_buy_ticketsTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.report_buy_ticketsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.report_buy_ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // report_buy_ticketsBindingSource
            // 
            this.report_buy_ticketsBindingSource.DataMember = "report_buy_tickets";
            this.report_buy_ticketsBindingSource.DataSource = this.cinemaDataSet;
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "cinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.report_buy_ticketsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Reportboutbuytickets.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(494, 421);
            this.reportViewer1.TabIndex = 0;
            // 
            // report_buy_ticketsTableAdapter
            // 
            this.report_buy_ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // reportbuytick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 455);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reportbuytick";
            this.Text = "Отчет о купленных билетах";
            this.Load += new System.EventHandler(this.reportbuytick_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report_buy_ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource report_buy_ticketsBindingSource;
        private cinemaDataSet cinemaDataSet;
        private cinemaDataSetTableAdapters.report_buy_ticketsTableAdapter report_buy_ticketsTableAdapter;
    }
}