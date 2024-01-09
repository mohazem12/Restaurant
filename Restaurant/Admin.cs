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
using System.Xml.Linq;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace Restaurant
{
    public partial class Admin : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        public Admin()
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
        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

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
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {
          
            DataView dv = dt.DefaultView;
            dv.RowFilter = "FullName LIKE '%" + Search.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Restaurant.accdb ");
            conn.Open();


            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT* FROM Costumer (Id ,FullName, Email, [Number], Adress, [Password]) " +
                              "VALUES (@Id,@FullName, @Email, @Number, @Adress, @Password)";
            
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            FullName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Email.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Number.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Adress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Password.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            string delet = "DELETE FROM Costumer WHERE FullName= @FullName";

            cmd = new OleDbCommand(delet, conn);
            cmd.Parameters.AddWithValue("@FullName", FullName.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("user deleted");
            GetCustomers();
        }

        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
            
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            string duzelt = "UPDATE Costumer SET FullName=@FullName, Email=@Email, [Number]=@Number, Adress=@Adress, [Password]=@Password WHERE [Password]=@Password";


            cmd = new OleDbCommand(duzelt, conn);
            cmd.Parameters.AddWithValue("@name", FullName.Text);
            cmd.Parameters.AddWithValue("@Email", Email.Text);
            cmd.Parameters.AddWithValue("@Number", Number.Text);
            cmd.Parameters.AddWithValue("@Adress", Adress.Text);
            cmd.Parameters.AddWithValue("@Password", Password.Text);



            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("user Updated");
            GetCustomers();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void FullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Number_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
