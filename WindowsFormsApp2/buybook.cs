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
    public partial class buybook : Form
    {
        int id_user;
        int idshow;
        int idbooking;

        SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
        SqlCommand cmd;
        public buybook(int iduser)
        {
            id_user = iduser;
            InitializeComponent();
        }
        private void buybook_Load(object sender, EventArgs e)
        {
            this.cinemaDataSet.EnforceConstraints = false;
            this.get_bookingTableAdapter.Fill(this.cinemaDataSet.get_booking, id_user);
            customers_bookDataGridView.Columns["datagridviewtextboxcolumn9"].Visible = false;
            customers_bookDataGridView.Columns["idBook"].Visible = false;
            customers_bookDataGridView.AutoResizeColumns();
            for (int i = 0; i < customers_bookDataGridView.Rows.Count; i++)
            {
                customers_bookDataGridView.Rows[i].Height = 30;
            }
            if(customers_bookDataGridView.Rows.Count ==0) buybooking.Enabled = false;
        }

        private void customers_bookDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buybooking.Enabled = true;
            canselbooking.Enabled = true;
            if (customers_bookDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                customers_bookDataGridView.CurrentRow.Selected = true;
                string show = customers_bookDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn9"].FormattedValue.ToString();
                idshow = Convert.ToInt32(show);
                string booking = customers_bookDataGridView.Rows[e.RowIndex].Cells["idBook"].FormattedValue.ToString();
                idbooking = Convert.ToInt32(booking);
            }
        }

        private void buybooking_Click(object sender, EventArgs e)
        {
            
            con.Open();
            cmd = new SqlCommand("select customer, seat,show from bookings where bookingID=" + idbooking, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            int cust = 0, seat = 0, show = 0;
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    cust = rdr.GetInt32(0);
                    seat = rdr.GetInt32(1);
                    show = rdr.GetInt32(2);
                }
            }
            rdr.Close();
            cmd.Dispose();
            con.Close();

            con.Open();
            cmd = new SqlCommand("INSERT INTO TICKETS(show,seat,customer) values(" + idshow + "," + seat + "," + cust + ")",con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            con.Open();
            cmd = new SqlCommand("delete from bookings where bookingID=" + idbooking,con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            get_bookingBindingSource.RemoveCurrent();
            customers_bookDataGridView.DataSource = get_bookingBindingSource;
            MessageBox.Show("ВЫ ПРИОБРЕЛИ БИЛЕТ!\n\nСпасибо, что выбрали нас!\nПриятного просмотра! ", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void canselbooking_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from bookings where bookingID=" + idbooking, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            get_bookingBindingSource.RemoveCurrent();
            customers_bookDataGridView.DataSource = get_bookingBindingSource;
            MessageBox.Show("Вы отменили бронь ", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
