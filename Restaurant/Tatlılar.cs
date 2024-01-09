using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Restaurant
{
    public partial class Tatlılar : Form
    {
       
        public Tatlılar()
        {
            InitializeComponent();
        }
       
        private void Tatlılar_Load(object sender, EventArgs e)
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

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Yecekler y = new Yecekler();
            this.Hide();
            y.ShowDialog();
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

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            Tatlılar t = new Tatlılar();
            this.Hide();
            t.ShowDialog();
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton210_Click(object sender, EventArgs e)
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

