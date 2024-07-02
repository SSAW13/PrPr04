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
    public partial class OfficeList : Form
    {
        public OfficeList()
        {
            InitializeComponent();
        }

        private void OfficeList_Load(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void updateGrid()
        {
            string conn_param = "Server=localhost;Port=5432;UserId=postgres;Password=;Database=office;";
            NpgsqlConnection conn = new NpgsqlConnection(conn_param);
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id, size, floor, price_per_day from room;";
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.Columns.Add("id", "id");
                dataGridView1.Columns.Add("size", "Площадь");
                dataGridView1.Columns.Add("floor", "Этаж");
                dataGridView1.Columns.Add("price_per_day", "Цена за день");
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                    reader["id"],
                    reader["size"],
                    reader["floor"],
                    reader["price_per_day"] + "₽");
                }
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show(); 
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {  
            this.Close();
        }
    }
}
