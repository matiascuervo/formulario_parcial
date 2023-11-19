using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_parcial
{
    public partial class Form_alquiler : Form
    {
        public Form_alquiler()
        {
            InitializeComponent();
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
            this.Close();
            Pedidos_Form pedidos_Form = new Pedidos_Form();
            pedidos_Form.ShowDialog();
        }
    }
}
