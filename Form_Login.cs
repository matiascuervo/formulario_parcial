using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblotecaDatamanager;
namespace formulario_parcial
{
    public partial class FormularioUsuario : Form
    {
        //  la instancia única de UserManager proporcionada por el Singleton
        private UserManager userManager = UserManager.Instancia;
        
        public FormularioUsuario()
        {
            InitializeComponent();

            ConfigurarAutocompletado();
            ActualizarUsuarios();
        }

        private void ConfigurarAutocompletado()
        {
            // Crea una colección de cadenas para el autocompletado
            var fuenteAutocompletado = new AutoCompleteStringCollection();
            fuenteAutocompletado.AddRange(userManager.GetUsuarios().Select(u => u.Nombre).ToArray());

            // A Qui Configuro el TextBox para el autocompletado
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

        private void Boton_login_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el nombre y la contraseña de los TextBox
                string nombre = textBoxNombre.Text;
                string contraseña = textBoxDNI.Text;

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(contraseña))
                {
                    throw new ArgumentException("El nombre y la contraseña son obligatorios.");
                }

                // Validar las credenciales utilizando el UserManager (Singleton)
                if (!userManager.VerificarCredenciales(nombre, contraseña))
                {
                    throw new ArgumentException("Credenciales incorrectas.");
                }

                // Obtener la información del usuario
                Persona usuario = userManager.GetUsuarios().FirstOrDefault(u => u.Nombre == nombre);

                // Verificar si el usuario está activo
                if (usuario != null && usuario.Estado == "Activo")
                {
                    // Limpiar los TextBox después de verificar las credenciales
                    textBoxNombre.Clear();
                    textBoxDNI.Clear();

                    // Mostrar el formulario de alquiler
                    Form_alquiler form_Alquiler = new Form_alquiler();
                    this.Hide();
                    form_Alquiler.ShowDialog();
                }
                else if (usuario != null && usuario.Estado == "Debaja")
                {
                    // Mostrar un mensaje si el usuario está dado de baja
                    MessageBox.Show("Ha sido dado de baja de la aplicación. Comuníquese con el soporte o llame al número 464-4100 para obtener más ayuda.", "Usuario Dado de Baja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Usuario no encontrado
                    throw new ArgumentException("Usuario no encontrado.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Boton_Atras_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_inicio inicio = new Form_inicio();
            inicio.ShowDialog();
        }


        private void ActualizarUsuarios()
        {
            // Cargar usuarios
            List<Persona> usuarios = DataManager.CargarDatos();

            // Verificar y actualizar los campos nulos
            foreach (var usuario in usuarios)
            {
                
                if (usuario.Estado == null)
                {
                    usuario.Estado = "Activo"; 
                }

                if (usuario.Rol == null)
                {

                    usuario.Rol = "Usuario";

                }

                
            }

            
            DataManager.GuardarDatos(usuarios);
        }

    }
}
