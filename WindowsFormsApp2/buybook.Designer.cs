namespace WindowsFormsApp2
{
    partial class buybook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buybook));
            this.customers_bookDataGridView = new System.Windows.Forms.DataGridView();
            this.cinemaDataSet = new WindowsFormsApp2.cinemaDataSet();
            this.buybooking = new System.Windows.Forms.Button();
            this.get_bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_bookingTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.get_bookingTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.cinemaDataSetTableAdapters.TableAdapterManager();
            this.movieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customers_bookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_bookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customers_bookDataGridView
            // 
            this.customers_bookDataGridView.AllowUserToAddRows = false;
            this.customers_bookDataGridView.AllowUserToDeleteRows = false;
            this.customers_bookDataGridView.AllowUserToResizeColumns = false;
            this.customers_bookDataGridView.AllowUserToResizeRows = false;
            this.customers_bookDataGridView.AutoGenerateColumns = false;
            this.customers_bookDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customers_bookDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customers_bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customers_bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieDataGridViewTextBoxColumn,
            this.rowDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.zalDataGridViewTextBoxColumn});
            this.customers_bookDataGridView.DataSource = this.get_bookingBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customers_bookDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.customers_bookDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.customers_bookDataGridView.Location = new System.Drawing.Point(12, 63);
            this.customers_bookDataGridView.MultiSelect = false;
            this.customers_bookDataGridView.Name = "customers_bookDataGridView";
            this.customers_bookDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.customers_bookDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.customers_bookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customers_bookDataGridView.Size = new System.Drawing.Size(926, 392);
            this.customers_bookDataGridView.TabIndex = 2;
            this.customers_bookDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customers_bookDataGridView_CellClick);
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "cinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buybooking
            // 
            this.buybooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.buybooking.Enabled = false;
            this.buybooking.FlatAppearance.BorderSize = 0;
            this.buybooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buybooking.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buybooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buybooking.Location = new System.Drawing.Point(12, 11);
            this.buybooking.Name = "buybooking";
            this.buybooking.Size = new System.Drawing.Size(207, 46);
            this.buybooking.TabIndex = 3;
            this.buybooking.Text = "ВЫКУПИТЬ БРОНЬ";
            this.buybooking.UseVisualStyleBackColor = false;
            this.buybooking.Click += new System.EventHandler(this.buybooking_Click);
            // 
            // get_bookingBindingSource
            // 
            this.get_bookingBindingSource.DataMember = "get_booking";
            this.get_bookingBindingSource.DataSource = this.cinemaDataSet;
            // 
            // get_bookingTableAdapter
            // 
            this.get_bookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookingsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.countriesTableAdapter = null;
            this.tableAdapterManager.genresTableAdapter = null;
            this.tableAdapterManager.movie_countriesTableAdapter = null;
            this.tableAdapterManager.movie_genresTableAdapter = null;
            this.tableAdapterManager.moviesTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.seatsTableAdapter = null;
            this.tableAdapterManager.showsTableAdapter = null;
            this.tableAdapterManager.ticketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.cinemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // movieDataGridViewTextBoxColumn
            // 
            this.movieDataGridViewTextBoxColumn.DataPropertyName = "movie";
            this.movieDataGridViewTextBoxColumn.HeaderText = "movie";
            this.movieDataGridViewTextBoxColumn.Name = "movieDataGridViewTextBoxColumn";
            this.movieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rowDataGridViewTextBoxColumn
            // 
            this.rowDataGridViewTextBoxColumn.DataPropertyName = "row";
            this.rowDataGridViewTextBoxColumn.HeaderText = "row";
            this.rowDataGridViewTextBoxColumn.Name = "rowDataGridViewTextBoxColumn";
            this.rowDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "start_time";
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            this.starttimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formatDataGridViewTextBoxColumn
            // 
            this.formatDataGridViewTextBoxColumn.DataPropertyName = "format";
            this.formatDataGridViewTextBoxColumn.HeaderText = "format";
            this.formatDataGridViewTextBoxColumn.Name = "formatDataGridViewTextBoxColumn";
            this.formatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zalDataGridViewTextBoxColumn
            // 
            this.zalDataGridViewTextBoxColumn.DataPropertyName = "zal";
            this.zalDataGridViewTextBoxColumn.HeaderText = "zal";
            this.zalDataGridViewTextBoxColumn.Name = "zalDataGridViewTextBoxColumn";
            this.zalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buybook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(986, 467);
            this.Controls.Add(this.buybooking);
            this.Controls.Add(this.customers_bookDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "buybook";
            this.Text = "Выкуп брони";
            this.Load += new System.EventHandler(this.buybook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customers_bookDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_bookingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private cinemaDataSet cinemaDataSet;
        private System.Windows.Forms.DataGridView customers_bookDataGridView;
        private System.Windows.Forms.Button buybooking;
        private System.Windows.Forms.BindingSource get_bookingBindingSource;
        private cinemaDataSetTableAdapters.get_bookingTableAdapter get_bookingTableAdapter;
        private cinemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zalDataGridViewTextBoxColumn;
    }
}