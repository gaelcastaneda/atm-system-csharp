using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajero
{
    public partial class Ingretiro : Form
    {
        int z = 0;
        public Ingretiro()
        {
            InitializeComponent();
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            z += 1000;
            txtDiner.Text = Convert.ToString(z);
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            z += 500;
            txtDiner.Text = Convert.ToString(z);
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            z += 200;
            txtDiner.Text = Convert.ToString(z);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            z += 20;
            txtDiner.Text = Convert.ToString(z);
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            z += 50;
            txtDiner.Text = Convert.ToString(z);
        }

        private void txtDiner_TextChanged(object sender, EventArgs e)
        {
            txtDiner.Text = Convert.ToString(z);
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Retiro realizado con exito");
            this.Hide();
            Menu mar = new Menu();
            mar.Show();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            z += 100;
            txtDiner.Text = Convert.ToString(z);
        }
    }
}
