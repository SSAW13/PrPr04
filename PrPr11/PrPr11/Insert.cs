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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox1.Text)) && !(String.IsNullOrEmpty(textBox2.Text)) && !(String.IsNullOrEmpty(textBox3.Text)))
            {
                string conn_param = "Server=localhost;Port=5432;UserId=postgres;Password=;Database=office;";
                NpgsqlConnection conn = new NpgsqlConnection(conn_param);
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into room (size, floor, price_per_day) values (" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text +");";
                conn.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                conn.Close();
            } else
            {
                MessageBox.Show("Не все поля заполнены");
            }
            OfficeList officeList = new OfficeList();
            officeList.Show();
            this.Close();
        }
    }
}
