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
    public partial class zal4 : Form
    {
        bool btn;
        string user;
        string userLog;
        int idshowget;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
        SqlCommand cmd;
        SqlDataReader rdr;
        private System.Drawing.Bitmap chair = new System.Drawing.Bitmap(Properties.Resources.chair);
        private System.Drawing.Bitmap greenChair = new System.Drawing.Bitmap(Properties.Resources.chairGREEN_02);
        private System.Drawing.Bitmap redChair = new System.Drawing.Bitmap(Properties.Resources.chairRED_01);
        private System.Drawing.Bitmap yelChair = new System.Drawing.Bitmap(Properties.Resources.chairYELLOW_03);
        public zal4(int idshow, string loginuser, bool button)
        {
            btn = button;
            userLog = loginuser;
            idshowget = idshow;
            InitializeComponent();
        }
        private void zal4_Load(object sender, EventArgs e)
        {
            

            if (btn)
            {
                button2.Visible = false;
                button3.Visible = true;
            }
            if (!btn)
            {
                button2.Visible = true;
                button3.Visible = false;
            }
            con.Open();
            cmd = new SqlCommand("select id from users where login='" + userLog + "'", con);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    user = Convert.ToString(rdr.GetInt32(0));
                }
            }
            rdr.Close();
            cmd.Dispose();
            con.Close();

            con.Open();
            cmd = new SqlCommand("SELECT dbo.shows.start_time, dbo.shows.end_film, RTRIM(dbo.movies.movie), dbo.movies.age, dbo.shows.zal, dbo.shows.cost, dbo.shows.date, dbo.shows.format FROM dbo.movies INNER JOIN dbo.shows ON dbo.movies.id = dbo.shows.movie where shows.id=" + idshowget + ";", con);
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            for (int i = 0; i < rdr.FieldCount; i++)
            {
                dt.Columns.Add(new DataColumn(rdr.GetName(i), rdr.GetFieldType(i)));
            }

            string start = "", end = "", film = "", age = "", zal = "", cost = "", date = "", format = "";
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    start = Convert.ToString(rdr.GetTimeSpan(0));
                    end = Convert.ToString(rdr.GetTimeSpan(1));
                    film = rdr.GetString(2);
                    age = Convert.ToString(rdr.GetInt32(3));
                    zal = Convert.ToString(rdr.GetInt32(4));
                    cost = Convert.ToString(rdr.GetInt32(5));
                    date = rdr.GetDateTime(6).ToString("dd-MM-yyyy");
                    format = rdr.GetString(7);
                    DataRow r = dt.NewRow();
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        r[i] = rdr.GetValue(i);
                    }
                    dt.Rows.Add(r);
                }
                rdr.Close();
                cmd.Dispose();
                con.Close();

                movie.Text = film;
                start_film.Text = start;
                end_film.Text = end;
                age_f.Text = age + '+';
                cost_f.Text = cost;
                date_f.Text = date;
                format_f.Text = format;
                zal_f.Text = zal;
            }

            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    ((PictureBox)c).Image = greenChair;
                    c.Click += pictureBox14_Click;
                }
            }

            UpdateBookings();
            UpdateTickets();
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool bSelected = false;
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    if (object.ReferenceEquals(((PictureBox)c).Image, redChair))
                    {
                        bSelected = true;
                        break;
                    }
                    c.Click += pictureBox14_Click;
                }
            }
            if (!bSelected)
            {
                MessageBox.Show("Выберите как минимум одно место", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            con.Open();
            int iSeatNum = 0;
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    if (object.ReferenceEquals(((PictureBox)c).Image, redChair))
                    {
                        iSeatNum = Convert.ToInt32(((PictureBox)c).Name.Remove(0, 10));
                        cmd = new SqlCommand("INSERT INTO tickets (show,seat,customer) values(" + idshowget + "," + iSeatNum + "," + user + ");", con);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            MessageBox.Show("ВЫ ПРИОБРЕЛИ БИЛЕТ(-ы)!\n\nСпасибо, что выбрали нас!\nПриятного просмотра! ", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.Dispose();
            con.Close();
            UpdateTickets();

            con.Open();
            cmd = new SqlCommand("select top 1 tickets.id from tickets inner join seats on seats.seatID=tickets.seat where seats.seatID=" + iSeatNum + "AND tickets.show=" + idshowget, con);
            int id_ticket = 0;
            id_ticket = (Int32)cmd.ExecuteScalar();
            ticket_receit ticket_Receit;
            ticket_Receit = new ticket_receit(id_ticket);
            ticket_Receit.Show();
            cmd.Dispose();
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            bool bSelected = false;
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    if (object.ReferenceEquals(((PictureBox)c).Image, redChair))
                    {
                        bSelected = true;
                        break;
                    }
                    c.Click += pictureBox14_Click;
                }
            }
            if (!bSelected)
            {
                MessageBox.Show("Выберите как минимум одно место", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            con.Open();
            int iSeatNum;
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    if (object.ReferenceEquals(((PictureBox)c).Image, redChair))
                    {
                        iSeatNum = Convert.ToInt32(((PictureBox)c).Name.Remove(0, 10));
                        cmd = new SqlCommand("INSERT INTO bookings (customer,seat,show) values('" + user + "'," + iSeatNum + "," + idshowget + ");", con);
                        cmd.ExecuteNonQuery();

                    }
                }

            }
            cmd.Dispose();
            con.Close();
            UpdateBookings();
            MessageBox.Show("Вы забронировали билет(-ы),\nВаши брони можно посмотреть,\nа также выкупить в ЛИЧНОМ КАБИНЕТЕ!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void UpdateBookings()
        {
            con.Open();
            cmd = new SqlCommand("select bookingID, customer,seat,show from bookings where show=" + idshowget, con);
            DataSet dsbooking = new DataSet();
            SqlDataAdapter dabooking = new SqlDataAdapter(cmd);
            dabooking.Fill(dsbooking, "Bookings");
            cmd.Dispose();
            con.Close();
            DataTable t1 = dsbooking.Tables["Bookings"];
            foreach (DataRow row in t1.Rows)
            {
                ((PictureBox)this.Controls["Picturebox" + row[2].ToString()]).Image = yelChair;
            }
        }
        private void UpdateTickets()
        {
            con.Open();
            cmd = new SqlCommand("select id,show,seat,customer from tickets where show=" + idshowget, con);

            DataSet dstickets = new DataSet();
            SqlDataAdapter datickets = new SqlDataAdapter(cmd);
            datickets.Fill(dstickets, "Tickets");
            cmd.Dispose();
            con.Close();
            DataTable t1 = dstickets.Tables["Tickets"];
            foreach (DataRow row in t1.Rows)
            {
                ((PictureBox)this.Controls["Picturebox" + row[2].ToString()]).Image = chair;
            }
        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox86_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox85_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox80_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox82_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox83_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox84_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox204_Click(object sender, EventArgs e)
        {

        }
    }
}
