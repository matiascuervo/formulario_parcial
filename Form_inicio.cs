namespace formulario_parcial
{
    public partial class Form_inicio : Form
    {
        public Form_inicio()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioUsuario formulario = new FormularioUsuario();
            this.Hide();

            formulario.ShowDialog();
        }

        private void button_Registro_Click(object sender, EventArgs e)
        {
            Registro Registro = new Registro();
            Registro.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {


        }


    }

}
