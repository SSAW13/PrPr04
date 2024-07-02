using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrPr11
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 15;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginEnt = textBox1.Text;
            string passwordEnt = textBox2.Text;
            string login;
            string password;
            string user;
            string role;
            bool key = false;
            if (!(String.IsNullOrEmpty(textBox1.Text)) && !(String.IsNullOrEmpty(textBox2.Text)))
            {
                string conn_param = "Server=localhost;Port=5432;UserId=postgres;Password=;Database=office;";
                NpgsqlConnection conn = new NpgsqlConnection(conn_param);
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select u.login, u.password, u.lastname, u.name, u.role, r.title from users u, role r where u.role = r.id;";
                conn.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        login = rdr["login"].ToString();
                        password = rdr["password"].ToString();
                        role = rdr["role"].ToString();
                        user = rdr["lastname"].ToString() + " " + rdr["name"].ToString() + " " + rdr["title"].ToString();
                        if (login == loginEnt)
                        {
                            if (password == MD5shif(passwordEnt))
                            {
                                key = true;
                                if (role == "1")
                                {
                                    Main main = new Main(user);
                                    main.Show();
                                    this.Hide();
                                }
                                else if (role == "2")
                                {
                                    Main main = new Main(user);
                                    main.Show();
                                    this.Hide();
                                }
                                else if (role == "3")
                                {
                                    Main main = new Main(user);
                                    main.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Произошла ошибка уровня доступа, обратитись к администратору за помощью");
                                }
                            }
                        }

                    }
                    if (key == false)
                    {
                        MessageBox.Show("Некорректный логин или пароль");
                        conn.Close();
                    }
                }
            }
        }

        static string MD5shif(string pass)
        {
            var crypt = new MD5CryptoServiceProvider();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(pass));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }
    }
}
