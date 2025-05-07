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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        bool mostrarContraseña = false;

        clsConexionBD conexionBD = new clsConexionBD();

        private void foxLinkLabel2_Click_1(object sender, EventArgs e)
        {
            frmSignIn signIn = new frmSignIn();
 
            signIn.Show();
            this.Hide();

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Por favor complete los campos");
            }
            else
            {
                conexionBD.usuario = txtUsuario.Text;
                conexionBD.contrasena = txtContraseña.Text;

                if (conexionBD.IniciarSesion())
                {
                    frmPrincipal form = new frmPrincipal();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
        }

        private void picVerContraseña_Click(object sender, EventArgs e)
        {
            mostrarContraseña = !mostrarContraseña;

            txtContraseña.UseSystemPasswordChar = !mostrarContraseña;

            picVerContraseña.Image = mostrarContraseña
                ? Properties.Resources.icons8_eye_15
                : Properties.Resources.icons8_closed_eye_15;
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn_Click(sender, e);
            }
        }
    }
}
