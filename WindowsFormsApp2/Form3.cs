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
    public partial class Form3 : Form
    {
        string loginuser;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
        SqlCommand cmd;
        public Form3(string login)
        {
            loginuser = login;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.cinemaDataSet.EnforceConstraints = false;
            this.ticketsTableAdapter.Fill(this.cinemaDataSet.tickets);    
            this.showsViewTableAdapter.Fill(this.cinemaDataSet.showsView);
            this.moviesViewTableAdapter.Fill(this.cinemaDataSet.moviesView);

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
                reader.Close();
                cmd.Dispose();
                con.Close();
                label1.Text = lastname + ' ' + name;
            }
        }

        private void фильмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            dataGridView1.DataSource = moviesViewBindingSource;
            bindingNavigator1.BindingSource = moviesViewBindingSource;

            bindingNavigatorAddNewItem.Visible = false;
            bindingNavigatorDeleteItem.Visible = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            
            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count);
            dataGridView1.Columns["Длительность"].DefaultCellStyle.Format = "0 мин";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoResizeColumns();
        }

        private void сеансыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            bindingNavigatorAddNewItem.Visible = false;
            bindingNavigatorDeleteItem.Visible = false;

            dataGridView1.DataSource = showsViewBindingSource;
            
            bindingNavigator1.BindingSource = showsViewBindingSource;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            toolStripStatusLabel1.Text = Convert.ToString(dataGridView1.Rows.Count);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoResizeColumns();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void оформитьБилетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 form4 = new Form4(loginuser);
            form4.Show();
        }
    }
}
