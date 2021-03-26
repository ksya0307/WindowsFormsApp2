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
        public buybook(int iduser)
        {
            id_user = iduser;
            InitializeComponent();
        }
        private void buybook_Load(object sender, EventArgs e)
        {
            this.cinemaDataSet.EnforceConstraints = false;
            this.customers_bookTableAdapter.Fill(this.cinemaDataSet.customers_book, id_user);
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
            if (customers_bookDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                customers_bookDataGridView.CurrentRow.Selected = true;
                string show = customers_bookDataGridView.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].FormattedValue.ToString();
                idshow = Convert.ToInt32(show);
                string booking = customers_bookDataGridView.Rows[e.RowIndex].Cells["bookingIDDataGridViewTextBoxColumn"].FormattedValue.ToString();
                idbooking = Convert.ToInt32(booking);
            }
        }

        private void buybooking_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            con.Open();
            SqlCommand cmd = new SqlCommand("select customer, seat,show from bookings where bookingID=" + idbooking, con);
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
            cmd = new SqlCommand("INSERT INTO TICKETS(show,seat,guest) values(" + idshow + "," + seat + "," + cust + ")",con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            con.Open();
            cmd = new SqlCommand("delete from bookings where bookingID=" + idbooking,con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            customersbookBindingSource.RemoveCurrent();
            customers_bookDataGridView.DataSource = customersbookBindingSource;
            MessageBox.Show("ВЫ ПРИОБРЕЛИ БИЛЕТ!\n\nСпасибо, что выбрали нас!\nПриятного просмотра! ", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
