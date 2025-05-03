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
            dgvProductos.CellEndEdit += dgvProductos_CellEndEdit;
            dgvProductos.Columns["Codigo"].ReadOnly = true;
            conexionBD.CargarCmbProductos(cmbProducto);
        }



        private void dgvProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            clsConexionBD modificar = new clsConexionBD();
            modificar.codigo = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Codigo"].Value);
            modificar.nombre = dgvProductos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            modificar.descripcion = dgvProductos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            modificar.precio = Convert.ToDecimal(dgvProductos.Rows[e.RowIndex].Cells["Precio"].Value);
            modificar.stock = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Stock"].Value);
            modificar.categoriaId = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["CategoriaId"].Value);
            modificar.modificarProducto();

        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            conexionBD.mostrarProductos(dgvProductos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbProducto.SelectedValue);
            clsConexionBD conexion = new clsConexionBD();
            DataTable resultado = conexion.BuscarProductoPorId(id);
            dgvProductos.DataSource = resultado;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsConexionBD agregar = new clsConexionBD();
            agregar.nombre = txtNombre.Text;
            agregar.descripcion = txtDescripcion.Text;
            agregar.precio = Convert.ToDecimal(txtPrecio.Text);
            agregar.stock = Convert.ToInt32(numStock.Value);
            agregar.categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);
            agregar.agregarProducto();

            conexionBD.mostrarProductos(dgvProductos);
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Para evitar errores al hacer clic en el encabezado
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                // Suponiendo que tenés estos campos
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                cmbCategoria.SelectedValue = fila.Cells["CategoriaId"].Value;
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                numStock.Value = Convert.ToInt32(fila.Cells["Stock"].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsConexionBD conexion = new clsConexionBD();
            if(txtPrecio.Text == "" || txtNombre.Text == "" || txtPrecio.Text == "" || numStock.Value == 0 || cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("¿Está seguro de eliminarlo?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int codigo = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Codigo"].Value);

                    conexion.eliminarProducto(codigo);

                }
            }
            conexion.mostrarProductos(dgvProductos);

        }
    }
}
