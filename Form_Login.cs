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
using BibliotecaDatamanager;

namespace formulario_parcial
{
    public partial class FormularioUsuario : Form
    {
        
        // La instancia única de UserManager Singleton
        private UserManager userManager = UserManager.Instancia;

        // Nueva instancia de DataManager
        public FormularioUsuario()
        {
            InitializeComponent();

            ConfigurarAutocompletado();
           
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

                Persona usuario = userManager.GetUsuarios().FirstOrDefault(u => u.Nombre == nombre);

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
                MessageBox.Show("Error: " + ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
