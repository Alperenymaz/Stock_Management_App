using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Products prod = new Products();
            prod.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Users prod = new Users();
            prod.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Categories prod = new Categories();
            prod.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Users prod = new Users();
            prod.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Products prod = new Products();
            prod.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Categories prod = new Categories();
            prod.Show();
            this.Hide();
        }
    }
}
