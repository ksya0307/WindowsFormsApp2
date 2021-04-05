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
using System.Text.RegularExpressions;
using System.Data.SqlTypes;

namespace WindowsFormsApp2
{
    public partial class registr : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
        SqlCommand command;
        public registr()
        {
            InitializeComponent();      
        }
        private void last_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!((l >= 'А' && l <= 'я') || l == 'ё' || l == 'Ё' || l == 8))
            { 
                e.Handled = true; 
            } 
        }
        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!((l >= 'А' && l <= 'я') || l == 'ё' || l == 'Ё' || l == 8))
            {
                e.Handled = true;
            }
        }
        private void dad_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!((l >= 'А' && l <= 'я') || l == 'ё' || l == 'Ё' || l == 8))
            {
                e.Handled = true;
            }
        }
        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!((l >= '0' && l <='9') || l == 8))
            {
                e.Handled = true;
            }
        }
        private void registracia_Click(object sender, EventArgs e)
        {
            if (last_name.Text == "" || name.Text == "" || dad_name.Text == "" || login.Text == "" || pass.Text == "" || email.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Вы заполнили не все поля, нажмите ОК, чтобы продолжить", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                DataTable tb = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter();
                command = new SqlCommand("select id from users where login='"+login.Text+"'",con);
                ad.SelectCommand = command;
                ad.Fill(tb);
                if (tb.Rows.Count>0)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует,\nпожалуйста,придумайте другой логин","Уведомление", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    login.Clear();
                    con.Close();
                }
                else
                {
                    ToAes256 toAes = new ToAes256();
                    toAes.enc();
                   
                    command.Dispose();
                    command = new SqlCommand("users_insert", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@last_name", SqlDbType.NChar));
                    command.Parameters["@last_name"].Value = last_name.Text;
                    command.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
                    command.Parameters["@name"].Value = name.Text;
                    command.Parameters.Add(new SqlParameter("@dad_name", SqlDbType.NChar));
                    command.Parameters["@dad_name"].Value = dad_name.Text;
                    command.Parameters.Add(new SqlParameter("@login", SqlDbType.NChar));
                    command.Parameters["@login"].Value = login.Text;
                    command.Parameters.Add(new SqlParameter("@pass", SqlDbType.NChar));
                    command.Parameters["@pass"].Value = pass.Text;
                    command.Parameters.Add(new SqlParameter("@email", SqlDbType.NChar));
                    command.Parameters["@email"].Value = email.Text;
                    command.Parameters.Add(new SqlParameter("@phone", SqlDbType.NChar));
                    command.Parameters["@phone"].Value = phone.Text;
                    command.Parameters.Add(new SqlParameter("@birth", SqlDbType.Date));
                    command.Parameters["@birth"].Value = birth.Text;

                    if (command.ExecuteNonQuery() ==1)
                    {
                        MessageBox.Show("Пользователь успешно добавлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибочка!");
                    }
                    con.Close();
                }
                
                
            }
        }

        private void registr_Load(object sender, EventArgs e)
        {

        }

        private void registr_Load_1(object sender, EventArgs e)
        {

        }
    }
}
