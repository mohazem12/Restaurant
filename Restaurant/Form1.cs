using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        OleDbDataReader dr;
        void GetCustomers()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Restaurant.accdb ");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM Admin", conn);
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click_1(object sender, EventArgs e)
        {
            GetCustomers();
            string Email = email.Text;
            string Password = password.Text;
            cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Admin WHERE Email= ? AND Password= ?";
            cmd.Parameters.AddWithValue("Email", Email);
            cmd.Parameters.AddWithValue("Password", Password);

            using (OleDbDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    Home h = new Home();
                    this.Hide();
                    h.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Worng User Name or Password ");
                }

            }
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            Create c = new Create() ;
            this.Hide();
            c.ShowDialog();
        }
    }
}
