using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace pryLunaLopezConexionBD
{
    internal class clsConexionBD
    {
        //cadena de conexion
        string cadenaConexion = "Server=localhost;Database=Comercio;Trusted_Connection=True;";

        //conector
        SqlConnection conexionBaseDatos;

        //comando
        SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;


        public string nombre;
        public string apellido;
        public string telefono;
        public string correo;
        public int categoriaId;
        public int id;


        public void ConectarBD()
        {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

        }

        public void MostrarContactos(DataGridView dgv)
        {
            try
            {
                ConectarBD();
                string consulta = "SELECT Id, Nombre, Apellido, Telefono, Correo, CategoriaId FROM Contactos";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionBaseDatos);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dgv.AutoGenerateColumns = true;

                dgv.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar contactos: " + ex.Message);
            }
        }

        public void llenarComboCate(ComboBox cmb)
        {
            ConectarBD();
            string consulta = "SELECT Id, Nombre FROM Categorias";
            SqlCommand comando = new SqlCommand(consulta, conexionBaseDatos);
            SqlDataReader lector = comando.ExecuteReader();

            DataTable tabla = new DataTable();
            tabla.Load(lector);

            cmb.DisplayMember = "Nombre";
            cmb.ValueMember = "Id";
            cmb.DataSource = tabla;

        }

        public void agregarContacto()
        {
            ConectarBD();
            string consulta = "INSERT INTO Contactos (Nombre, Apellido, Telefono, Correo, CategoriaId) VALUES (@Nombre, @Apellido, @Telefono, @Correo, @CategoriaId)";
            using (SqlCommand comando = new SqlCommand(consulta, conexionBaseDatos))
            {
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@Correo", correo);
                comando.Parameters.AddWithValue("@CategoriaId", categoriaId);

                comando.ExecuteNonQuery();
            }

        }


        public DataTable BuscarContactoPorId(int id)
        {
            DataTable resultado = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "SELECT * FROM Contactos WHERE Id = @id";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);
                }
            }

            return resultado;
        }

        public void modificarContacto()
        {
            ConectarBD();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "UPDATE Contactos SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, CategoriaId = @CategoriaId WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Contacto actualizado correctamente.");
        }

    }
}
