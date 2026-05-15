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
    public partial class Ingcus : Form
    {
        int r = 0;
        public Ingcus()
        {
            InitializeComponent();
        }

        private void Ingcus_Load(object sender, EventArgs e)
        {

        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            r += 1000;
            txtDep.Text = Convert.ToString(r);
        }

        private void txtDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn500_Click(object sender, EventArgs e)
        {
            r += 500;
            txtDep.Text = Convert.ToString(r);
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            r += 200;
            txtDep.Text = Convert.ToString(r);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            r += 100;
            txtDep.Text = Convert.ToString(r);
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            r += 50;
            txtDep.Text = Convert.ToString(r);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            r += 20;
            txtDep.Text = Convert.ToString(r);
        }

        private void btnDepo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deposito realizado con exito");
            this.Hide();
            Menu sar = new Menu();
            sar.Show();
        }
    }
}
