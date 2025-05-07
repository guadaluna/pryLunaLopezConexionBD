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
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }
        bool mostrarContraseña = false;

        clsConexionBD conexionBD = new clsConexionBD();

        private void linkLblIniSesion_Click(object sender, EventArgs e)
        {
            frmLogIn logIn = new frmLogIn();
            logIn.Show();

            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContraseña.Text == "" || txtReContraseña.Text == "")
            {
                MessageBox.Show("Por favor completa todos los datos");
            }
            else if (txtContraseña.Text != txtReContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else
            {
                conexionBD.usuario = txtUsuario.Text;
                conexionBD.contrasena = txtContraseña.Text;
                conexionBD.RegistrarUsuario();

                frmLogIn logIn = new frmLogIn();
                logIn.Show();

                this.Hide();

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

        private void picReContraseña_Click(object sender, EventArgs e)
        {
            mostrarContraseña = !mostrarContraseña;

            txtReContraseña.UseSystemPasswordChar = !mostrarContraseña;

            picReContraseña.Image = mostrarContraseña
                ? Properties.Resources.icons8_eye_15
                : Properties.Resources.icons8_closed_eye_15;
        }

    }
}
