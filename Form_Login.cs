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
        }

        private void ConfigurarAutocompletado()
        {
            // Crear una colección de cadenas para el autocompletado
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

        private void Boton_login_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el nombre y DNI de los TextBox
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

                // Limpiar los TextBox después de verificar las credenciales
                textBoxNombre.Clear();
                textBoxDNI.Clear();

                
                Form_alquiler form_Alquiler = new Form_alquiler();

                
                form_Alquiler.DialogResult = DialogResult.OK;
                this.Hide();

                
                form_Alquiler.ShowDialog();
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
