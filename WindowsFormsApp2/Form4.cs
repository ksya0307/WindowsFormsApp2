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
    public partial class Form4 : Form
    {
        bool button;
        int zal;
        int idshow;
        string loginuser;
        string date_choose;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
        SqlCommand cmd;
        public Form4(string login)
        {
            loginuser = login;
            InitializeComponent();
        }

        
        private void Form4_Load(object sender, EventArgs e)
        {
            book.Visible = false;
            buy.Visible = false;

            this.scheduleViewTableAdapter.Fill(this.cinemaDataSet.scheduleView);
            
            con.Open();
            cmd = new SqlCommand("select last_name, name from users where login='" + loginuser + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                dt.Columns.Add(new DataColumn(reader.GetName(i), reader.GetFieldType(i)));
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

                    DataRow r = dt.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        r[i] = reader.GetValue(i);
                    }
                    dt.Rows.Add(r);
                }
            }
            reader.Close();
            cmd.Dispose();

            con.Close();

            //monthCalendar1.MinDate = DateTime.Now;
            //monthCalendar1.MaxDate = DateTime.Now.AddDays(10);

            //con.Open();
            //label1.Text = lastname + ' ' + name;
            //List<DateTime> list = new List<DateTime>();
            //DateTime[] VacationDates = { };
            //SqlDataAdapter da = new SqlDataAdapter("select date from shows where date>=CONVERT(date,GETDATE())", con);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //    {
            //        DateTime date = Convert.ToDateTime(ds.Tables[0].Rows[i][0].ToString());
            //        list.Add(date);
                    
            //    }
            //}
            //monthCalendar1.BoldedDates = list.ToArray();
            //con.Close();

        }
        private void monthCalendar1_DateSelected(object sender, EventArgs e)
        {
            DataSet ds;
            SqlDataAdapter adapter;

            date_choose = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            

            con.Open();
            adapter = new SqlDataAdapter("select * from scheduleView where date=('" + date_choose + "')", con);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoResizeColumns();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            if (dataGridView1.Rows.Count == 0)
            {
                
                book.Enabled = false;
                buy.Enabled = false;
            }
            else
            {
                book.Visible = true;
                buy.Visible = true;
                book.Enabled = true;
                buy.Enabled = true;
            }
            con.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {      
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                string value = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                idshow = Convert.ToInt32(value);
            } 
        }
        private void buy_Click_1(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand sql = new SqlCommand("select zal from shows where id='" + idshow + "'",con);

            SqlDataReader rdr = sql.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    zal = rdr.GetInt32(0);
                }
            }
            rdr.Close();
            con.Close();
            switch (zal)
            {
                case 1:
                    button = false;
                    zal1 zal1 = new zal1(idshow, loginuser, button);
                    zal1.ShowDialog();
                    break;
                case 2:
                    button = false;
                    zal2 zal2 = new zal2(idshow, loginuser, button);
                    zal2.ShowDialog();
                    break;
                case 3:
                    button = false;
                    zal3 zal3 = new zal3(idshow, loginuser, button);
                    zal3.ShowDialog();
                    break;
                case 4:
                    button = false;
                    zal4 zal4 = new zal4(idshow, loginuser, button);
                    zal4.ShowDialog();
                    break;
                case 5:
                    button = false;
                    zal5 zal5 = new zal5(idshow, loginuser, button);
                    zal5.ShowDialog();
                    break;
                case 6:
                    button = false;
                    zal6 zal6 = new zal6(idshow, loginuser, button);
                    zal6.ShowDialog();
                    break;
            }
        }
        private void book_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select zal from shows where id='" + idshow + "'",con);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    zal = rdr.GetInt32(0);
                }
            }
            rdr.Close();
            con.Close();

            switch (zal)
            {
                case 1:
                    button = true;
                    zal1 zal1 = new zal1(idshow, loginuser, button);
                    zal1.Show();
                    break;
                case 2:
                    button = true;
                    zal2 zal2 = new zal2(idshow, loginuser, button);
                    zal2.Show();
                    break;
                case 3:
                    button = true;
                    zal3 zal3 = new zal3(idshow, loginuser, button);
                    zal3.Show();
                    break;
                case 4:
                    button = true;
                    zal4 zal4 = new zal4(idshow, loginuser, button);
                    zal4.Show();
                    break;
                case 5:
                    button = true;
                    zal5 zal5 = new zal5(idshow, loginuser, button);
                    zal5.Show();
                    break;
                case 6:
                    button = true;
                    zal6 zal6 = new zal6(idshow, loginuser, button);
                    zal6.Show();
                    break;
            }
        }
        private void schedule_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            monthCalendar1.Visible = true;
            dataGridView1.Visible = true;

            DataSet ds;
            SqlDataAdapter adapter;

            date_choose = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");

            con.Open();
            adapter = new SqlDataAdapter("select * from scheduleView where date=('" + date_choose + "')", con);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns["date"].Visible = false;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.AutoResizeColumns();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            con.Close();
        }
        private void opentickets_Click(object sender, EventArgs e)
        {
            string iduser = "";

            con.Open();
            cmd = new SqlCommand("select id from users where login='" + loginuser + "'", con);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    iduser = Convert.ToString(rdr.GetInt32(0));
                }
            }
            rdr.Close();
            con.Close();
            ticketsguest ticketsguest = new ticketsguest(iduser);
            ticketsguest.ShowDialog();
        }
        private void openbookings_Click(object sender, EventArgs e)
        {
            string iduser = "";
            con.Open();
            cmd = new SqlCommand("select id from users where login='" + loginuser + "'", con);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    iduser = Convert.ToString(rdr.GetInt32(0));
                }
            }
            rdr.Close();
            con.Close();
            bookings bookings = new bookings(iduser);
            bookings.ShowDialog();
        }
        private void opensales_Click(object sender, EventArgs e)
        {
            sales sales = new sales();
            sales.Show();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
