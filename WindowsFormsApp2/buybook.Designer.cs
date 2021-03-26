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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фильмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.форматDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяНачалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рядDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new WindowsFormsApp2.cinemaDataSet();
            this.buybooking = new System.Windows.Forms.Button();
            this.customers_bookTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.customers_bookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customers_bookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersbookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
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
            this.idDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.фильмDataGridViewTextBoxColumn,
            this.форматDataGridViewTextBoxColumn,
            this.времяНачалаDataGridViewTextBoxColumn,
            this.рядDataGridViewTextBoxColumn,
            this.местоDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.bookingIDDataGridViewTextBoxColumn});
            this.customers_bookDataGridView.DataSource = this.customersbookBindingSource;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // фильмDataGridViewTextBoxColumn
            // 
            this.фильмDataGridViewTextBoxColumn.DataPropertyName = "Фильм";
            this.фильмDataGridViewTextBoxColumn.HeaderText = "Фильм";
            this.фильмDataGridViewTextBoxColumn.Name = "фильмDataGridViewTextBoxColumn";
            this.фильмDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // форматDataGridViewTextBoxColumn
            // 
            this.форматDataGridViewTextBoxColumn.DataPropertyName = "Формат";
            this.форматDataGridViewTextBoxColumn.HeaderText = "Формат";
            this.форматDataGridViewTextBoxColumn.Name = "форматDataGridViewTextBoxColumn";
            this.форматDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // времяНачалаDataGridViewTextBoxColumn
            // 
            this.времяНачалаDataGridViewTextBoxColumn.DataPropertyName = "Время начала";
            this.времяНачалаDataGridViewTextBoxColumn.HeaderText = "Время начала";
            this.времяНачалаDataGridViewTextBoxColumn.Name = "времяНачалаDataGridViewTextBoxColumn";
            this.времяНачалаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // рядDataGridViewTextBoxColumn
            // 
            this.рядDataGridViewTextBoxColumn.DataPropertyName = "Ряд";
            this.рядDataGridViewTextBoxColumn.HeaderText = "Ряд";
            this.рядDataGridViewTextBoxColumn.Name = "рядDataGridViewTextBoxColumn";
            this.рядDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // местоDataGridViewTextBoxColumn
            // 
            this.местоDataGridViewTextBoxColumn.DataPropertyName = "Место";
            this.местоDataGridViewTextBoxColumn.HeaderText = "Место";
            this.местоDataGridViewTextBoxColumn.Name = "местоDataGridViewTextBoxColumn";
            this.местоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "bookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "bookingID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // customersbookBindingSource
            // 
            this.customersbookBindingSource.DataMember = "customers_book";
            this.customersbookBindingSource.DataSource = this.cinemaDataSet;
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
            // customers_bookTableAdapter
            // 
            this.customers_bookTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.customersbookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private cinemaDataSet cinemaDataSet;
        private System.Windows.Forms.DataGridView customers_bookDataGridView;
        private System.Windows.Forms.Button buybooking;
        private System.Windows.Forms.BindingSource customersbookBindingSource;
        private cinemaDataSetTableAdapters.customers_bookTableAdapter customers_bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фильмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn форматDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяНачалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рядDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
    }
}