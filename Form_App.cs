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
    public partial class Form_alquiler : Form
    {
        private UserManager userManager = UserManager.Instancia;

        private IDataManager dataManager = new DataManager();
        public BienvenidaAdministradorEvent bienvenidaAdministradorEvent = new BienvenidaAdministradorEvent();
        public Form_alquiler()
        {
            InitializeComponent();
            VerificarRolDeUsuario();
            bienvenidaAdministradorEvent.AdministradorBienvenido += MostrarMensajeBienvenida;

        }




        private void MostrarMensajeBienvenida(object sender, BienvenidaAdministradorEvent.BienvenidaAdministradorEventArgs e)
        {
            MessageBox.Show($"¡Bienvenido, {e.NombreAdministrador}! Todos los usuarios han sido actualizados.", "Usuarios Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void VerificarRolDeUsuario()
        {
            // Verifica si el usuario tiene el rol de administrador
            if (userManager.UsuarioLogueado.Rol == "administrador")
            {
                // Si el usuario es administrador, muestra el botón de usuarios
                button_usuarios.Visible = true;
                Boton_Pedidos_Usuarios.Visible = true;
                bienvenidaAdministradorEvent.OnAdministradorBienvenido(userManager.UsuarioLogueado.Nombre);

            }
            else
            {
                // Si el usuario no es administrador, oculta el botón de usuarios
                button_usuarios.Visible = false;
                Boton_Pedidos_Usuarios.Visible = false;
            }
        }


        private void Boton_Volver_App_Click(object sender, EventArgs e)
        {
            Form_inicio inicio = new Form_inicio();
            this.Close();
            inicio.Show();
        }

        private void button_Ventas_Click(object sender, EventArgs e)
        {
            Form_ventas Formulario_Ventas = new Form_ventas();
            this.Hide();
            Formulario_Ventas.ShowDialog();
        }

        private void button_Pedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pedidos_Form pedidosForm = new Pedidos_Form();
            pedidosForm.ShowDialog();
        }

        private void button_usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
        }


        private void ActualizarUsuarios()
        {
            
            List<Persona> usuarios = dataManager.CargarDatos();

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

            dataManager.GuardarDatos(usuarios);

        }

        private void Boton_Pedidos_Usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            PedidosDeLosUsuarios pedios = new PedidosDeLosUsuarios();
            pedios.ShowDialog();
        }

        private void Form_alquiler_Load(object sender, EventArgs e)
        {
            
        }
    }
}

