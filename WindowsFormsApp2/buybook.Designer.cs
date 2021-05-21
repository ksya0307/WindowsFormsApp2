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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buybook));
            this.get_bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new WindowsFormsApp2.cinemaDataSet();
            this.buybooking = new System.Windows.Forms.Button();
            this.get_bookingTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.get_bookingTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.cinemaDataSetTableAdapters.TableAdapterManager();
            this.canselbooking = new System.Windows.Forms.Button();
            this.customers_bookDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.get_bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_bookDataGridView)).BeginInit();
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
            // canselbooking
            // 
            this.canselbooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.canselbooking.Enabled = false;
            this.canselbooking.FlatAppearance.BorderSize = 0;
            this.canselbooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canselbooking.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canselbooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.canselbooking.Location = new System.Drawing.Point(225, 11);
            this.canselbooking.Name = "canselbooking";
            this.canselbooking.Size = new System.Drawing.Size(207, 46);
            this.canselbooking.TabIndex = 4;
            this.canselbooking.Text = "ОТМЕНИТЬ БРОНЬ";
            this.canselbooking.UseVisualStyleBackColor = false;
            this.canselbooking.Click += new System.EventHandler(this.canselbooking_Click);
            // 
            // customers_bookDataGridView
            // 
            this.customers_bookDataGridView.AutoGenerateColumns = false;
            this.customers_bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customers_bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.idBook});
            this.customers_bookDataGridView.DataSource = this.get_bookingBindingSource;
            this.customers_bookDataGridView.Location = new System.Drawing.Point(12, 63);
            this.customers_bookDataGridView.Name = "customers_bookDataGridView";
            this.customers_bookDataGridView.Size = new System.Drawing.Size(962, 392);
            this.customers_bookDataGridView.TabIndex = 4;
            this.customers_bookDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customers_bookDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "movie";
            this.dataGridViewTextBoxColumn1.HeaderText = "movie";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "row";
            this.dataGridViewTextBoxColumn2.HeaderText = "row";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn3.HeaderText = "number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "start_time";
            this.dataGridViewTextBoxColumn4.HeaderText = "start_time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn5.HeaderText = "date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "format";
            this.dataGridViewTextBoxColumn6.HeaderText = "format";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn7.HeaderText = "cost";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "zal";
            this.dataGridViewTextBoxColumn8.HeaderText = "zal";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn9.HeaderText = "id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // idBook
            // 
            this.idBook.DataPropertyName = "bookingID";
            this.idBook.HeaderText = "bookingID";
            this.idBook.Name = "idBook";
            this.idBook.ReadOnly = true;
            // 
            // buybook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(986, 467);
            this.Controls.Add(this.customers_bookDataGridView);
            this.Controls.Add(this.canselbooking);
            this.Controls.Add(this.buybooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "buybook";
            this.Text = "Выкуп брони";
            this.Load += new System.EventHandler(this.buybook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.get_bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_bookDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private cinemaDataSet cinemaDataSet;
        private System.Windows.Forms.Button buybooking;
        private System.Windows.Forms.BindingSource get_bookingBindingSource;
        private cinemaDataSetTableAdapters.get_bookingTableAdapter get_bookingTableAdapter;
        private cinemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button canselbooking;
        private System.Windows.Forms.DataGridView customers_bookDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBook;
    }
}