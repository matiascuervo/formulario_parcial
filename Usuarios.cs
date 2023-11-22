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
        public Usuarios()
        {

            InitializeComponent();
            pedidosForm = new Pedidos_Form();
        }


        private void Boton_Volver_Usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_alquiler alquiler = new Form_alquiler();
            alquiler.ShowDialog();
        }

        private void dataGridView_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Supongamos que tienes una instancia válida de Pedidos_Form llamada pedidosForm
            

        }
    }
}
