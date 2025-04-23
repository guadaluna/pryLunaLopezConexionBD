using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlTypes;


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


        public string descripcion;
        public decimal precio;
        public int stock;
        public int codigo;


        public void ConectarBD()
        {
            conexionBaseDatos = new SqlConnection(cadenaConexion);

            nombreBaseDeDatos = conexionBaseDatos.Database;

            conexionBaseDatos.Open();

        }

        //TABLA CONTACTOS
        //Mostrar en agenda
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

        //Llenar combobox de categorias de la agenda
        public void llenarComboCate(ComboBox cmb)
        {
            try
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
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           

        }

        //Agregar contactos de la agenda
        public void agregarContacto()
        {
            try
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
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        //Buscar contacto
        public DataTable BuscarContactoPorId(int id)
        {
            try
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


            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }

        }

        //Modificar contacto en la agenda
        public void modificarContacto()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        //TABLA PRODUCTOS
        //Agregar un producto a la tabla

        public void mostrarProductos(DataGridView dgv)
        {
            try
            {
                ConectarBD();
                string consulta = "SELECT Codigo, Nombre, Descripcion, Precio, Stock, CategoriaId FROM Productos";

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

        public void agregarProducto()
        {
            try
            {
                ConectarBD();
                string insertQuery = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, CategoriaId) VALUES (@nombre, @descripcion, @precio, @stock, @categoriaId)";
                SqlCommand cmd = new SqlCommand(insertQuery, conexionBaseDatos);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@categoriaId", categoriaId); // Tecnología
                cmd.ExecuteNonQuery();
                MessageBox.Show("✅ Producto agregado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void modificarProducto()
        {
            try
            {
                ConectarBD();
                string updateQuery = "UPDATE Productos SET Nombre = @nombre, Descripcion = @descripcion, Precio = @precio, Stock = @stock, CategoriaId = @categoriaId WHERE Codigo = @Codigo";
                SqlCommand cmd = new SqlCommand(updateQuery, conexionBaseDatos);

                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@categoriaId", categoriaId);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@stock", stock);

                cmd.ExecuteNonQuery();
                MessageBox.Show("🔄 Producto actualizado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        public void CargarCmbProductos(ComboBox cmb)
        {
            try
            {
                ConectarBD();
                string consulta = "SELECT Codigo, Nombre AS Producto FROM Productos";
                SqlCommand cmd = new SqlCommand(consulta, conexionBaseDatos);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmb.DisplayMember = "Producto";
                cmb.ValueMember = "Codigo";
                cmb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public DataTable BuscarProductoPorId(int codigo)
        {
            try
            {
                DataTable resultado = new DataTable();

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string consulta = "SELECT * FROM Productos WHERE Codigo = @codigo";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@codigo", codigo);

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(resultado);
                    }
                }

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public void eliminarProducto(int codigo)
        {
            try
            {
                ConectarBD();
                string consulta = "DELETE FROM Productos WHERE Codigo = @codigo";
                SqlCommand deleteCmd = new SqlCommand(consulta, conexionBaseDatos);
                deleteCmd.Parameters.AddWithValue("@codigo", codigo);
                deleteCmd.ExecuteNonQuery();

                MessageBox.Show("El contacto ha sido eliminado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




    }
}
