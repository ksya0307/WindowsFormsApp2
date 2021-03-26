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
    public partial class Form1 : Form
    {
        int role;
        bool auth;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.TabIndex = 0;
            textBox2.TabIndex = 1;
            button1.TabIndex = 2;
            textBox2.Text = "";
            textBox2.PasswordChar = '•';
            textBox2.MaxLength = 20;
            textBox2.TextAlign = HorizontalAlignment.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Avt();
        }
        public void Avt()
        {
            
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.con);
            string zapros = "select login, password from dbo.users";

            connection.Open();

            SqlCommand sqlCommand = new SqlCommand(zapros, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            string login="", password="";
            if (reader.HasRows)
            {
                
                while (reader.Read())
                {
                    textBox1.Focus();
                    login = reader.GetString(0);
                    password = reader.GetString(1);
                    
                    login = login.Trim(' ');
                    password = password.Trim(' ');

                    if (textBox1.Text == login && textBox2.Text == password)
                    {
                        auth = true;
                        break;
                    }



                }

                reader.Close();
                sqlCommand.Dispose();
                string query = "select role from dbo.users where login='" + login + "' and password='" + password + "'";
                sqlCommand.CommandText = query;
                role = Convert.ToInt32(sqlCommand.ExecuteScalar());
                if (auth)
                {
                    switch (role)
                    {
                        case 1:
                            Form4 form4 = new Form4();
                            form4.Show();
                            this.Hide();
                            break;
                        case 2:
                            Form3 form3 = new Form3();
                            form3.Show();
                            this.Hide();
                            break;
                        case 3:
                            Form2 form2 = new Form2();
                            form2.Show();
                            this.Hide();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль,\nпожалуйста,повторите попытку ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) Avt();
        }
    }
}
