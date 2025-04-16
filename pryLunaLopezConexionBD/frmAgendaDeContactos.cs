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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryLunaLopezConexionBD
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        clsConexionBD conexionBD = new clsConexionBD();

        private void Form1_Load(object sender, EventArgs e)
        {
            conexionBD.MostrarContactos(dgvContactos);
            conexionBD.llenarComboCate(cmbCategoria);
            CargarComboBox();
            dgvContactos.CellEndEdit += dgvContactos_CellEndEdit;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsConexionBD agregar = new clsConexionBD();
            agregar.nombre = txtNombre.Text;
            agregar.apellido = txtApellido.Text;
            agregar.telefono = txtTelefono.Text;
            agregar.correo = txtCorreo.Text;
            agregar.categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);
            agregar.agregarContacto();

            MessageBox.Show("El contacto ha sido añadido exitosamente");

            conexionBD.MostrarContactos(dgvContactos);


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=localhost;Database=Comercio;Trusted_Connection=True;");
            conexion.Open();
            int idSeleccionado = Convert.ToInt32(cmbId.SelectedValue);

            string deleteQuery = "DELETE FROM Contactos WHERE Id = @Id";
            SqlCommand deleteCmd = new SqlCommand(deleteQuery, conexion);
            deleteCmd.Parameters.AddWithValue("@Id", idSeleccionado);
            deleteCmd.ExecuteNonQuery();

            MessageBox.Show("El contacto ha sido eliminado exitosamente");

            conexionBD.MostrarContactos(dgvContactos);
        }

        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarComboBox()
        {
            SqlConnection conexion = new SqlConnection("Server=localhost;Database=Comercio;Trusted_Connection=True;");
            conexion.Open();

            string query = "SELECT Id, Nombre + ' ' + Apellido AS NombreCompleto FROM Contactos";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbId.DisplayMember = "NombreCompleto";
            cmbId.ValueMember = "Id";
            cmbId.DataSource = dt;

            conexion.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbId.SelectedValue);
            clsConexionBD conexion = new clsConexionBD();
            DataTable resultado = conexion.BuscarContactoPorId(id);
            dgvContactos.DataSource = resultado;

        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            conexionBD.MostrarContactos(dgvContactos);
        }

        private void dgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvContactos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            clsConexionBD modificar = new clsConexionBD();
            modificar.id = Convert.ToInt32(dgvContactos.Rows[e.RowIndex].Cells["Id"].Value);
            modificar.nombre = dgvContactos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            modificar.apellido = dgvContactos.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            modificar.telefono = dgvContactos.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
            modificar.categoriaId = Convert.ToInt32(dgvContactos.Rows[e.RowIndex].Cells["CategoriaId"].Value);
            modificar.modificarContacto();
           
        }
    }
}
