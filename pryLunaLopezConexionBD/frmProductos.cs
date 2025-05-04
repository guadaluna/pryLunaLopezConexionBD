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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        clsConexionBD conexionBD = new clsConexionBD();

        private void frmProductos_Load(object sender, EventArgs e)
        {
            conexionBD.mostrarProductos(dgvProductos);
            conexionBD.llenarComboCate(cmbCategoria);
            dgvProductos.CellEndEdit += dgvProductos_CellEndEdit;
            dgvProductos.Columns["Codigo"].ReadOnly = true;
            //conexionBD.CargarCmbProductos(cmbProducto);
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

        /*
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbProducto.SelectedValue);
            clsConexionBD conexion = new clsConexionBD();
            DataTable resultado = conexion.BuscarProductoPorId(id);
            dgvProductos.DataSource = resultado;
        }
        */

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Codigo"].Value);
            clsConexionBD conexion = new clsConexionBD();
            conexion.eliminarProducto(codigo);
            conexion.mostrarProductos(dgvProductos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsConexionBD agregar = new clsConexionBD();
            agregar.nombre = txtNombre.Text;
            agregar.descripcion = txtDescripcion.Text;
            agregar.precio = Convert.ToDecimal(txtPrecio.Text);
            agregar.stock = Convert.ToInt32(dungeonNumeric1.Value);
            agregar.categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);
            agregar.agregarProducto();

            conexionBD.mostrarProductos(dgvProductos);
        }
    }
}
