using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Yecekler : Form
    {
        public Yecekler()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            İçecekler c = new İçecekler();
            this.Hide();
            c.ShowDialog();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            Tatlılar t = new Tatlılar();
            this.Hide();
            t.ShowDialog();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            Sepetim s = new Sepetim();
            this.Hide();
            s.ShowDialog();
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.ShowDialog();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bunifuButton218_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();

        }

        private void bunifuButton28_Click(object sender, EventArgs e)
        {

        }

        private void Sipariş_Click(object sender, EventArgs e)
        {
            Sipariş s = new Sipariş();
            this.Hide();
            s.ShowDialog();

        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Ücret_TextChanged(object sender, EventArgs e)
        {

        }

        private void Yecek_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adet_TextChanged(object sender, EventArgs e)
        {

        }

        private void Masa_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton219_Click(object sender, EventArgs e)
        {

            Sipariş s = new Sipariş();
            this.Hide();
            s.ShowDialog();
        }
    }
}
