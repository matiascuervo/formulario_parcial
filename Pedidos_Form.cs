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
            // Aquí puedes agregar lógica si es necesario
        }

        private void toolStripTextBox_Pedidos_Click(object sender, EventArgs e)
        {
            // Verificar que el campo de búsqueda no esté vacío antes de buscar
            if (!string.IsNullOrEmpty(toolStripTextBox_Pedidos.Text.Trim()))
            {
                BuscarPedidoPorNumero(toolStripTextBox_Pedidos.Text);
            }
        }

        private void toolStripButton_Pedidos_Click(object sender, EventArgs e)
        {
            // Verificar que el campo de búsqueda no esté vacío antes de buscar
            if (!string.IsNullOrEmpty(toolStripTextBox_Pedidos.Text.Trim()))
            {
                BuscarPedidoPorNumero(toolStripTextBox_Pedidos.Text);
            }
        }
        private void BuscarPedidoPorNumero(string numeroPedido)
        {
            string numeroPedidoSinEspacios = numeroPedido.Trim();

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
                        .FirstOrDefault(p => p.Element("NumeroDePedido")?.Value == numeroPedidoSinEspacios);

                    if (pedidoEncontrado != null)
                    {
                        // Verifica que el usuario actual es el mismo que realizó el pedido
                        string usuarioPedido = pedidoEncontrado.Element("Usuario")?.Value;

                        
                        string nombreUsuarioLogeado = UserManager.Instancia.UsuarioLogueado?.Nombre;

                        if (usuarioPedido == nombreUsuarioLogeado)
                        {
                            
                            MostrarDetallesPedido(pedidoEncontrado);
                        }
                        else
                        {
                            MessageBox.Show("No tienes permiso para ver este pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pedido no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        public void MostrarDetallesPedido(XElement pedido)
        {
            // Limpia las filas 
            dataGridView_Pedidos.Rows.Clear();


            // Asignar valores a las celdas en las columnas correspondientes
            dataGridView_Pedidos.Rows[0].Cells["columna_Usuario"].Value = pedido.Element("Usuario")?.Value;
            dataGridView_Pedidos.Rows[0].Cells["columna_Nombre"].Value = pedido.Element("Nombre")?.Value;
            dataGridView_Pedidos.Rows[0].Cells["columna_Tipo"].Value = pedido.Element("TipoVolquete")?.Value;
            dataGridView_Pedidos.Rows[0].Cells["columna_Cantidad"].Value = pedido.Element("Cantidad")?.Value;
            dataGridView_Pedidos.Rows[0].Cells["columna_MontoAPagar"].Value = pedido.Element("MontoAPagar")?.Value;
            dataGridView_Pedidos.Rows[0].Cells["Columna_Numero_De_Pedido"].Value = pedido.Element("NumeroDePedido")?.Value;
            dataGridView_Pedidos.Rows[0].Cells["columna_Direccion"].Value = pedido.Element("Domicilio")?.Value;
            dataGridView_Pedidos.Rows[0].Cells["columna_Estado"].Value = pedido.Element("Estado")?.Value;
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
                // Verifica si hay una celda seleccionada en el DataGridView
                // Obtenie la fila seleccionada
                // Obtenie el número de pedido de la celda seleccionada
                // Verifica si el valor de la celda no es null o cadena vacía
                if (dataGridView_Pedidos.SelectedCells.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView_Pedidos.Rows[dataGridView_Pedidos.SelectedCells[0].RowIndex];

                    string numeroPedido = selectedRow.Cells["Columna_Numero_De_Pedido"].Value?.ToString();

                    if (!string.IsNullOrEmpty(numeroPedido))
                    {
                        BuscarPedidoPorNumero(numeroPedido);
                        

                        CambiarEstadoPedido(numeroPedido, EstadoPedido.Cancelado);
                        
                    }
                    else
                    {
                        // Lanzar  excepción personalizada 
                        throw new PedidoNoEncontradoException();
                    }
                }
                else
                {
                    
                    throw new PedidoNoEncontradoException();
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

                        // Actualizar el estado del pedido en el archivo XML
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
