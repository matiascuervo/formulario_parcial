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

namespace formulario_parcial
{
    public partial class Form_ventas : Form
    {
        public Dictionary<string, decimal> preciosVolquetes = new Dictionary<string, decimal>(); // Diccionario para almacenar los precios
        public Dictionary<string, decimal> recargosLocalidades = new Dictionary<string, decimal>();
        static decimal numeroPedido = 0;
       
        public Form_ventas()
        {
            
            InitializeComponent();

            
            InitializePreciosDiccionario();

            
            InitializeComboBoxItems();

            InitializeRecargosDiccionario();
            InitilizecomboBox_Localidad();
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

        private void InitializePreciosDiccionario()
        {
            preciosVolquetes.Add("Chico", 10000); // Precio para el volquete chico
            preciosVolquetes.Add("Grande", 20000); // Precio para el volquete grande
            
        }

        private void InitializeComboBoxItems()
        {
            comboBox_ventas.Items.Add("Chico");
            comboBox_ventas.Items.Add("Grande");
            
        }




        private void comboBox_ventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var seleccion = comboBox_ventas.SelectedItem.ToString();

            if (preciosVolquetes.ContainsKey(seleccion))
            {
                decimal precio = preciosVolquetes[seleccion];
                
                MessageBox.Show($"Has seleccionado un volquete {seleccion}. Precio: {precio:C}. Realizar pedido...");
            }
            else
            {
                MessageBox.Show("Selección no válida.");
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
                        if (preciosVolquetes.ContainsKey(seleccion))
                        {
                            decimal precio = preciosVolquetes[seleccion];
                            decimal costoTotal = cantidadVolquetes * precio;
                            //MessageBox.Show($"Costo total: {costoTotal:C}");
                        }
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
            if (comboBox_Localidad.SelectedItem != null)
            {
                var localidad = comboBox_Localidad.SelectedItem.ToString();
                if (recargosLocalidades.ContainsKey(localidad))
                {
                    decimal recargo = recargosLocalidades[localidad];
                    // Aquí puedes usar 'recargo' para aplicar el recargo al precio del volquete seleccionado
                    if (comboBox_ventas.SelectedItem != null)
                    {
                        var seleccion = comboBox_ventas.SelectedItem.ToString();
                        if (localidad == "Temperley")
                        {
                            MessageBox.Show($"Has seleccionado un volquete {seleccion} en {localidad}.En Temperley Su Pedido No Tiene Recarga");
                        }
                        else if (preciosVolquetes.ContainsKey(seleccion))
                        {
                            decimal precio = preciosVolquetes[seleccion];
                            decimal precioConRecargo = precio + (precio * recargo);
                            MessageBox.Show($"Has seleccionado un volquete {seleccion} en {localidad}.EL Precio Nomal es de {precio},EL Precio con recargo: {precioConRecargo:C}");

                        }
                    }
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

            if (preciosVolquetes.ContainsKey(seleccion))
            {
                decimal precio = preciosVolquetes[seleccion];

                if (comboBox_Localidad.SelectedItem != null)
                {
                    var localidad = comboBox_Localidad.SelectedItem.ToString();
                    if (recargosLocalidades.ContainsKey(localidad))
                    {
                        decimal recargo = recargosLocalidades[localidad];
                        // Aplicar el recargo al precio del volquete
                        decimal precioConRecargo = precio + (precio * recargo);
                        decimal costoTotal = cantidadVolquetes * precioConRecargo;
                        string nombre = textBox_Nombre_Final.Text.ToLower();
                        string Direccion = TextBox_Direccion.Text.ToLower();


                        numeroPedido++;
                        string numeroPedidoSt = $"{numeroPedido}";
                        

                        // Incrementar el contador de número de pedido
                        // Especifica la ruta y el nombre del archivo XML
                        string rutaDirectorio = @"C:\Users\Matias\source\repos\formulario_parcial\Xml_Usuarios"; 
                        string xmlFileName = Path.Combine(rutaDirectorio, $"pedidos.xml");
                        string nombreUsuarioLogeado = UserManager.Instancia.UsuarioLogueado?.Nombre;
                        // Resto del código para guardar el pedido en XML
                        var pedidoElement = new XElement("Pedido",
                            new XElement("Usuario",nombreUsuarioLogeado),
                            new XElement("Nombre", nombre),
                            new XElement("TipoVolquete", seleccion),
                            new XElement("Cantidad", cantidadVolquetes),
                            new XElement("MontoAPagar", costoTotal),
                            new XElement("NumeroDePedido", numeroPedidoSt),
                            new XElement("Domicilio", Direccion)
                        );

                        // Cargar el documento XML existente o crear uno nuevo


                        XDocument doc;
                        if (System.IO.File.Exists(xmlFileName))
                        {
                            doc = XDocument.Load(xmlFileName);
                        }
                        else
                        {
                            doc = new XDocument(new XElement("Pedidos"));
                        }

                        // Agregar el nuevo pedido al documento XML
                        doc.Root.Add(pedidoElement);

                        // Guardar el documento XML en el archivo
                        doc.Save(xmlFileName);

                        MessageBox.Show("Pedido guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}




