using BiblotecaDatamanager;
using System.Globalization;
using System.Xml.Linq;
using static BiblotecaDatamanager.Pedido;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System;
using PdfSharp.Fonts;

namespace formulario_parcial
{
    public partial class Pedidos_Form : Form
    {
        private ILogger logger;

        public Pedidos_Form()
        {
            InitializeComponent();
            MostrarPedidosDelUsuario(UserManager.Instancia.UsuarioLogueado?.Nombre);
            dataGridView_Pedidos.CellFormatting += dataGridView_Pedidos_CellFormatting;
            dataGridView_Pedidos.CellContentClick += dataGridView_Pedidos_CellContentClick;
            dataGridView_Pedidos.AllowUserToAddRows = false;



            string enviroment = AppDomain.CurrentDomain.BaseDirectory;
            string rutaRelativa = Path.Combine(enviroment, "..", "..", "..", "logger_Excepciones");
            string logFileName = "logger_Errores.txt";
            logger = new Logger(rutaRelativa, logFileName);


        }


        public void MostrarPedidosDelUsuario(string nombreUsuario)
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

            //PedidosDeLosUsuarios pedidosDeLosUsuariosForm = new PedidosDeLosUsuarios();
            // pedidosDeLosUsuariosForm.ActualizarDataGridView(listaDePedidos);
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
            row.Cells["columna_bolsones"].Value = pedido.Element("Bolson")?.Element("TipoBolson")?.Value;
            row.Cells["columna_cantidadbolsones"].Value = pedido.Element("Bolson")?.Element("CantidadBolsones")?.Value;
            row.Cells["Columna_Preciobolsones"].Value = pedido.Element("Bolson")?.Element("MontoAPagarBolson")?.Value;

        }

        private void Boton_Volver_Pedidos_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_alquiler alquiler = new Form_alquiler();
            alquiler.ShowDialog();
        }






        private void dataGridView_Pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el usuario hizo clic en la columna de Estado
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView_Pedidos.Columns[e.ColumnIndex].Name == "Columna_Estado")
            {
                DataGridViewRow selectedRow = dataGridView_Pedidos.Rows[e.RowIndex];

                // Obtener el número de pedido y el estado actual
                string numeroPedido = selectedRow.Cells["Columna_Numero_De_Pedido"].Value.ToString();
                string estadoActual = selectedRow.Cells["columna_Estado"].Value.ToString();

                // Mostrar un cuadro de diálogo de confirmación
                //DialogResult result = MessageBox.Show($"¿Está seguro de que desea cancelar el pedido {numeroPedido}?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                CambiarEstadoPedido(numeroPedido, EstadoPedido.Cancelado);

                // Actualizar el DataGridView después de la cancelación
                MostrarPedidosDelUsuario(UserManager.Instancia.UsuarioLogueado?.Nombre);

            }
        }







        private void dataGridView_Pedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Reemplazar valores nulos o vacíos con un texto específico
            if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                e.Value = "Sin Especificar";
                e.FormattingApplied = true;
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
                                return;
                            }
                        }

                        // Confirmación antes de cancelar el pedido
                        DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cancelar este pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Cambiar el estado del pedido a Cancelado
                            string nuevoEstadoStr = nuevoEstado.ToString();
                            pedidoEncontrado.Element("Estado").Value = nuevoEstadoStr;
                            doc.Save(rutaCompleta);
                            MessageBox.Show("Pedido cancelado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (result == DialogResult.No)
                        {
                            MessageBox.Show("Pedido No Cancelado.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

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

        private void toolStripButton_Cancelados_Click_1(object sender, EventArgs e)
        {
            MostrarPedidosCancelados(UserManager.Instancia.UsuarioLogueado?.Nombre);
        }

        private void MostrarPedidosCancelados(string nombreUsuario)
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

                    var pedidosCancelados = doc.Descendants("Pedido")
                        .Where(p => p.Element("Usuario")?.Value == nombreUsuario && p.Element("Estado")?.Value == EstadoPedido.Cancelado.ToString());

                    foreach (var pedido in pedidosCancelados)
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

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            // Verifica si se ha ingresado una fecha válida
            if (DateTime.TryParse(textBox_Fecha.Text, out DateTime fechaBusqueda))
            {
                MostrarPedidosPorFecha(UserManager.Instancia.UsuarioLogueado?.Nombre, fechaBusqueda);
            }
            else
            {
                MessageBox.Show("Ingrese una fecha válida en el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MostrarPedidosPorFecha(string nombreUsuario, DateTime fechaBusqueda)
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

                    var pedidosPorFecha = doc.Descendants("Pedido")
                        .Where(p => p.Element("Usuario")?.Value == nombreUsuario &&
                                    DateTime.TryParseExact(p.Element("FechaEntrega")?.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaPedido) &&
                                    fechaPedido.Date == fechaBusqueda.Date);

                    if (pedidosPorFecha.Any())
                    {
                        foreach (var pedido in pedidosPorFecha)
                        {
                            AgregarFilaPedidoAlDataGridView(pedido);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay pedidos para la fecha ingresada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato de fecha incorrecto en el archivo XML.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void MostrarPedidosActivos(string nombreUsuario)
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

                    var pedidosActivos = doc.Descendants("Pedido")
                        .Where(p => p.Element("Usuario")?.Value == nombreUsuario && p.Element("Estado")?.Value == EstadoPedido.Activo.ToString());

                    if (pedidosActivos.Any())
                    {
                        foreach (var pedido in pedidosActivos)
                        {
                            AgregarFilaPedidoAlDataGridView(pedido);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay pedidos activos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void toolStripButton_VerPedidos_Click(object sender, EventArgs e)
        {
            MostrarPedidosActivos(UserManager.Instancia.UsuarioLogueado?.Nombre);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MostrarPedidosDelUsuario(UserManager.Instancia.UsuarioLogueado?.Nombre);
        }


        private void MostrarHiloPrincipal()
        {
            // Este método se ejecutará en el hilo principal
            MessageBox.Show($"Hilo principal: {Thread.CurrentThread.ManagedThreadId}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GenerarPdf(int numeroPedido)
        {
            MessageBox.Show($"Hilo actual antes de GenerarPdf: {Thread.CurrentThread.ManagedThreadId}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                var pedido = BuscarPedidoPorNumero(numeroPedido);
                if (pedido != null)
                {
                    // Crear  PDF
                    // Agregar una página al documento
                    // Obtener el objeto XGraphics para dibujar en la página
                    using (PdfDocument document = new PdfDocument())
                    {
                        PdfPage page = document.AddPage();

                        using (XGraphics gfx = XGraphics.FromPdfPage(page))
                        {
                            XFont font = ObtenerFuenteArial();

                            double yPosition = 40;



                            gfx.DrawString("Volquetes Poly", font, XBrushes.Black, new XRect(10, yPosition, page.Width, page.Height), XStringFormats.TopLeft);
                            yPosition += 30;


                            gfx.DrawString($"Comprobante de Compra - Pedido #{numeroPedido}", font, XBrushes.Black, new XRect(10, yPosition, page.Width, page.Height), XStringFormats.TopLeft);
                            yPosition += 20;



                            AgregarLineaDetalle(gfx, font, "Recibe", pedido.Element("Nombre")?.Value, ref yPosition);
                            AgregarLineaDetalle(gfx, font, "Tipo De Volquete", pedido.Element("TipoVolquete")?.Value, ref yPosition);
                            AgregarLineaDetalle(gfx, font, "Cantidad", pedido.Element("Cantidad")?.Value, ref yPosition);
                            AgregarLineaDetalle(gfx, font, "Monto a Pagar", pedido.Element("MontoAPagar")?.Value, ref yPosition);
                            AgregarLineaDetalle(gfx, font, "Número de Pedido", pedido.Element("NumeroDePedido")?.Value, ref yPosition);
                            AgregarLineaDetalle(gfx, font, "Domicilio", pedido.Element("Domicilio")?.Value, ref yPosition);
                            AgregarLineaDetalle(gfx, font, "Estado", pedido.Element("Estado")?.Value, ref yPosition);
                            AgregarLineaDetalle(gfx, font, "Fecha de Entrega", pedido.Element("FechaEntrega")?.Value, ref yPosition);
                            //  AgregarLineaDetalle(gfx, font, "Duración de Entrega", $"{pedido.Element("DuracionEntregaDias")?.Value} Días", ref yPosition);
                            AgregarLineaDetalle(gfx, font, "Fecha de Retiro", pedido.Element("FechaRetiro")?.Value, ref yPosition);

                            var bolson = pedido.Element("Bolson");
                            if (bolson != null)
                            {
                                // Agregar detalles del bolson si existe
                                AgregarLineaDetalle(gfx, font, "Tipo de Bolson", bolson.Element("TipoBolson")?.Value, ref yPosition);
                                AgregarLineaDetalle(gfx, font, "Cantidad de Bolsones", bolson.Element("CantidadBolsones")?.Value, ref yPosition);
                                //AgregarLineaDetalle(gfx, font, "Monto a Pagar por Bolsones", bolson.Element("MontoAPagarBolson")?.Value, ref yPosition);
                            }


                            MessageBox.Show($"PDF generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        string rutaRelativa = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                        string rutaPdf = Path.Combine(rutaRelativa, "PDF", $"ComprobantePedido_{numeroPedido}.pdf");
                        document.Save(rutaPdf);
                    }
                }
                else
                {
                    var methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    var className = this.GetType().Name;
                    logger.LogError(null, $"Error Numero Ingresado Incorrecto  #{numeroPedido}.", methodName, className);



                    MessageBox.Show($"Pedido #{numeroPedido} no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                var methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                var className = this.GetType().Name;


                logger.LogError(ex, $"Error al generar PDF para el pedido #{numeroPedido}.", methodName, className);


                MessageBox.Show($"Se produjo un error al generar el PDF para el pedido #{numeroPedido}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Mostrar el ID del hilo actual después de que la generación del PDF haya terminado
                MessageBox.Show($"Hilo actual después de GenerarPdf: {Thread.CurrentThread.ManagedThreadId}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void AgregarLineaDetalle(XGraphics gfx, XFont font, string etiqueta, string valor, ref double yPosition)
        {

            gfx.DrawString($"{etiqueta}: {valor}", font, XBrushes.Black, new XRect(10, yPosition, 500, 20), XStringFormats.TopLeft);
            yPosition += 20;
        }






        private XElement BuscarPedidoPorNumero(int numeroPedido)
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
                        .FirstOrDefault(p => p.Element("NumeroDePedido")?.Value == numeroPedido.ToString());

                    return pedidoEncontrado;
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

            return null;
        }




        private XFont ObtenerFuenteArial()
        {
            GlobalFontSettings.FontResolver = new FontResolver();

            return new XFont("Arial", 12);
        }


        private async void button_Generar_Pdf_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_Pdf.Text, out int numeroPedido))
            {

                Invoke(new Action(MostrarHiloPrincipal));


                await Task.Run(() => GenerarPdf(numeroPedido));
            }
            else
            {
                MessageBox.Show("Ingrese un número de pedido válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void MostrarPedidosPorFechaOrdenados(string nombreUsuario)
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

                    var pedidos = doc.Descendants("Pedido")
                        .Where(p => p.Element("Usuario")?.Value == nombreUsuario)
                        .ToList();

                    if (pedidos.Any())
                    {
                        // Ordenar los pedidos por fecha de entrega utilizando el delegado
                        OrdenamientoPedidos.OrdenarPorFecha(pedidos, OrdenamientoPedidos.ComparadoresPedidoPorFecha.PorFechaEntrega);

                        foreach (var pedido in pedidos)
                        {
                            AgregarFilaPedidoAlDataGridView(pedido);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay pedidos para el usuario ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato de fecha incorrecto en el archivo XML.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button_ordenados_Click(object sender, EventArgs e)
        {
            string nombreUsuario = UserManager.Instancia.UsuarioLogueado?.Nombre;
           
                // Incluye la hora

            // Ajustar la fecha actual para que no incluya la hora
            

            MostrarPedidosPorFechaOrdenados(nombreUsuario);
        }
    }
}
