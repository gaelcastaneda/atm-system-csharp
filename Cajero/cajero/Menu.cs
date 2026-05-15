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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 registro = new Form1();
            registro.Show();
        }

        private void btnCustodio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Custodio custodio = new Custodio();
            custodio.Show();
        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
