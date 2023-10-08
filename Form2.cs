using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_parcial
{
    public partial class FormularioUsuario : Form
    {
        public FormularioUsuario()
        {
            InitializeComponent();
        }
        
        internal List<Persona> persona = new List<Persona>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            string Nombre = textBoxNombre.Text;

        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            string DNI = textBoxDNI.Text;
        }

        private void Boton_login_Click(object sender, EventArgs e)
        {
            // Obtener el nombre y DNI de los TextBox
            string nombre = textBoxNombre.Text;
            string dni = textBoxDNI.Text;

            // Crear un objeto Persona y asignar los valores
            Persona nuevaPersona = new Persona
            {
                Nombre = nombre,
                DNI = dni
            };

            // Agregar la nuevaPersona a la lista persona
            persona.Add(nuevaPersona);

            // Limpiar los TextBox después de agregar los datos
            textBoxNombre.Clear();
            textBoxDNI.Clear();

            // Guardar los datos en un archivo JSON
            DataManager.GuardarDatos(persona);
            // Cargar los datos desde un archivo JSON
            List<Persona> personasCargadas = DataManager.CargarDatos();



            // Crear una instancia del formulario Form_alquiler
            Form_alquiler form_Alquiler = new Form_alquiler();

            // Establecer el resultado del diálogo en DialogResult.OK
            form_Alquiler.DialogResult = DialogResult.OK;

            // Mostrar el formulario Form_alquiler como un diálogo modal
            form_Alquiler.ShowDialog();
        }
    }
}
