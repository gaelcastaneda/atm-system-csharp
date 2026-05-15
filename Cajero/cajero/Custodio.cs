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
    public partial class Custodio : Form
    {
        int intentos = 3;
        public Custodio()
        {
            InitializeComponent();
        }

        private void txtUsus_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void txtContr_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            if (txtUsus.Text == "Gael" && txtContr.Text == "1417")
            {
               this.Hide();
               Ingcus ingcus2 = new Ingcus();
               ingcus2.Show();
            }
            else
            {
                intentos--;
                MessageBox.Show("Rectifica tus datos");
                txtContr.Clear();

                if (intentos == 0)
                {
                    MessageBox.Show("Datos Incorrectos, Cerrando...");
                    Application.Exit();
                }
                
            }
        }
    }
}
