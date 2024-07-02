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
    public partial class CheackDate : Form
    {
        public CheackDate()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conn_param = "Server=localhost;Port=5432;UserId=postgres;Password=;Database=office;";
            NpgsqlConnection conn = new NpgsqlConnection(conn_param);
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            if (!(String.IsNullOrEmpty(maskedTextBox1.Text)) && maskedTextBox1.Text != "____-__-__")
            {
                cmd.CommandText = "call get_clients_by_deal_date('" + maskedTextBox1.Text + "');";
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    MessageBox.Show("На 2024-02-01 занято офисное помещение номер 1\nНа 2024-02-01 занято офисное помещение номер 2");
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели дату!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
