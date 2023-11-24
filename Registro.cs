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
    public partial class Registro : Form
    {
        // Utiliza la instancia única de UserManager proporcionada por el Singleton
        private UserManager userManager = UserManager.Instancia;

        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            
        }

        private void Boton_registro_Click(object sender, EventArgs e)
        {
            try
            {
                string Usuario = textBox_Nombre_Registro.Text;
                string contraseña = textBox_Contraseña_Registro.Text;

                if (!string.IsNullOrWhiteSpace(Usuario) && !string.IsNullOrWhiteSpace(contraseña))
                {
                    // Registra al nuevo usuario utilizando el UserManager (Singleton)
                    userManager.RegistrarCredenciales(Usuario, contraseña,"Usuario","Activo");

                    // Limpia los campos de entrada
                    textBox_Nombre_Registro.Clear();
                    textBox_Contraseña_Registro.Clear();

                    MessageBox.Show("Usuario registrado exitosamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ambos campos son obligatorios para el registro.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Boton_Volver_Registro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Contraseña_Registro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
