﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblotecaDatamanager;
using BibliotecaDatamanager;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;

namespace formulario_parcial
{
    public partial class FormularioUsuario : Form
    {
        private BaseDatosManager baseDatosManager;
        // La instancia única de UserManager Singleton
        private UserManager userManager = UserManager.Instancia;

        private Logger logger;
        public FormularioUsuario()
        {
            InitializeComponent();

            ConfigurarAutocompletado();
            string enviroment = AppDomain.CurrentDomain.BaseDirectory;
            string rutaRelativa = Path.Combine(enviroment, "..", "..", "..", "logger_Excepciones");
            string logFileName = "logger_Errores.txt";
            logger = new Logger(rutaRelativa, logFileName);
            

        }

        private void ConfigurarAutocompletado()
        {
            // Colección de cadenas para el autocompletado
            var fuenteAutocompletado = new AutoCompleteStringCollection();
            fuenteAutocompletado.AddRange(userManager.GetUsuarios().Select(u => u.Nombre).ToArray());

            // Configurar el TextBox para el autocompletado
            textBoxNombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxNombre.AutoCompleteCustomSource = fuenteAutocompletado;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            string Nombre = textBoxNombre.Text;
        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            string contraseña = textBoxDNI.Text;
        }

        public void Boton_login_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBoxNombre.Text;
                string contraseña = textBoxDNI.Text;

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(contraseña))
                {
                    throw new ArgumentException("El nombre y la contraseña son obligatorios.");
                }

                // Utilizar la instancia de DataManager para verificar credenciales
                if (!userManager.VerificarCredenciales(nombre, contraseña))
                {
                    throw new ArgumentException("Credenciales incorrectas.");
                }

                /*if (VerificarCredencialesBaseDeDatos())
                {
                    throw new ArgumentException("Credenciales De incorrectas.");
                }*/

                IPersona usuario = userManager.GetUsuarios().FirstOrDefault(u => u.Nombre == nombre);

                if (usuario != null && usuario.Estado == "Activo")
                {
                    textBoxNombre.Clear();
                    textBoxDNI.Clear();

                    Form_alquiler form_Alquiler = new Form_alquiler();
                    this.Hide();
                    form_Alquiler.ShowDialog();
                }
                else if (usuario != null && usuario.Estado == "Debaja")
                {
                    MessageBox.Show("Ha sido dado de baja de la aplicación. Comuníquese con el soporte o llame al número 464-4100 para obtener más ayuda.", "Usuario Dado de Baja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    throw new ArgumentException("Usuario no encontrado.");
                }
            }
            catch (ArgumentException ex)
            {
                var methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                var className = this.GetType().Name;


                logger.LogError(ex, $"Error al validar Credenciales.", methodName, className);

                MessageBox.Show("Error: " + ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /*public bool VerificarCredencialesBaseDeDatos()
        {
            string nombre = textBoxNombre.Text;
            string contraseña = textBoxDNI.Text;

            // Consulta SQL para verificar las credenciales
            string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Nombre AND Contraseña = @Contraseña";

            using (SqlConnection connection = new SqlConnection("tu_cadena_de_conexión"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros para evitar inyecciones SQL
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    // Si count es mayor que cero, las credenciales son válidas
                    return count > 0;
                }
            }
        }*/

        public bool VerificarCredencialesBaseDeDatos()
        {
            try
            {
                string nombre = textBoxNombre.Text;
                string contraseña = textBoxDNI.Text;


                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(contraseña))
                {
                    throw new ArgumentException("El nombre y la contraseña son obligatorios.");
                }

                // Consulta SQL para verificar las credenciales
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Nombre AND Contraseña = @Contraseña";

                using (SqlConnection connection = new SqlConnection("\"Data Source=DESKTOP-7SSNEAH\\\\MATIASSQL;Initial Catalog=MiBaseDeDatos;Integrated Security=True\""))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar parámetros para evitar inyecciones SQL
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Contraseña", contraseña);

                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        // Si count es mayor que cero, las credenciales son válidas
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                var methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                var className = this.GetType().Name;

                logger.LogError(ex, $"Error al verificar credenciales en la base de datos.", methodName, className);

                MessageBox.Show("Error: " + ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Retorna false en caso de error
            }
        }










        private void Boton_Atras_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_inicio inicio = new Form_inicio();
            inicio.ShowDialog();
        }








    }
    
}
