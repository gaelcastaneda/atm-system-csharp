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

    public partial class Form1 : Form
    {
        int intentos = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu Man = new Menu();
            Man.Show();
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            if (txtUsusario.Text == "Gael" && txtCont.Text == "1413")
            {
                this.Hide();
                Ingretiro ingr = new Ingretiro();
                ingr.Show();
            }
            else
            {
                intentos--;
                MessageBox.Show("Rectifica tus datos");
                txtCont.Clear();

                if (intentos == 0)
                {
                    MessageBox.Show("Datos Incorrectos, Cerrando...");
                    Application.Exit();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtCont_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
