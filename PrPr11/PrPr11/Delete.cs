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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrPr11
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox1.Text)) && textBox2.Text == "УДАЛИТЬ")
            {
                string conn_param = "Server=localhost;Port=5432;UserId=postgres;Password=;Database=office;";
                NpgsqlConnection conn = new NpgsqlConnection(conn_param);
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from room where id = " + textBox1.Text + ";";
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
