using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaLopezConexionBD
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            ucProductos.Dock = DockStyle.Fill;
            ucContactos.Dock = DockStyle.Fill;

            pUcProductos.Controls.Add(ucProductos);
            pUcProductos.Controls.Add(ucContactos);

            ucProductos.Visible = true;
            ucContactos.Visible = false;

        }


        ucContactos ucContactos = new ucContactos();
        ucProductos ucProductos = new ucProductos();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogIn logIn = new frmLogIn();
                logIn.Show();

                this.Hide();
            }

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ucProductos.Visible = true;
            ucProductos.BringToFront();
            ucContactos.Visible = false;
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            ucContactos.Visible = true;
            ucContactos.BringToFront();
            ucProductos.Visible = false;
        }



    }
}
