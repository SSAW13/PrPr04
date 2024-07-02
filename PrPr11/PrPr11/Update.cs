using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrPr11
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox1.Text)) && !(String.IsNullOrEmpty(textBox2.Text)) && !(String.IsNullOrEmpty(textBox3.Text)) && !(String.IsNullOrEmpty(textBox4.Text)))
            {
                string conn_param = "Server=localhost;Port=5432;UserId=postgres;Password=;Database=office;";
                NpgsqlConnection conn = new NpgsqlConnection(conn_param);
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update room set size = " + textBox2.Text + ", floor = " + textBox3.Text + ", price_per_day = " + textBox4.Text + " where id = " + textBox1.Text + ";";
                conn.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
            OfficeList officeList = new OfficeList();
            officeList.Show();
            this.Close();
        }
    }
}
