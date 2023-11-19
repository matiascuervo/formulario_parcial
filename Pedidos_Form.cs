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
    public partial class Pedidos_Form : Form
    {
        public Pedidos_Form()
        {
            InitializeComponent();
        }

        private void Boton_Volver_Pedidos_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_alquiler alquiler = new Form_alquiler();
            alquiler.ShowDialog();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
