using BiblotecaDatamanager;
using System.Xml.Linq;
using static BiblotecaDatamanager.Pedido;

namespace formulario_parcial
{
    public partial class Pedidos_Form : Form
    {

        public Pedidos_Form()
        {
            InitializeComponent();

        }



        private void dataGridView_Pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripTextBox_Pedidos_Click(object sender, EventArgs e)
        {
            // Verificar que el campo de búsqueda no esté vacío antes de buscar
           
        }

        private void toolStripButton_Pedidos_Click(object sender, EventArgs e)
        {
            // Verificar que el campo de búsqueda no esté vacío antes de buscar

            MostrarPedidosDelUsuario(UserManager.Instancia.UsuarioLogueado?.Nombre);


        }
        private void MostrarPedidosDelUsuario(string nombreUsuario)
        {
            dataGridView_Pedidos.Rows.Clear();

            var enviroment = System.Environment.CurrentDirectory;
            string rutaRelativa = Directory.GetParent(enviroment).Parent.Parent.FullName;
            string rutaCompleta = Path.Combine(rutaRelativa, "Xml_Usuarios", "pedidos.xml");

            if (File.Exists(rutaCompleta))
            {
                try
                {
                    XDocument doc = XDocument.Load(rutaCompleta);

                    var pedidosDelUsuario = doc.Descendants("Pedido")
                        .Where(p => p.Element("Usuario")?.Value == nombreUsuario);

                    foreach (var pedido in pedidosDelUsuario)
                    {
                        AgregarFilaPedidoAlDataGridView(pedido);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo XML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El archivo XML de pedidos no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AgregarFilaPedidoAlDataGridView(XElement pedido)
        {
            int rowIndex = dataGridView_Pedidos.Rows.Add();
            DataGridViewRow row = dataGridView_Pedidos.Rows[rowIndex];

            row.Cells["columna_Usuario"].Value = pedido.Element("Usuario")?.Value;
            row.Cells["columna_Nombre"].Value = pedido.Element("Nombre")?.Value;
            row.Cells["columna_Tipo"].Value = pedido.Element("TipoVolquete")?.Value;
            row.Cells["columna_Cantidad"].Value = pedido.Element("Cantidad")?.Value;
            row.Cells["columna_MontoAPagar"].Value = pedido.Element("MontoAPagar")?.Value;
            row.Cells["Columna_Numero_De_Pedido"].Value = pedido.Element("NumeroDePedido")?.Value;
            row.Cells["columna_Direccion"].Value = pedido.Element("Domicilio")?.Value;
            row.Cells["columna_Estado"].Value = pedido.Element("Estado")?.Value;
            row.Cells["columna_FechaEntrega"].Value = pedido.Element("FechaEntrega")?.Value;
            row.Cells["columna_FechaRetiro"].Value = pedido.Element("FechaRetiro")?.Value;
        }

        private void Boton_Volver_Pedidos_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_alquiler alquiler = new Form_alquiler();
            alquiler.ShowDialog();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si hay un número de pedido ingresado
                if (!string.IsNullOrEmpty(textBox_Cancelar.Text.Trim()))
                {
                    string numeroPedido = textBox_Cancelar.Text.Trim();

                    // Busca el pedido por el número y lo cancela
                    CambiarEstadoPedido(numeroPedido, EstadoPedido.Cancelado);

                    // Vuelve a mostrar los pedidos del usuario después de la cancelación
                    MostrarPedidosDelUsuario(UserManager.Instancia.UsuarioLogueado?.Nombre);
                }
                else
                {
                    // Muestra un mensaje indicando que el número de pedido no es válido
                    MessageBox.Show("Ingrese Un Número De Pedido En La Caja De Texto De La Derecha Para Cancelarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (PedidoNoEncontradoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CambiarEstadoPedido(string numeroPedido, EstadoPedido nuevoEstado)
        {
            var enviroment = System.Environment.CurrentDirectory;
            string rutaRelativa = Directory.GetParent(enviroment).Parent.Parent.FullName;
            string rutaCompleta = Path.Combine(rutaRelativa, "Xml_Usuarios", "pedidos.xml");

            if (File.Exists(rutaCompleta))
            {
                try
                {
                    XDocument doc = XDocument.Load(rutaCompleta);

                    // Buscar el pedido por número en el archivo XML
                    var pedidoEncontrado = doc.Descendants("Pedido")
                        .FirstOrDefault(p => p.Element("NumeroDePedido")?.Value == numeroPedido);

                    if (pedidoEncontrado != null)
                    {
                        // Verificar el estado actual del pedido
                        string estadoActualStr = pedidoEncontrado.Element("Estado")?.Value;

                        if (Enum.TryParse(estadoActualStr, out EstadoPedido estadoActual))
                        {
                            // Verificar si el estado actual ya es Cancelado
                            if (estadoActual == EstadoPedido.Cancelado)
                            {
                                MessageBox.Show("El pedido ya ha sido cancelado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return; // No cambiamos el estado si ya está cancelado
                            }
                        }


                        string nuevoEstadoStr = nuevoEstado.ToString();

                        // Actualiza el estado del pedido en el archivo XML
                        pedidoEncontrado.Element("Estado").Value = nuevoEstadoStr;


                        doc.Save(rutaCompleta);
                    }
                    else
                    {
                        MessageBox.Show("Pedido no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer o escribir el archivo XML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El archivo XML de pedidos no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
