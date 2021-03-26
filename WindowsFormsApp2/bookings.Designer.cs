namespace WindowsFormsApp2
{
    partial class bookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookings));
            this.get_bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new WindowsFormsApp2.cinemaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.openbuybook = new System.Windows.Forms.Button();
            this.get_bookingTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.get_bookingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.get_bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // get_bookingBindingSource
            // 
            this.get_bookingBindingSource.DataMember = "get_booking";
            this.get_bookingBindingSource.DataSource = this.cinemaDataSet;
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "cinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.get_bookingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.bookingguest.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(517, 501);
            this.reportViewer1.TabIndex = 0;
            // 
            // openbuybook
            // 
            this.openbuybook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.openbuybook.FlatAppearance.BorderSize = 0;
            this.openbuybook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openbuybook.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openbuybook.ForeColor = System.Drawing.SystemColors.Control;
            this.openbuybook.Location = new System.Drawing.Point(152, 12);
            this.openbuybook.Name = "openbuybook";
            this.openbuybook.Size = new System.Drawing.Size(207, 46);
            this.openbuybook.TabIndex = 1;
            this.openbuybook.Text = "ВЫКУПИТЬ БРОНЬ";
            this.openbuybook.UseVisualStyleBackColor = false;
            this.openbuybook.Click += new System.EventHandler(this.openbuybook_Click);
            // 
            // get_bookingTableAdapter
            // 
            this.get_bookingTableAdapter.ClearBeforeFill = true;
            // 
            // bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(541, 592);
            this.Controls.Add(this.openbuybook);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bookings";
            this.Text = "Брони";
            this.Load += new System.EventHandler(this.bookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.get_bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private cinemaDataSet cinemaDataSet;
        private System.Windows.Forms.Button openbuybook;
        private System.Windows.Forms.BindingSource get_bookingBindingSource;
        private cinemaDataSetTableAdapters.get_bookingTableAdapter get_bookingTableAdapter;
    }
}