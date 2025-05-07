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
    public partial class ucProductos : UserControl
    {
        public ucProductos()
        {
            InitializeComponent();
        }

        clsConexionBD conexionBD = new clsConexionBD();

        private void ucProductos_Load(object sender, EventArgs e)
        {
            conexionBD.mostrarProductos(dgvProductos);
            conexionBD.llenarComboCate(cmbCategoria);
            dgvProductos.AllowUserToAddRows = false;
        }





        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                cmbCategoria.SelectedValue = fila.Cells["CategoriaId"].Value;
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                numStock.Value = Convert.ToInt32(fila.Cells["Stock"].Value);
            }
        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!txtPrecio.Text.All(char.IsDigit))
            {
                MessageBox.Show("El precio debe contener solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPrecio.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == "" || numStock.Value == 0 || cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conexionBD.nombre = txtNombre.Text;
                conexionBD.descripcion = txtDescripcion.Text;
                conexionBD.precio = Convert.ToDecimal(txtPrecio.Text);
                conexionBD.stock = Convert.ToInt32(numStock.Value);
                conexionBD.categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);
                conexionBD.agregarProducto();

                conexionBD.mostrarProductos(dgvProductos);
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == "" || numStock.Value == 0 || cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dgvProductos.CurrentRow != null)
            {
                int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Codigo"].Value);

                conexionBD.codigo = idProducto;
                conexionBD.nombre = txtNombre.Text;
                conexionBD.descripcion = txtDescripcion.Text;
                conexionBD.precio = Convert.ToDecimal(txtPrecio.Text);
                conexionBD.stock = Convert.ToInt32(numStock.Value);
                conexionBD.categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);
                conexionBD.modificarProducto();

                MessageBox.Show("Producto modificado con éxito");
                conexionBD.mostrarProductos(dgvProductos);
            }
        }
 

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == "" || numStock.Value == 0 || cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de eliminarlo?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int codigo = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Codigo"].Value);

                    conexionBD.eliminarProducto(codigo);

                }
            }
            conexionBD.mostrarProductos(dgvProductos);

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = conexionBD.buscarPorNombre(txtBuscar.Text);

            if (dt != null)
            {
                dgvProductos.DataSource = dt;
            }
        }


        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            conexionBD.mostrarProductos(dgvProductos);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            numStock.Text = "";
        }
    }
}
