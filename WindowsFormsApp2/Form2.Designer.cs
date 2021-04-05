namespace WindowsFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.страныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жанрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сеансыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.билетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.брониToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.местаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ролиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильмЖанрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильмСтраныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.билетыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.фильмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сеансыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьОтчетОПроданныхБилетахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.change_tb = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movie_countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsViewTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.ticketsViewTableAdapter();
            this.movie_genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new WindowsFormsApp2.cinemaDataSet();
            this.tableAdapterManager = new WindowsFormsApp2.cinemaDataSetTableAdapters.TableAdapterManager();
            this.bookingsTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.bookingsTableAdapter();
            this.countriesTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.countriesTableAdapter();
            this.genresTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.genresTableAdapter();
            this.moviesTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.moviesTableAdapter();
            this.rolesTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.rolesTableAdapter();
            this.moviesViewTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.moviesViewTableAdapter();
            this.seatsTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.seatsTableAdapter();
            this.showsTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.showsTableAdapter();
            this.showsViewTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.showsViewTableAdapter();
            this.usersTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.usersTableAdapter();
            this.movie_countriesTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.movie_countriesTableAdapter();
            this.ticketsTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.ticketsTableAdapter();
            this.movie_genresTableAdapter = new WindowsFormsApp2.cinemaDataSetTableAdapters.movie_genresTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie_countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie_genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.билетыToolStripMenuItem1,
            this.фильмыToolStripMenuItem,
            this.сеансыToolStripMenuItem1,
            this.сформироватьОтчетОПроданныхБилетахToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1246, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.фильмToolStripMenuItem,
            this.страныToolStripMenuItem,
            this.жанрыToolStripMenuItem,
            this.сеансыToolStripMenuItem,
            this.билетыToolStripMenuItem,
            this.брониToolStripMenuItem,
            this.местаToolStripMenuItem,
            this.ролиToolStripMenuItem,
            this.фильмЖанрыToolStripMenuItem,
            this.фильмСтраныToolStripMenuItem});
            this.таблицыToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // фильмToolStripMenuItem
            // 
            this.фильмToolStripMenuItem.Name = "фильмToolStripMenuItem";
            this.фильмToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.фильмToolStripMenuItem.Text = "Фильмы";
            this.фильмToolStripMenuItem.Click += new System.EventHandler(this.фильмToolStripMenuItem_Click);
            // 
            // страныToolStripMenuItem
            // 
            this.страныToolStripMenuItem.Name = "страныToolStripMenuItem";
            this.страныToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.страныToolStripMenuItem.Text = "Страны";
            this.страныToolStripMenuItem.Click += new System.EventHandler(this.страныToolStripMenuItem_Click);
            // 
            // жанрыToolStripMenuItem
            // 
            this.жанрыToolStripMenuItem.Name = "жанрыToolStripMenuItem";
            this.жанрыToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.жанрыToolStripMenuItem.Text = "Жанры";
            this.жанрыToolStripMenuItem.Click += new System.EventHandler(this.жанрыToolStripMenuItem_Click);
            // 
            // сеансыToolStripMenuItem
            // 
            this.сеансыToolStripMenuItem.Name = "сеансыToolStripMenuItem";
            this.сеансыToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.сеансыToolStripMenuItem.Text = "Сеансы";
            this.сеансыToolStripMenuItem.Click += new System.EventHandler(this.сеансыToolStripMenuItem_Click);
            // 
            // билетыToolStripMenuItem
            // 
            this.билетыToolStripMenuItem.Name = "билетыToolStripMenuItem";
            this.билетыToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.билетыToolStripMenuItem.Text = "Билеты";
            this.билетыToolStripMenuItem.Click += new System.EventHandler(this.билетыToolStripMenuItem_Click);
            // 
            // брониToolStripMenuItem
            // 
            this.брониToolStripMenuItem.Name = "брониToolStripMenuItem";
            this.брониToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.брониToolStripMenuItem.Text = "Брони";
            this.брониToolStripMenuItem.Click += new System.EventHandler(this.брониToolStripMenuItem_Click);
            // 
            // местаToolStripMenuItem
            // 
            this.местаToolStripMenuItem.Name = "местаToolStripMenuItem";
            this.местаToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.местаToolStripMenuItem.Text = "Места";
            this.местаToolStripMenuItem.Click += new System.EventHandler(this.местаToolStripMenuItem_Click);
            // 
            // ролиToolStripMenuItem
            // 
            this.ролиToolStripMenuItem.Name = "ролиToolStripMenuItem";
            this.ролиToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.ролиToolStripMenuItem.Text = "Роли";
            this.ролиToolStripMenuItem.Click += new System.EventHandler(this.ролиToolStripMenuItem_Click);
            // 
            // фильмЖанрыToolStripMenuItem
            // 
            this.фильмЖанрыToolStripMenuItem.Name = "фильмЖанрыToolStripMenuItem";
            this.фильмЖанрыToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.фильмЖанрыToolStripMenuItem.Text = "Фильм_Жанры";
            this.фильмЖанрыToolStripMenuItem.Click += new System.EventHandler(this.фильмЖанрыToolStripMenuItem_Click);
            // 
            // фильмСтраныToolStripMenuItem
            // 
            this.фильмСтраныToolStripMenuItem.Name = "фильмСтраныToolStripMenuItem";
            this.фильмСтраныToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.фильмСтраныToolStripMenuItem.Text = "Фильм_Страны";
            this.фильмСтраныToolStripMenuItem.Click += new System.EventHandler(this.фильмСтраныToolStripMenuItem_Click);
            // 
            // билетыToolStripMenuItem1
            // 
            this.билетыToolStripMenuItem1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.билетыToolStripMenuItem1.Name = "билетыToolStripMenuItem1";
            this.билетыToolStripMenuItem1.Size = new System.Drawing.Size(88, 27);
            this.билетыToolStripMenuItem1.Text = "Билеты";
            this.билетыToolStripMenuItem1.Click += new System.EventHandler(this.билетыToolStripMenuItem1_Click);
            // 
            // фильмыToolStripMenuItem
            // 
            this.фильмыToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фильмыToolStripMenuItem.Name = "фильмыToolStripMenuItem";
            this.фильмыToolStripMenuItem.Size = new System.Drawing.Size(94, 27);
            this.фильмыToolStripMenuItem.Text = "Фильмы";
            this.фильмыToolStripMenuItem.Click += new System.EventHandler(this.фильмыToolStripMenuItem_Click);
            // 
            // сеансыToolStripMenuItem1
            // 
            this.сеансыToolStripMenuItem1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сеансыToolStripMenuItem1.Name = "сеансыToolStripMenuItem1";
            this.сеансыToolStripMenuItem1.Size = new System.Drawing.Size(87, 27);
            this.сеансыToolStripMenuItem1.Text = "Сеансы";
            this.сеансыToolStripMenuItem1.Click += new System.EventHandler(this.сеансыToolStripMenuItem1_Click);
            // 
            // сформироватьОтчетОПроданныхБилетахToolStripMenuItem
            // 
            this.сформироватьОтчетОПроданныхБилетахToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.сформироватьОтчетОПроданныхБилетахToolStripMenuItem.Name = "сформироватьОтчетОПроданныхБилетахToolStripMenuItem";
            this.сформироватьОтчетОПроданныхБилетахToolStripMenuItem.Size = new System.Drawing.Size(266, 27);
            this.сформироватьОтчетОПроданныхБилетахToolStripMenuItem.Text = "отчет о проданных билетах";
            this.сформироватьОтчетОПроданныхБилетахToolStripMenuItem.Click += new System.EventHandler(this.сформироватьОтчетОПроданныхБилетахToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(968, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(119)))));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.exit.Location = new System.Drawing.Point(1144, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(82, 32);
            this.exit.TabIndex = 3;
            this.exit.Text = "выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1246, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 35);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1246, 25);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dataGridView1.Size = new System.Drawing.Size(1214, 584);
            this.dataGridView1.TabIndex = 4;
            // 
            // change_tb
            // 
            this.change_tb.Location = new System.Drawing.Point(12, 653);
            this.change_tb.Name = "change_tb";
            this.change_tb.Size = new System.Drawing.Size(104, 36);
            this.change_tb.TabIndex = 7;
            this.change_tb.Text = "Изменить";
            this.change_tb.UseVisualStyleBackColor = true;
            this.change_tb.Visible = false;
            this.change_tb.Click += new System.EventHandler(this.change_tb_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(123, 653);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(112, 36);
            this.add.TabIndex = 8;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Visible = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(241, 653);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(125, 36);
            this.del.TabIndex = 11;
            this.del.Text = "Удалить";
            this.del.UseVisualStyleBackColor = true;
            this.del.Visible = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.main;
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1214, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Bahnschrift Light", 10.75F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(652, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.cinemaDataSet;
            this.bindingSource1.Position = 0;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "bookings";
            this.bookingsBindingSource.DataSource = this.cinemaDataSet;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "countries";
            this.countriesBindingSource.DataSource = this.cinemaDataSet;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "genres";
            this.genresBindingSource.DataSource = this.cinemaDataSet;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "movies";
            this.moviesBindingSource.DataSource = this.cinemaDataSet;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.cinemaDataSet;
            // 
            // moviesViewBindingSource
            // 
            this.moviesViewBindingSource.DataMember = "moviesView";
            this.moviesViewBindingSource.DataSource = this.cinemaDataSet;
            // 
            // seatsBindingSource
            // 
            this.seatsBindingSource.DataMember = "seats";
            this.seatsBindingSource.DataSource = this.cinemaDataSet;
            // 
            // showsBindingSource
            // 
            this.showsBindingSource.DataMember = "shows";
            this.showsBindingSource.DataSource = this.cinemaDataSet;
            // 
            // showsViewBindingSource
            // 
            this.showsViewBindingSource.DataMember = "showsView";
            this.showsViewBindingSource.DataSource = this.cinemaDataSet;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.cinemaDataSet;
            // 
            // movie_countriesBindingSource
            // 
            this.movie_countriesBindingSource.DataSource = this.cinemaDataSet;
            this.movie_countriesBindingSource.Position = 0;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "tickets";
            this.ticketsBindingSource.DataSource = this.cinemaDataSet;
            // 
            // ticketsViewBindingSource
            // 
            this.ticketsViewBindingSource.DataMember = "ticketsView";
            this.ticketsViewBindingSource.DataSource = this.cinemaDataSet;
            // 
            // ticketsViewTableAdapter
            // 
            this.ticketsViewTableAdapter.ClearBeforeFill = true;
            // 
            // movie_genresBindingSource
            // 
            this.movie_genresBindingSource.DataMember = "movie_genres";
            this.movie_genresBindingSource.DataSource = this.cinemaDataSet;
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "cinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // moviesViewTableAdapter
            // 
            this.moviesViewTableAdapter.ClearBeforeFill = true;
            // 
            // seatsTableAdapter
            // 
            this.seatsTableAdapter.ClearBeforeFill = true;
            // 
            // showsTableAdapter
            // 
            this.showsTableAdapter.ClearBeforeFill = true;
            // 
            // showsViewTableAdapter
            // 
            this.showsViewTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // movie_countriesTableAdapter
            // 
            this.movie_countriesTableAdapter.ClearBeforeFill = true;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // movie_genresTableAdapter
            // 
            this.movie_genresTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1246, 749);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.del);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.change_tb);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Административная панель";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie_countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie_genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem страныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жанрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сеансыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem билетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem брониToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem билетыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фильмыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сеансыToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private cinemaDataSet cinemaDataSet;
        //private cinemaDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private cinemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button change_tb;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private cinemaDataSetTableAdapters.bookingsTableAdapter bookingsTableAdapter;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private cinemaDataSetTableAdapters.countriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private cinemaDataSetTableAdapters.genresTableAdapter genresTableAdapter;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private cinemaDataSetTableAdapters.moviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private cinemaDataSetTableAdapters.rolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.BindingSource moviesViewBindingSource;
        private cinemaDataSetTableAdapters.moviesViewTableAdapter moviesViewTableAdapter;
        private System.Windows.Forms.BindingSource seatsBindingSource;
        private cinemaDataSetTableAdapters.seatsTableAdapter seatsTableAdapter;
        private System.Windows.Forms.BindingSource showsBindingSource;
        private cinemaDataSetTableAdapters.showsTableAdapter showsTableAdapter;
        private System.Windows.Forms.BindingSource showsViewBindingSource;
        private cinemaDataSetTableAdapters.showsViewTableAdapter showsViewTableAdapter;
        //private System.Windows.Forms.BindingSource tickets3BindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private cinemaDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem местаToolStripMenuItem;
       // private System.Windows.Forms.BindingSource ticketsView2BindingSource1;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.ToolStripMenuItem ролиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьОтчетОПроданныхБилетахToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem фильмЖанрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильмСтраныToolStripMenuItem;
        private System.Windows.Forms.BindingSource movie_countriesBindingSource;
        private cinemaDataSetTableAdapters.movie_countriesTableAdapter movie_countriesTableAdapter;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private cinemaDataSetTableAdapters.ticketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.BindingSource ticketsViewBindingSource;
        private cinemaDataSetTableAdapters.ticketsViewTableAdapter ticketsViewTableAdapter;
        private System.Windows.Forms.BindingSource movie_genresBindingSource;
        private cinemaDataSetTableAdapters.movie_genresTableAdapter movie_genresTableAdapter;
    }
}