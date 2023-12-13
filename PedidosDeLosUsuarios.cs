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
    public partial class PedidosDeLosUsuarios : Form
    {
        public delegate void MostrarPedidosDelegate(string nombreUsuario);

        public PedidosDeLosUsuarios()
        {
            InitializeComponent();
            button_buscar.Click += MostrarPedidosUsuario_Click;
           
        }

        private void Boton_Volver_PedidosU_Click(object sender, EventArgs e)
        {
            Form_alquiler alquiler = new Form_alquiler();
            this.Hide();
            alquiler.ShowDialog();
        }

        public void MostrarPedidosUsuario_Click(object sender, EventArgs e)
        {
            
            string nombreUsuario = textBox_Nombre_Buscado.Text;

            
            MostrarPedidosHandler?.Invoke(nombreUsuario);
        }

        
        public MostrarPedidosDelegate MostrarPedidosHandler;

    
        private void AgregarFilaPedidoAlDataGridView(XElement pedido)
        {
            int rowIndex = dataGridView_Pedidos.Rows.Add();
            DataGridViewRow row = dataGridView_Pedidos.Rows[rowIndex];

            // Agrega las celdas al DataGridView
            row.Cells["columna_Usuario"].Value = ObtenerValorElemento(pedido, "Usuario");
            row.Cells["columna_Nombre"].Value = ObtenerValorElemento(pedido, "Nombre");
            row.Cells["columna_Tipo"].Value = ObtenerValorElemento(pedido, "TipoVolquete");
            row.Cells["columna_Cantidad"].Value = ObtenerValorElemento(pedido, "Cantidad");
            row.Cells["columna_MontoAPagar"].Value = ObtenerValorElemento(pedido, "MontoAPagar");
            row.Cells["Columna_Numero_De_Pedido"].Value = ObtenerValorElemento(pedido, "NumeroDePedido");
            row.Cells["columna_Direccion"].Value = ObtenerValorElemento(pedido, "Domicilio");
            row.Cells["columna_Estado"].Value = ObtenerValorElemento(pedido, "Estado");
            row.Cells["columna_FechaEntrega"].Value = ObtenerValorElemento(pedido, "FechaEntrega");
            row.Cells["columna_FechaRetiro"].Value = ObtenerValorElemento(pedido, "FechaRetiro");
            row.Cells["columna_bolsones"].Value = ObtenerValorElemento(pedido, "Bolson/TipoBolson");
            row.Cells["columna_cantidadbolsones"].Value = ObtenerValorElemento(pedido, "Bolson/CantidadBolsones");
            row.Cells["Columna_Preciobolsones"].Value = ObtenerValorElemento(pedido, "Bolson/MontoAPagarBolson");
        }

        // Método para obtener el valor de un elemento específico de un XElement
        private string ObtenerValorElemento(XElement elemento, string nombre)
        {
            return elemento.Element(nombre)?.Value;
        }
    }
}





