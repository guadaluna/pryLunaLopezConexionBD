using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaLopezConexionBD
{
    public partial class ucContactos : UserControl
    {
        public ucContactos()
        {
            InitializeComponent();
        }

        clsConexionBD conexionBD = new clsConexionBD();

        private void ucContactos_Load(object sender, EventArgs e)
        {
            conexionBD.mostrarContactos(dgvContactos);
            conexionBD.llenarComboCate(cmbCategoria);
            dgvContactos.AllowUserToAddRows = false;
        }

        private void dgvContactos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            conexionBD.id = Convert.ToInt32(dgvContactos.Rows[e.RowIndex].Cells["Id"].Value);
            conexionBD.nombre = dgvContactos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            conexionBD.apellido = dgvContactos.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            conexionBD.telefono = dgvContactos.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
            conexionBD.categoriaId = Convert.ToInt32(dgvContactos.Rows[e.RowIndex].Cells["CategoriaId"].Value);
            conexionBD.modificarContacto();

        }
        private void dgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvContactos.Rows[e.RowIndex];

                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
                cmbCategoria.SelectedValue = fila.Cells["CategoriaId"].Value;
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!txtTelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("El teléfono debe contener solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" || cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conexionBD.nombre = txtNombre.Text;
                conexionBD.apellido = txtApellido.Text;
                conexionBD.telefono = txtTelefono.Text;
                conexionBD.correo = txtCorreo.Text;
                conexionBD.categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);
                conexionBD.agregarContacto();
;
            }

            conexionBD.mostrarContactos(dgvContactos);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!txtTelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("El teléfono debe contener solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (txtNombre.Text == "" || txtApellido.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" || cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dgvContactos.CurrentRow != null)
            {
                int idContacto = Convert.ToInt32(dgvContactos.CurrentRow.Cells["Id"].Value);

                conexionBD.id = idContacto;
                conexionBD.nombre = txtNombre.Text;
                conexionBD.apellido = txtApellido.Text;
                conexionBD.telefono = txtTelefono.Text;
                conexionBD.correo = txtCorreo.Text;
                conexionBD.categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);
                conexionBD.modificarContacto();

                MessageBox.Show("Contacto modificado con éxito");
                conexionBD.mostrarContactos(dgvContactos);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" || cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un Contacto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de eliminarlo?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int codigo = Convert.ToInt32(dgvContactos.CurrentRow.Cells["Id"].Value);

                    conexionBD.eliminarContacto(codigo);

                }
            }
            conexionBD.mostrarContactos(dgvContactos);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = conexionBD.buscarContacto(txtBuscar.Text);

            if (dt != null)
            {
                dgvContactos.DataSource = dt;
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            conexionBD.mostrarContactos(dgvContactos);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
        }

    }
}
