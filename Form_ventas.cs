﻿using Microsoft.VisualBasic.Logging;
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
using System.Runtime.CompilerServices;
using System.Data.SqlClient;



namespace formulario_parcial
{
    public partial class Form_ventas : Form
    {
        private Volquete volqueteSeleccionado;
        private Bolson bolsonSeleccionado;
        public Dictionary<string, decimal> recargosLocalidades = new Dictionary<string, decimal>();// Diccionario para localidades
        private List<Pedido> listaPedidos = new List<Pedido>(); //lista de pedidos
        static Random random = new Random();
        private bool bolsonSeleccionadoConVolquete = false;
        private int cantidadbolsones;
        private int NumeroDebolsones;
        private decimal costoTotalBolsones;

        private System.Windows.Forms.ToolTip toolTip1;

        public Form_ventas()
        {

            InitializeComponent();

            InitializeComboBoxItems();

            
            InitilizecomboBox_Localidad();
            InitializecomboBox_BolsonesItems();
            radioButton_Bolson.CheckedChanged += radioButton_Bolson_CheckedChanged;
            toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(radioButton_Bolson, "Los Bolsones Solo Se venden En Conjunto Con Algun Volquete.");


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




        private void radioButton_Bolson_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton_Bolson.Checked)
            {
                label_Bolsones.Visible = textBox_Cantidad_Bolsones.Visible = comboBox_Bolsones.Visible = label_Medida.Visible = label_BCantidad.Visible = pictureBox2.Visible = label_PrecioBolsaG.Visible = label_MedidaBolsaGrande.Visible = label_MedidaBolsaGChica.Visible = label_PrecioBolsaC.Visible = true;
            }
            else
            {
                label_Bolsones.Visible = textBox_Cantidad_Bolsones.Visible = comboBox_Bolsones.Visible = label_Medida.Visible = label_BCantidad.Visible = pictureBox2.Visible = label_PrecioBolsaG.Visible = label_MedidaBolsaGrande.Visible = label_MedidaBolsaGChica.Visible = label_PrecioBolsaC.Visible = false;
            }
        }



        private void comboBox_BolsonesSelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccion_Bolson = comboBox_Bolsones.SelectedItem?.ToString(); // Usar ?. para evitar null reference

            Producto producto = new Producto();

            try
            {
                if (seleccion_Bolson == "2m3")
                {
                    string tamañoBolsonGrande = "2m3";
                    Bolson bolson_Grande = new Bolson(tamañoBolsonGrande);
                    producto.Tipo = bolson_Grande.Tipo;
                    producto.MontoAPagar = bolson_Grande.MontoAPagar;
                    bolsonSeleccionado = bolson_Grande;
                    bolsonSeleccionadoConVolquete = true;

                }
                else if (seleccion_Bolson == "1m3")
                {
                    string tamañoBolsonChico = "1m3";
                    Bolson bolson_chico = new Bolson(tamañoBolsonChico);
                    producto.Tipo = bolson_chico.Tipo;
                    producto.MontoAPagar = bolson_chico.MontoAPagar;
                    bolsonSeleccionado = bolson_chico;
                    bolsonSeleccionadoConVolquete = true;


                }


                MessageBox.Show("Los Bolsones No Tienen Recarga De Acarreo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void textBox_Cantidad_BolsonestChanged(object sender, EventArgs e)
        {
            try
            {
                string cantidadTexto = textBox_Cantidad_Bolsones.Text;
                if (int.TryParse(cantidadTexto, out int cantidadbolsones))
                {
                    if (comboBox_ventas.SelectedItem != null && bolsonSeleccionado != null)
                    {
                        
                        decimal precio = bolsonSeleccionado.MontoAPagar;

                        costoTotalBolsones = cantidadbolsones * precio; 
                        NumeroDebolsones = cantidadbolsones;                                              

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






        private void comboBox_ventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccion = comboBox_ventas.SelectedItem.ToString();

            // Crear un objeto de tipo Producto
            Producto producto = new Producto();

            try
            {

                if (seleccion == "chicos")
                {

                    string tamañoVolqueteChico = "chico";
                    Volquete volquete_chico = new Volquete(tamañoVolqueteChico);
                    producto.Tipo = volquete_chico.Tipo;
                    producto.MontoAPagar = volquete_chico.MontoAPagar;
                    volqueteSeleccionado = volquete_chico;
                }
                else if (seleccion == "grandes")
                {

                    string tamañoVolqueteGrande = "grande";
                    Volquete volquete_grande = new Volquete(tamañoVolqueteGrande);
                    producto.Tipo = volquete_grande.Tipo;
                    producto.MontoAPagar = volquete_grande.MontoAPagar;
                    volqueteSeleccionado = volquete_grande;
                }


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
                        if (comboBox_Localidad.SelectedItem != null)
                        {
                            var seleccion = comboBox_ventas.SelectedItem.ToString();
                            
                            decimal precio = volqueteSeleccionado.MontoAPagar;

                            if (recargosLocalidades.ContainsKey(comboBox_Localidad.SelectedItem.ToString()))
                            {
                                decimal recargo = volqueteSeleccionado.CalcularRecargoPorLocalidad(comboBox_Localidad.SelectedItem.ToString());

                                precio += precio * recargo;
                            }

                            decimal costoTotal = cantidadVolquetes * precio;
                            // MessageBox.Show($"Costo total: {costoTotal:C}");
                        }
                        else
                        {
                            MessageBox.Show("Seleccione Primero Una localidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBox_Cantidad.Clear();
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
            if (volqueteSeleccionado != null && comboBox_ventas.SelectedItem != null)
            {
                var localidad = comboBox_Localidad.SelectedItem.ToString();

                if (localidad == "Temperley")
                {
                    MessageBox.Show($"Has seleccionado un volquete {volqueteSeleccionado} en {localidad}. En Temperley, su pedido no tiene recarga");
                }
                else
                {
                    // Utiliza el método de la instancia de Volquete para calcular el recargo
                    decimal recargo = volqueteSeleccionado.CalcularRecargoPorLocalidad(localidad);

                    decimal precio = volqueteSeleccionado.MontoAPagar;
                    decimal precioConRecargo = precio + (precio * recargo);
                    MessageBox.Show($"Has seleccionado un volquete {comboBox_ventas.SelectedItem} en {localidad}. El Precio Normal es de {precio:C}, El Precio con recargo: {precioConRecargo:C}");
                }
            }
        }

        public void InsertarPedidoEnBaseDeDatos(Pedido pedido)
        {
            string query = "INSERT INTO Pedidos (Usuario, Recibe, TipoVolquete, Cantidad, MontoAPagar, NumeroDePedido, Domicilio, Estado, FechaEntrega, DuracionEntregaDias, FechaRetiro, TipoBolson, CantidadBolsones, MontoAPagarBolson) " +
                           "VALUES (@Usuario, @Recibe, @TipoVolquete, @Cantidad, @MontoAPagar, @NumeroDePedido, @Domicilio, @Estado, @FechaEntrega, @DuracionEntregaDias, @FechaRetiro, @TipoBolson, @CantidadBolsones, @MontoAPagarBolson)";

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7SSNEAH\\MATIASSQL;Initial Catalog=MiBaseDeDatos;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", pedido.Usuario);
                    command.Parameters.AddWithValue("@Recibe", pedido.Nombre);
                    command.Parameters.AddWithValue("@TipoVolquete", pedido.Tipo.Tipo.ToString());
                    command.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);
                    command.Parameters.AddWithValue("@MontoAPagar", pedido.MontoAPagar);
                    command.Parameters.AddWithValue("@NumeroDePedido", pedido.NumeroDePedido);
                    command.Parameters.AddWithValue("@Domicilio", pedido.Domicilio);
                    command.Parameters.AddWithValue("@Estado", "Activo");
                    command.Parameters.AddWithValue("@FechaEntrega", pedido.FechaEntrega);
                    command.Parameters.AddWithValue("@DuracionEntregaDias", pedido.DuracionEntregaDias);
                    command.Parameters.AddWithValue("@FechaRetiro", pedido.FechaRetiro);

                    if (pedido.Bolson != null)
                    {
                        command.Parameters.AddWithValue("@TipoBolson", pedido.Bolson.Tipo.ToString());
                        command.Parameters.AddWithValue("@CantidadBolsones", pedido.CantidadBolsones);
                        command.Parameters.AddWithValue("@MontoAPagarBolson", pedido.MontoAPagarBolson);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@TipoBolson", "no asignado");
                        command.Parameters.AddWithValue("@CantidadBolsones", 0);
                        command.Parameters.AddWithValue("@MontoAPagarBolson", 0);
                    }

                    command.ExecuteNonQuery();
                }
            }
        }

        private void Button_Pedir_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_ventas.SelectedItem == null && bolsonSeleccionadoConVolquete == true)
                {
                    throw new Exception("Lo sentimos, pero no vendemos bolsones por separado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Atención: {ex.Message}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox_ventas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de volquete antes de hacer el pedido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Utiliza el polimorfismo para calcular el recargo por localidad
                decimal recargo = volqueteSeleccionado.CalcularRecargoPorLocalidad(localidad);

                // Aplica el recargo al precio del volquete
                decimal precio = volqueteSeleccionado.MontoAPagar + (volqueteSeleccionado.MontoAPagar * recargo);
                decimal costoTotal = cantidadVolquetes * precio;
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
                    FechaRetiro = FechaRetiro,
                    Bolson = bolsonSeleccionadoConVolquete ? bolsonSeleccionado : null,
                    CantidadBolsones = bolsonSeleccionadoConVolquete ? cantidadbolsones : 0,
                    MontoAPagarBolson = costoTotalBolsones
                };

                if (bolsonSeleccionadoConVolquete == true)
                {
                    nuevoPedido.Bolson = bolsonSeleccionado;
                    nuevoPedido.CantidadBolsones = NumeroDebolsones;
                    nuevoPedido.MontoAPagarBolson = costoTotalBolsones;  // Asigna el costo total de los bolsones al pedido
                    var ConstoFinal = costoTotal + nuevoPedido.MontoAPagarBolson;
                    MessageBox.Show($"Monto a Pagar Final : {ConstoFinal}");
                }

                DialogResult result = MessageBox.Show("¿Está seguro de realizar el pedido?", "Confirmar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
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
                                new XElement("DuracionEntregaDias", pedido.DuracionEntregaDias),
                                new XElement("FechaRetiro", pedido.FechaRetiro.ToString("dd/MM/yyyy")),
                                pedido.Bolson != null
                                    ? new XElement("Bolson",
                                        new XElement("TipoBolson", pedido.Bolson.Tipo),
                                        new XElement("CantidadBolsones", pedido.CantidadBolsones),
                                        new XElement("MontoAPagarBolson", pedido.MontoAPagarBolson)
                                    )
                                    : null
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

                    InsertarPedidoEnBaseDeDatos(nuevoPedido);

                    MessageBox.Show($"Pedido Realizado con éxito. El Numero De Su Pedido es {numeroPedidoAleatorio}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Form_alquiler alquiler = new Form_alquiler();
                    alquiler.Show();
                }
                else
                {
                    
                    MessageBox.Show("Pedido cancelado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }





    }

}


