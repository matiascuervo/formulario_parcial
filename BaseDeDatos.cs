using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace formulario_parcial
{
    public class BaseDatosManager
    {
        private readonly string _connectionString;

        public BaseDatosManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string ConnectionString
        {
            get { return _connectionString; }
        }

        public void MostrarUsuarios()
        {
            string query = "SELECT * FROM Usuarios";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["ID"]}, Usuario: {reader["usuario"]}, Rol: {reader["rol"]}, Estado: {reader["estado"]}");
                        }
                    }
                }
            }
        }

        public static void ConectarBaseDeDatos()
        {
            string connectionString = "Data Source=DESKTOP-7SSNEAH\\MATIASSQL;Initial Catalog=MiBaseDeDatos;Integrated Security=True";

            BaseDatosManager manager = new BaseDatosManager(connectionString);
            manager.MostrarUsuarios();
        }




        public void ProbarConexion()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    MessageBox.Show("¡Conexión exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }













    }
}







