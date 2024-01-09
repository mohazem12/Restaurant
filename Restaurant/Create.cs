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
using Bunifu.UI.WinForms;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace Restaurant
{
    public partial class Create : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;


        public Create()
        {
            InitializeComponent();
        }
        void GetCustomers()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Restaurant.accdb ");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM Costumer ", conn);
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {


        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {

            try
            {

                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Restaurant.accdb ");
                conn.Open();


                OleDbCommand cmd = new OleDbCommand(); 
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Costumer (FullName, Email, [Number], Adress, [Password]) " +
                              "VALUES (@FullName, @Email, @Number, @Adress, @Password)";



                cmd.Parameters.AddWithValue("@FullName", FullName.Text); 
                cmd.Parameters.AddWithValue("@Email", Email.Text);
                cmd.Parameters.AddWithValue("@Number", Number.Text);
                cmd.Parameters.AddWithValue("@Adress", Adress.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Text);

            
                cmd.ExecuteNonQuery();
                MessageBox.Show("User inserted");
                GetCustomers();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            Home H = new Home();
            this.Hide();
            H.ShowDialog();
        }

        private void bunifuTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }
    }
}
