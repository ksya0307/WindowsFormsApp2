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
        SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.TabIndex = 0;
            textBox2.TabIndex = 1;
            autouser.TabIndex = 2;
            
            textBox2.MaxLength = 20;
            textBox2.TextAlign = HorizontalAlignment.Center;
            

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) autouser_Click(sender,EventArgs.Empty);
        }
        private void autouser_Click(object sender, EventArgs e)
        {
            SHA256_pwd shifr = new SHA256_pwd();
            //если не заполнено одно из полей ввода
            if (textBox1.Text == "" || textBox2.Text == "") MessageBox.Show("Вы заполнили не все поля,\n" +
                "нажмите ОК, чтобы продолжить", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else {
                con.Open();//открытие подключения
                //установление выражения которое будет выполняться
                cmd = new SqlCommand("select login, password from dbo.users where login='" +
                    textBox1.Text + "' and password='" + shifr.SHA256HexHashString(textBox2.Text) + "';", con);
                //выполняет sql-выражение и возвращает строки из таблицы
                SqlDataReader reader = cmd.ExecuteReader();
                string login = "";
                if (reader.HasRows)//если вернул строки
                {
                    while (reader.Read())// построчно считываем данные
                    {
                        textBox1.Focus();
                        login = reader.GetString(0);//получаем в переменную login
                        login = login.Trim(' ');
                    }
                    reader.Close();//закрытие
                    cmd.Dispose();//сброс ресурсов
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль,\n" +
                        "пожалуйста,повторите попытку ",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1_Enter(sender, EventArgs.Empty);
                    textBox2_Enter(sender, EventArgs.Empty);
                    textBox1_Leave(sender, EventArgs.Empty);
                    textBox2_Leave(sender, EventArgs.Empty);

                }
                con.Close();//закрытие подключения

                con.Open();
                //для получения роли
                cmd = new SqlCommand("select role from dbo.users where login='" + login + "'",con);
                role = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                switch (role)
                {
                    case 1://если роль =1 открытие формы для клиента
                        Form4 form4 = new Form4(login);
                        form4.Show();
                        this.Hide();
                        break;
                    case 2://роль =2 открывается форма сотрудника
                        Form3 form3 = new Form3(login);
                        form3.Show();
                        this.Hide();
                        break;
                    case 3://роль =3 открывается форма администратора
                        Form2 form2 = new Form2(login);
                        form2.Show();
                        this.Hide();
                        break;
                }


            }
        }
        private void openreg_Click(object sender, EventArgs e)
        {
            registr registr = new registr();
            registr.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Логин")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.FromArgb(226,66,74);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Пароль";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Пароль")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '•';
                textBox2.ForeColor = Color.FromArgb(226, 66, 74);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Логин";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
