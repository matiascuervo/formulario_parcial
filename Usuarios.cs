using BiblotecaDatamanager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace formulario_parcial
{
    public partial class Usuarios : Form
    {
        private Pedidos_Form pedidosForm;
        List<Persona> usuarios = DataManager.CargarDatos();

        public Usuarios()
        {
            InitializeComponent();
            pedidosForm = new Pedidos_Form();
            AgregarUsuariosAlDataGridView(usuarios);
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            List<Persona> usuarios = DataManager.CargarDatos();

            // Enlazar la lista
            dataGridView_Usuarios.DataSource = usuarios;
        }

        private void Boton_Volver_Usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_alquiler alquiler = new Form_alquiler();
            alquiler.ShowDialog();
        }

        private void AgregarUsuariosAlDataGridView(List<Persona> usuarios)
        {
            foreach (var usuario in usuarios)
            {
                int rowIndex = dataGridView_Usuarios.Rows.Add();
                DataGridViewRow row = dataGridView_Usuarios.Rows[rowIndex];

                row.Cells["columna_Usuario"].Value = usuario.Nombre;
                row.Cells["columna_Contraseña"].Value = usuario.Contraseña;
                row.Cells["columna_Rol"].Value = usuario.Rol;
                row.Cells["columna_Estado"].Value = usuario.Estado;
            }

        }

        // Método común para realizar operaciones
        private void RealizarOperacion(string nombreUsuario, string nuevoEstado, string mensajeExito)
        {
            // Cargar los usuarios
            List<Persona> usuarios = DataManager.CargarDatos();

            // Buscar al usuario en la lista
            Persona usuario = usuarios.FirstOrDefault(u => u.Nombre == nombreUsuario);

            if (usuario != null)
            {
                // Cambiar el estado del usuario
                usuario.Estado = nuevoEstado;

                DataManager.GuardarDatos(usuarios);

                // Actualizar el DataGridView
                dataGridView_Usuarios.Rows.Clear();
                AgregarUsuariosAlDataGridView(usuarios);

                MessageBox.Show($"Usuario {nombreUsuario} {mensajeExito}", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"El usuario {nombreUsuario} no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sobrecarga para dar de baja
        private void RealizarOperacion(string nombreUsuario)
        {
            RealizarOperacion(nombreUsuario, "Debaja", "dado de baja correctamente.");
        }

        // Sobrecarga para reactivar
        private void RealizarOperacion(string nombreUsuario, bool reactivar)
        {
            RealizarOperacion(nombreUsuario, reactivar ? "Activo" : "Inactivo", $"{(reactivar ? "reactivado" : "desactivado")} correctamente.");
        }

        private void Bonton_Baja_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBox_Baja.Text;
            RealizarOperacion(nombreUsuario);
        }

        private void Boton_Reactivar_Usuario_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBox_Baja.Text;
            RealizarOperacion(nombreUsuario, true);
        }
    }
}
