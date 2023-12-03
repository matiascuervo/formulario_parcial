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
        private IDataManager dataManager = new DataManager();
        private List<Persona> usuarios;

        public Usuarios()
        {
            InitializeComponent();
            pedidosForm = new Pedidos_Form();
            usuarios = dataManager.CargarDatos();
            AgregarUsuariosAlDataGridView(usuarios);
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
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
                // Filtra los usuarios con rol "administrador"
                if (usuario.Rol != "administrador")
                {
                    int rowIndex = dataGridView_Usuarios.Rows.Add();
                    DataGridViewRow row = dataGridView_Usuarios.Rows[rowIndex];

                    row.Cells["columna_Usuario"].Value = usuario.Nombre;
                    row.Cells["columna_Contraseña"].Value = usuario.Contraseña;
                    row.Cells["columna_Rol"].Value = usuario.Rol;
                    row.Cells["columna_Estado"].Value = usuario.Estado;
                }
            }
        }

        private void RealizarOperacion(string nombreUsuario, string nuevoEstado, string mensajeExito)
        {
            Persona usuario = usuarios.FirstOrDefault(u => u.Nombre == nombreUsuario);

            if (usuario != null)
            {
                // Verificar si se desea realmente realizar la operación
                DialogResult confirmacion = MessageBox.Show($"¿Seguro que desea asignar {nuevoEstado.ToLower()} al usuario {nombreUsuario}?", "Confirmar Operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // Cambiar el estado del usuario
                    usuario.Estado = nuevoEstado;

                    dataManager.GuardarDatos(usuarios);

                    // Actualizar el DataGridView
                    dataGridView_Usuarios.Rows.Clear();
                    AgregarUsuariosAlDataGridView(usuarios);

                    MessageBox.Show($"Usuario {nombreUsuario} {mensajeExito}", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"El usuario {nombreUsuario} no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sobrecarga para dar de baja
        private void RealizarOperacion(string nombreUsuario)
        {
            RealizarOperacion(nombreUsuario, "Debaja", "Dado de baja correctamente.");
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

