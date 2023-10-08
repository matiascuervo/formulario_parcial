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
            // Crear una instancia del formulario FormularioUsuario
            FormularioUsuario formulario = new FormularioUsuario();

            // Mostrar el formulario como un diálogo modal
            DialogResult resultado = formulario.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.Close();

            }
          
            
                // Cierra la instancia actual del formulario de inicio
            
        }

    }
}
