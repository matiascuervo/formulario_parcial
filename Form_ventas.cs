using Microsoft.VisualBasic.Logging;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BiblotecaDatamanager;
using Microsoft.VisualBasic.ApplicationServices;
using BibliotecaDatamanager;
using System.Reflection.Metadata.Ecma335;

namespace formulario_parcial
{
    public partial class Form_ventas : Form
    {
        private Volquete volqueteSeleccionado;

        public Dictionary<string, decimal> recargosLocalidades = new Dictionary<string, decimal>();// Diccionario para localidades
        private List<Pedido> listaPedidos = new List<Pedido>(); //lista de pedidos
        static Random random = new Random();

        public Form_ventas()
        {

            InitializeComponent();

            InitializeComboBoxItems();

            InitializeRecargosDiccionario();
            InitilizecomboBox_Localidad();
            InitializecomboBox_BolsonesItems();
        }

        private void InitializeRecargosDiccionario()
        {
            recargosLocalidades.Add("Temperley", 0m);  // Sin recargo
            recargosLocalidades.Add("Lomas", 0.1m);    // 10% de recargo
            recargosLocalidades.Add("Adrogue", 0.1m);  // 10% de recargo
            recargosLocalidades.Add("Banfield", 0.2m); // 20% de recargo
            recargosLocalidades.Add("Burzaco", 0.2m);  // 20% de recargo

        }

        private void InitilizecomboBox_Localidad()
        {
            comboBox_Localidad.Items.Add("Temperley");
            comboBox_Localidad.Items.Add("Lomas");
            comboBox_Localidad.Items.Add("Adrogue");
            comboBox_Localidad.Items.Add("Burzaco");
            comboBox_Localidad.Items.Add("Banfield");

        }


        private void InitializeComboBoxItems()
        {
            comboBox_ventas.Items.Add("chicos");
            comboBox_ventas.Items.Add("grandes");

        }

        private void InitializecomboBox_BolsonesItems()
        {

            comboBox_Bolsones.Items.Add("2m3");
            comboBox_Bolsones.Items.Add("1m3");

        }

        private void comboBox_BolsonesSelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccion = comboBox_Bolsones.SelectedItem?.ToString(); // Usar ?. para evitar null reference

            Producto producto = new Producto();

            try
            {
                if (seleccion == "2m3")
                {
                    string tamañoBolsonGrande = "2m3";
                    Bolson bolson_Grande = new Bolson(tamañoBolsonGrande);
                    producto.Tipo = bolson_Grande.Tipo;
                    
                }
                else if (seleccion == "1m3")
                {
                    string tamañoBolsonChico = "1m3";
                    Bolson bolson_chico = new Bolson(tamañoBolsonChico);
                    producto.Tipo = bolson_chico.Tipo;
                }


                    MessageBox.Show($"Tipo de Producto: {producto.Tipo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBox_ventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccion = comboBox_ventas.SelectedItem.ToString();

            // Crear un objeto de tipo Producto
            Producto producto = new Producto();

            try
            {

                if (seleccion == "chicos")
                {
                    MessageBox.Show("Seleccion: chicos");
                    string tamañoVolqueteChico = "chico";
                    Volquete volquete_chico = new Volquete(tamañoVolqueteChico);
                    producto.Tipo = volquete_chico.Tipo;
                    producto.MontoAPagar = volquete_chico.MontoAPagar;
                    volqueteSeleccionado = volquete_chico;
                }
                else if (seleccion == "grandes")
                {
                    MessageBox.Show("Seleccion: Grandes");
                    string tamañoVolqueteGrande = "grande";
                    Volquete volquete_grande = new Volquete(tamañoVolqueteGrande);
                    producto.Tipo = volquete_grande.Tipo;
                    producto.MontoAPagar = volquete_grande.MontoAPagar;
                    volqueteSeleccionado = volquete_grande;
                }


                MessageBox.Show($"Tipo de Producto: {producto.Tipo}, Monto a Pagar: {producto.MontoAPagar}");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void textBox_Cantidad_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                string cantidadTexto = textBox_Cantidad.Text;
                if (int.TryParse(cantidadTexto, out int cantidadVolquetes))
                {
                    if (comboBox_ventas.SelectedItem != null)
                    {
                        var seleccion = comboBox_ventas.SelectedItem.ToString();
                        // No necesitas crear una nueva instancia de Volquete aquí, ya tienes volqueteSeleccionado
                        decimal precio = volqueteSeleccionado.MontoAPagar;

                        if (recargosLocalidades.ContainsKey(comboBox_Localidad.SelectedItem.ToString()))
                        {
                            decimal recargo = recargosLocalidades[comboBox_Localidad.SelectedItem.ToString()];
                            precio += precio * recargo;
                        }

                        decimal costoTotal = cantidadVolquetes * precio;
                        // MessageBox.Show($"Costo total: {costoTotal:C}");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Boton_Volver_Ventas_Click(object sender, EventArgs e)
        {
            Form_alquiler alquiler = new Form_alquiler();
            this.Hide();
            alquiler.ShowDialog();

        }

        private void comboBox_Localidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (volqueteSeleccionado != null && comboBox_ventas.SelectedItem != null)
            {
                var localidad = comboBox_Localidad.SelectedItem.ToString();  // Mueve esta línea aquí

                if (localidad == "Temperley")
                {
                    MessageBox.Show($"Has seleccionado un volquete {volqueteSeleccionado} en {localidad}. En Temperley, su pedido no tiene recarga");
                }
                else if (recargosLocalidades.ContainsKey(localidad))
                {
                    decimal recargo = recargosLocalidades[localidad];

                    decimal precio = volqueteSeleccionado.MontoAPagar;
                    decimal precioConRecargo = precio + (precio * recargo);
                    MessageBox.Show($"Has seleccionado un volquete {comboBox_ventas.SelectedItem} en {localidad}. El Precio Normal es de {precio:C}, El Precio con recargo: {precioConRecargo:C}");
                }
            }
        }

        private void Button_Pedir_Click(object sender, EventArgs e)
        {
            if (comboBox_ventas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de volquete antes de hacer el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBox_Cantidad.Text, out int cantidadVolquetes))
            {
                MessageBox.Show("Ingrese una cantidad válida antes de hacer el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var seleccion = comboBox_ventas.SelectedItem.ToString();

            if (comboBox_Localidad.SelectedItem != null)
            {
                var localidad = comboBox_Localidad.SelectedItem.ToString();
                if (recargosLocalidades.ContainsKey(localidad))
                {
                    // Aplica el recargo al precio del volquete
                    decimal recargo = recargosLocalidades[localidad];
                    decimal precioConRecargo = volqueteSeleccionado.MontoAPagar + (volqueteSeleccionado.MontoAPagar * recargo);
                    decimal costoTotal = cantidadVolquetes * precioConRecargo;
                    string nombre = textBox_Nombre_Final.Text.ToLower();
                    string Direccion = TextBox_Direccion.Text.ToLower();

                    int numeroPedidoAleatorio = random.Next(100000, 999999);

                    string nombreUsuarioLogeado = UserManager.Instancia.UsuarioLogueado?.Nombre;

                    DateTime FechaEntrega = dateTime_Venta.Value;

                    DateTime FechaRetiro = FechaEntrega.AddDays(7);

                    // Crear el objeto Pedido
                    Pedido nuevoPedido = new Pedido
                    {
                        Usuario = nombreUsuarioLogeado,
                        Nombre = nombre,
                        Tipo = volqueteSeleccionado,
                        Cantidad = cantidadVolquetes,
                        MontoAPagar = costoTotal,
                        NumeroDePedido = numeroPedidoAleatorio.ToString(),
                        Domicilio = Direccion,
                        Estado = Pedido.EstadoPedido.Activo,
                        FechaEntrega = FechaEntrega,
                        DuracionEntregaDias = 7,
                        FechaRetiro = FechaRetiro
                    };

                    // Agregar el nuevo pedido a la lista
                    listaPedidos.Add(nuevoPedido);

                    var enviroment = System.Environment.CurrentDirectory;
                    string rutaRelativa = Directory.GetParent(enviroment).Parent.Parent.FullName;
                    string rutaCompleta = Path.Combine(rutaRelativa, "Xml_Usuarios", "pedidos.xml");

                    var pedidosXml = new XElement("Pedidos",
                       listaPedidos.Select(pedido =>
                       new XElement("Pedido",
                       new XElement("Usuario", pedido.Usuario),
                       new XElement("Nombre", pedido.Nombre),
                       new XElement("TipoVolquete", pedido.Tipo.Tipo),
                       new XElement("Cantidad", pedido.Cantidad),
                       new XElement("MontoAPagar", pedido.MontoAPagar),
                       new XElement("NumeroDePedido", pedido.NumeroDePedido),
                       new XElement("Domicilio", pedido.Domicilio),
                       new XElement("Estado", pedido.Estado),
                       new XElement("FechaEntrega", pedido.FechaEntrega.ToString("dd/MM/yyyy")),
                       new XElement("DuracionEntregaDias", pedido.DuracionEntregaDias, "Dias"),
                       new XElement("FechaRetiro", pedido.FechaRetiro.ToString("dd/MM/yyyy"))

                   )
               )
           );

                    XDocument doc;
                    if (System.IO.File.Exists(rutaCompleta))
                    {
                        doc = XDocument.Load(rutaCompleta);
                    }
                    else
                    {
                        doc = new XDocument(new XElement("Pedidos"));
                    }


                    doc.Root.Add(pedidosXml);

                    // Guardar el documento XML en el archivo
                    doc.Save(rutaCompleta);

                    MessageBox.Show("Pedido guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"El Numero De Su Pedido es {numeroPedidoAleatorio}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Has seleccionado {cantidadVolquetes} volquetes {volqueteSeleccionado.Tipo} en {localidad}.El Costo total Es: {costoTotal:C}");
                }
            }
        }
    }

}


