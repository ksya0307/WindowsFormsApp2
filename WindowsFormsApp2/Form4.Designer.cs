namespace WindowsFormsApp2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.opentickets = new System.Windows.Forms.Button();
            this.opensales = new System.Windows.Forms.Button();
            this.schedule = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.book = new System.Windows.Forms.Button();
            this.buy = new System.Windows.Forms.Button();
            this.openbookings = new System.Windows.Forms.Button();
            this.scheduleViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new WindowsFormsApp2.cinemaDataSet();
            this.scheduleViewTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.scheduleViewTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.cinemaDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(119)))));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.exit.Location = new System.Drawing.Point(1122, 13);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(82, 32);
            this.exit.TabIndex = 6;
            this.exit.Text = "выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(959, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // opentickets
            // 
            this.opentickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.opentickets.FlatAppearance.BorderSize = 0;
            this.opentickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opentickets.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opentickets.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.opentickets.Location = new System.Drawing.Point(134, 12);
            this.opentickets.Name = "opentickets";
            this.opentickets.Size = new System.Drawing.Size(82, 35);
            this.opentickets.TabIndex = 9;
            this.opentickets.Text = "Билеты";
            this.opentickets.UseVisualStyleBackColor = false;
            this.opentickets.Click += new System.EventHandler(this.opentickets_Click);
            // 
            // opensales
            // 
            this.opensales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.opensales.FlatAppearance.BorderSize = 0;
            this.opensales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opensales.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opensales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.opensales.Location = new System.Drawing.Point(310, 12);
            this.opensales.Name = "opensales";
            this.opensales.Size = new System.Drawing.Size(82, 35);
            this.opensales.TabIndex = 10;
            this.opensales.Text = "Акции";
            this.opensales.UseVisualStyleBackColor = false;
            this.opensales.Click += new System.EventHandler(this.opensales_Click);
            // 
            // schedule
            // 
            this.schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.schedule.FlatAppearance.BorderSize = 0;
            this.schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.schedule.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.schedule.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.schedule.Location = new System.Drawing.Point(15, 12);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(113, 35);
            this.schedule.TabIndex = 8;
            this.schedule.Text = "Расписание";
            this.schedule.UseVisualStyleBackColor = false;
            this.schedule.Click += new System.EventHandler(this.schedule_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(254, 64);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(950, 489);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(15, 64);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.main;
            this.pictureBox1.Location = new System.Drawing.Point(254, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(873, 489);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // book
            // 
            this.book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.book.FlatAppearance.BorderSize = 0;
            this.book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.book.Location = new System.Drawing.Point(12, 279);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(167, 35);
            this.book.TabIndex = 15;
            this.book.Text = "ЗАБРОНИРОВАТЬ";
            this.book.UseVisualStyleBackColor = false;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // buy
            // 
            this.buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.buy.FlatAppearance.BorderSize = 0;
            this.buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buy.Location = new System.Drawing.Point(12, 238);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(167, 35);
            this.buy.TabIndex = 16;
            this.buy.Text = "КУПИТЬ";
            this.buy.UseVisualStyleBackColor = false;
            this.buy.Click += new System.EventHandler(this.buy_Click_1);
            // 
            // openbookings
            // 
            this.openbookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.openbookings.FlatAppearance.BorderSize = 0;
            this.openbookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openbookings.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openbookings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.openbookings.Location = new System.Drawing.Point(222, 12);
            this.openbookings.Name = "openbookings";
            this.openbookings.Size = new System.Drawing.Size(82, 35);
            this.openbookings.TabIndex = 17;
            this.openbookings.Text = "Брони";
            this.openbookings.UseVisualStyleBackColor = false;
            this.openbookings.Click += new System.EventHandler(this.openbookings_Click);
            // 
            // scheduleViewBindingSource
            // 
            this.scheduleViewBindingSource.DataMember = "scheduleView";
            this.scheduleViewBindingSource.DataSource = this.cinemaDataSet;
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "cinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleViewTableAdapter
            // 
            this.scheduleViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookingsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.countriesTableAdapter = null;
            this.tableAdapterManager.genresTableAdapter = null;
            this.tableAdapterManager.moviesTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.seatsTableAdapter = null;
            this.tableAdapterManager.showsTableAdapter = null;
            //this.tableAdapterManager.tickets1TableAdapter = null;
            //this.tableAdapterManager.tickets2TableAdapter = null;
            //this.tableAdapterManager.tickets3TableAdapter = null;
            //this.tableAdapterManager.tickets4TableAdapter = null;
            this.tableAdapterManager.ticketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.cinemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1216, 570);
            this.Controls.Add(this.openbookings);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.book);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.opentickets);
            this.Controls.Add(this.opensales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button opentickets;
        private System.Windows.Forms.Button opensales;
        private System.Windows.Forms.Button schedule;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private cinemaDataSet cinemaDataSet;
        private System.Windows.Forms.BindingSource scheduleViewBindingSource;
        private cinemaDataSetTableAdapters.scheduleViewTableAdapter scheduleViewTableAdapter;
        private cinemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Button openbookings;
    }
}