using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        string loginuser;
        string tableName;
        string getdate;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
        SqlCommand cmd;
        public Form2(string login)
        {
            loginuser = login;
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.cinemaDataSet.EnforceConstraints = false;
   
            this.showsViewTableAdapter.Fill(this.cinemaDataSet.showsView);
            this.moviesViewTableAdapter.Fill(this.cinemaDataSet.moviesView);
            this.ticketsViewTableAdapter.Fill(this.cinemaDataSet.ticketsView);

            this.ticketsTableAdapter.Fill(this.cinemaDataSet.tickets);
            this.movie_genresTableAdapter.Fill(this.cinemaDataSet.movie_genres);
            this.movie_countriesTableAdapter.Fill(this.cinemaDataSet.movie_countries);
            this.usersTableAdapter.Fill(this.cinemaDataSet.users);
            this.showsTableAdapter.Fill(this.cinemaDataSet.shows);
            this.seatsTableAdapter.Fill(this.cinemaDataSet.seats);
            this.rolesTableAdapter.Fill(this.cinemaDataSet.roles);
            this.moviesTableAdapter.Fill(this.cinemaDataSet.movies);
            this.genresTableAdapter.Fill(this.cinemaDataSet.genres);
            this.countriesTableAdapter.Fill(this.cinemaDataSet.countries);
            this.bookingsTableAdapter.Fill(this.cinemaDataSet.bookings);

            con.Open();//открытие подключения
            //sql выражение которое будет выполняться
            cmd = new SqlCommand("select last_name, name from users where login='" + loginuser + "'",con);
            //выполняет sql-выражение и возвращает строки из таблицы
            SqlDataReader reader = cmd.ExecuteReader();
            
            DataTable dt = new DataTable();//Представляет одну таблицу

            for (int i = 0; i < reader.FieldCount; i++)
            {
                dt.Columns.Add(new DataColumn(reader.GetName(i), reader.GetFieldType(i)));//таблица с колонками last name & name
            }
            string lastname = "", name = "";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lastname = reader.GetString(0);
                    name = reader.GetString(1);
                    lastname = lastname.Trim(' ');
                    name = name.Trim(' ');
                    DataRow r = dt.NewRow();//создание строчки
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        r[i] = reader.GetValue(i);
                    }
                    dt.Rows.Add(r);//таблица с одной строчкой
                }
                reader.Close();
                cmd.Dispose();
                con.Close();
                label1.Text = lastname + ' ' + name;
            }
            
        }
        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.cinemaDataSet.users);
            pictureBox1.Visible = false;
            bindingNavigatorAddNewItem.Visible = true;
            tableName = "users";
            change_tb.Visible = true;
            add.Visible = true;
            del.Visible = true;
            dataGridView1.DataSource = usersBindingSource;
            //
            bindingNavigator1.BindingSource = usersBindingSource;

            this.Text = "Пользователи";

            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["last_name"].HeaderText = "Фамилия";
            dataGridView1.Columns["name"].HeaderText = "Имя";
            dataGridView1.Columns["dad_name"].HeaderText = "Отчество";
            dataGridView1.Columns["login"].HeaderText = "Логин";
            dataGridView1.Columns["password"].HeaderText = "Пароль";
            dataGridView1.Columns["email"].HeaderText = "E-mail";
            dataGridView1.Columns["phone"].HeaderText = "Телефон";
            dataGridView1.Columns["birthday"].HeaderText = "Дата рождения";
            dataGridView1.Columns["role"].HeaderText = "Роль";

            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count-1);
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            dataGridView1.AutoResizeColumns();

        }
        private void фильмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.moviesTableAdapter.Fill(this.cinemaDataSet.movies);
            pictureBox1.Visible = false;
            this.Text = "Фильмы";
            bindingNavigatorAddNewItem.Visible = true;
            change_tb.Visible = true;
            add.Visible = true;
            del.Visible = true;
            tableName = "movies";
            dataGridView1.DataSource = moviesBindingSource;
            
            bindingNavigator1.BindingSource = moviesBindingSource;

            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["movie"].HeaderText = "Фильм";
            dataGridView1.Columns["running_time"].HeaderText = "Длительность";
            dataGridView1.Columns["age"].HeaderText = "Возрастное ограничение";
            dataGridView1.Columns["year"].HeaderText = "Год";
            dataGridView1.Columns["description"].HeaderText = "Описание";
          

            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count-1);
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            dataGridView1.AutoResizeColumns();
        }
        private void страныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.countriesTableAdapter.Fill(this.cinemaDataSet.countries);
            pictureBox1.Visible = false;
            this.Text = "Страны";
            bindingNavigatorAddNewItem.Visible = true;
            change_tb.Visible = true;
            add.Visible = true;
            del.Visible = true;
            tableName = "countries";
            dataGridView1.DataSource = countriesBindingSource;
            ;
            bindingNavigator1.BindingSource = countriesBindingSource;
            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["country"].HeaderText = "Страна";
            dataGridView1.AutoResizeColumns();
            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count-1);
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
        }
        private void жанрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.genresTableAdapter.Fill(this.cinemaDataSet.genres);
            pictureBox1.Visible = false;
            this.Text = "Жанры";
            bindingNavigatorAddNewItem.Visible = true;
            change_tb.Visible = true;
            add.Visible = true;
            del.Visible = true;
            tableName = "genres";
            dataGridView1.DataSource = genresBindingSource;
            
            bindingNavigator1.BindingSource = genresBindingSource;
            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["genre"].HeaderText = "Жанр";
            dataGridView1.AutoResizeColumns();
            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count-1);
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
        }
        private void сеансыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showsTableAdapter.Fill(this.cinemaDataSet.shows);
            pictureBox1.Visible = false;
            this.Text = "Сеансы";
            bindingNavigatorAddNewItem.Visible = true;
            change_tb.Visible = true;
            add.Visible = true;
            del.Visible = true;
            tableName = "shows";
            dataGridView1.DataSource = showsBindingSource;
            
            bindingNavigator1.BindingSource = showsBindingSource;
            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["movie"].HeaderText = "Фильм";
            dataGridView1.Columns["free_places"].HeaderText = "Свободные места";
            dataGridView1.Columns["used_places"].HeaderText = "Занятые места";
            dataGridView1.Columns["cost"].HeaderText = "Стоимость";
            dataGridView1.Columns["start_time"].HeaderText = "Начало фильма";
            dataGridView1.Columns["end_film"].HeaderText = "Конец фильма";
            dataGridView1.Columns["zal"].HeaderText = "Зал";
            dataGridView1.Columns["date"].HeaderText = "Дата";
            dataGridView1.Columns["format"].HeaderText = "Формат";
            dataGridView1.AutoResizeColumns();
            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count-1);
             
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
        }
        private void билетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ticketsTableAdapter.Fill(this.cinemaDataSet.tickets);
            pictureBox1.Visible = false;
            this.Text = "Билеты";
            bindingNavigatorAddNewItem.Visible = true;
            change_tb.Visible = true;
            add.Visible = true;
            del.Visible = true;
            tableName = "tickets";
            dataGridView1.DataSource = ticketsBindingSource;
            
            bindingNavigator1.BindingSource = ticketsBindingSource;
            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["show"].HeaderText = "Сеанс";
            dataGridView1.Columns["seat"].HeaderText = "Место";
            dataGridView1.Columns["customer"].HeaderText = "Пользователь";
            dataGridView1.AutoResizeColumns();
            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count-1);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
        }
        private void билетыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            change_tb.Visible = false;
            add.Visible = false;
            del.Visible = false;
            this.Text = "Билеты";
            bindingNavigatorAddNewItem.Visible = true;
            bindingNavigatorAddNewItem.Visible = false;
            bindingNavigatorDeleteItem.Visible = false;
            dataGridView1.DataSource = ticketsViewBindingSource;
            bindingNavigator1.BindingSource = ticketsViewBindingSource;
            for (int i=0;i<dataGridView1.Rows.Count;i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count-1);
            dataGridView1.AutoResizeColumns();
        }
        private void фильмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            change_tb.Visible = false;
            del.Visible = false;
            add.Visible = false;
            this.Text = "Фильмы";
            dataGridView1.DataSource = moviesViewBindingSource;        
            bindingNavigator1.BindingSource = moviesViewBindingSource;
            bindingNavigatorAddNewItem.Visible = false;
            bindingNavigatorDeleteItem.Visible = false;           
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count-1);
            dataGridView1.Columns["Длительность"].DefaultCellStyle.Format = "0 мин";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoResizeColumns();
        }
        private void сеансыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            bindingNavigatorAddNewItem.Visible = false;
            bindingNavigatorDeleteItem.Visible = false;
            del.Visible = false;
            add.Visible = false;
            change_tb.Visible = false;
            this.Text = "Сеансы";
            dataGridView1.DataSource = showsViewBindingSource;
            
            bindingNavigator1.BindingSource = showsViewBindingSource;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count-1);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoResizeColumns();
        }
        private void брониToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bookingsTableAdapter.Fill(this.cinemaDataSet.bookings);
            pictureBox1.Visible = false;
            bindingNavigatorAddNewItem.Visible = true;
            tableName = "bookings";
            change_tb.Visible = true;
            add.Visible = true;
            del.Visible = true;
            dataGridView1.DataSource = bookingsBindingSource;

            bindingNavigator1.BindingSource = bookingsBindingSource;

            this.Text = "Брони";

            dataGridView1.Columns["bookingID"].HeaderText = "ID";
            dataGridView1.Columns["customer"].HeaderText = "Пользователь";
            dataGridView1.Columns["seat"].HeaderText = "Место";
            dataGridView1.Columns["show"].HeaderText = "Сеанс";
            dataGridView1.AutoResizeColumns();
            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count-1);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
        }
        private void местаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.seatsTableAdapter.Fill(this.cinemaDataSet.seats);
            pictureBox1.Visible = false;
            this.Text = "Места";
            bindingNavigatorAddNewItem.Visible = true;
            change_tb.Visible = true;
            add.Visible = true;
            del.Visible = true;
            tableName = "seats";
            dataGridView1.DataSource = seatsBindingSource;
            
            bindingNavigator1.BindingSource = seatsBindingSource;
            dataGridView1.Columns["seatID"].HeaderText = "ID";
            dataGridView1.Columns["row"].HeaderText = "Ряд";
            dataGridView1.Columns["number"].HeaderText = "Место";

            dataGridView1.AutoResizeColumns();
            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count-1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void change_tb_Click(object sender, EventArgs e)
        {
            switch (tableName)
            {
                case "users":
                    try
                    {
                        usersBindingSource.EndEdit();
                        usersTableAdapter.Update(this.cinemaDataSet.users);
                        MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "countries":
                    try
                    {
                        countriesBindingSource.EndEdit();
                        countriesTableAdapter.Update(this.cinemaDataSet.countries);
                        MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "genres":
                    try
                    {
                        genresBindingSource.EndEdit();
                        genresTableAdapter.Update(this.cinemaDataSet.genres);
                        MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "movies":
                    try
                    {
                        moviesBindingSource.EndEdit();
                        moviesTableAdapter.Update(this.cinemaDataSet.movies);
                        MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "shows":
                    try
                    {
                        showsBindingSource.EndEdit();
                        showsTableAdapter.Update(this.cinemaDataSet.shows);
                        MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "tickets":
                    try
                    {
                        ticketsBindingSource.EndEdit();
                        ticketsTableAdapter.Update(this.cinemaDataSet.tickets);
                        MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "roles":
                    try
                    {
                        rolesBindingSource.EndEdit();
                        rolesTableAdapter.Update(this.cinemaDataSet.roles);
                        MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

            }


        }
        private void add_Click(object sender, EventArgs e)
        {
            switch (tableName)
            {
                case "users":
                    usersTableAdapter.Update(cinemaDataSet);
                    dataGridView1.DataSource = usersBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "countries":
                    countriesTableAdapter.Update(cinemaDataSet);
                    dataGridView1.DataSource = countriesBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "genres":
                    genresTableAdapter.Update(cinemaDataSet);
                    dataGridView1.DataSource = genresBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "movies":
                    moviesTableAdapter.Update(cinemaDataSet);
                    dataGridView1.DataSource = moviesBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "shows":
                    showsTableAdapter.Update(cinemaDataSet);
                    dataGridView1.DataSource = showsBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "tickets":
                    ticketsTableAdapter.Update(cinemaDataSet);
                    dataGridView1.DataSource = ticketsBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "roles":
                    rolesTableAdapter.Update(cinemaDataSet);
                    dataGridView1.DataSource = rolesBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        private void deletedate(string table_name)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Convert.ToInt32(id);
            con.Open();
            cmd = new SqlCommand($"delete from {table_name} where id={id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void ролиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rolesTableAdapter.Fill(this.cinemaDataSet.roles);
            pictureBox1.Visible = false;
            this.Text = "Роли";
            bindingNavigatorAddNewItem.Visible = true;
            change_tb.Visible = true;
            add.Visible = true;
            del.Visible = true;
            tableName = "roles";
            dataGridView1.DataSource = rolesBindingSource;

            bindingNavigator1.BindingSource = rolesBindingSource;
            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["role"].HeaderText = "Роль";
            dataGridView1.Columns["access_level"].HeaderText = "Уровень доступа";
            
            dataGridView1.AutoResizeColumns();
            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
        }
        private void del_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                switch (tableName)
                {
                    case "users":
                        deletedate("users");
                        пользователиToolStripMenuItem_Click(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!","Сообщение",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        break;
                    case "countries":
                        deletedate("countries");
                        страныToolStripMenuItem_Click(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "genres":
                        deletedate("genres");
                        жанрыToolStripMenuItem_Click(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "movies":
                        deletedate("movies");
                        фильмToolStripMenuItem_Click(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "shows":
                        deletedate("shows");
                        сеансыToolStripMenuItem_Click(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "tickets":
                        deletedate("tickets");
                        билетыToolStripMenuItem_Click(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "roles":
                        deletedate("roles");
                        ролиToolStripMenuItem_Click(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "seats":
                        deletedate("seats");
                        местаToolStripMenuItem_Click(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "bookings":
                        deletedate("bookings");
                        брониToolStripMenuItem_Click(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                }
            }
        }

        private void сформироватьОтчетОПроданныхБилетахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportbuytick reportbuytick = new reportbuytick(getdate);
            reportbuytick.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           getdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void фильмЖанрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.movie_genresTableAdapter.Fill(this.cinemaDataSet.movie_genres);
            pictureBox1.Visible = false;
            this.Text = "Фильм_Жанры";
            bindingNavigatorAddNewItem.Visible = true;
            change_tb.Visible = true;
            add.Visible = true;
            del.Visible = true;
            tableName = "movie_genres";
            dataGridView1.DataSource = movie_genresBindingSource;

            bindingNavigator1.BindingSource = movie_genresBindingSource;
            dataGridView1.Columns["movie"].HeaderText = "Фильм";
            dataGridView1.Columns["genre"].HeaderText = "Жанр";

            dataGridView1.AutoResizeColumns();
            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
        }

        private void фильмСтраныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.movie_countriesTableAdapter.Fill(this.cinemaDataSet.movie_countries);
            pictureBox1.Visible = false;
            this.Text = "Фильм_Страны";
            bindingNavigatorAddNewItem.Visible = true;
            change_tb.Visible = true;
            add.Visible = true;
            del.Visible = true;
            tableName = "movie_countries";
            dataGridView1.DataSource = movie_countriesBindingSource;

            bindingNavigator1.BindingSource = movie_countriesBindingSource;
            dataGridView1.Columns["movie"].HeaderText = "Фильм";
            dataGridView1.Columns["country"].HeaderText = "Страна";

            dataGridView1.AutoResizeColumns();
            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }

        }
    }
}
