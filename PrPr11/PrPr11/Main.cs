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
    public partial class Main : Form
    {
        public Main(string user)
        {
            InitializeComponent();
            label1.Text = user;
            String role = "";
            for (int i = label1.Text.Length - 1; i > 0; i--)
            {
                if (label1.Text[i] != ' ' && role != "тнеилК")
                {
                    role += label1.Text[i];
                }
            }
            if (role == "тнеилК")
            {
                button2.Visible = false;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheackDate cheackDate = new CheackDate();
            cheackDate.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Enter enter = new Enter();
            enter.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OfficeList officeList = new OfficeList();
            officeList.Show();
        }
    }
}
