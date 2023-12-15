using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDatamanager;
using BiblotecaDatamanager;


namespace formulario_parcial
{
    public partial class Form_BasedeDatos : Form
    {
        private readonly BaseDatosManager _baseDatosManager;

        public Form_BasedeDatos(BaseDatosManager baseDatosManager)
        {
            InitializeComponent();
            _baseDatosManager = baseDatosManager;
            MostrarDatosEnDataGridView();
            CargarValoresEnComboBox();
        }

        private void button_Conectar_Click(object sender, EventArgs e)
        {
            BaseDatosManager manager = new BaseDatosManager("Data Source=DESKTOP-7SSNEAH\\MATIASSQL;Initial Catalog=MiBaseDeDatos;Integrated Security=True");


            manager.ProbarConexion();


        }



        private void MostrarDatosEnDataGridView()
        {
            string query = "SELECT * FROM dbo.Usuarios";

            using (SqlConnection connection = new SqlConnection(_baseDatosManager.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        System.Data.DataTable dataTable = new System.Data.DataTable();
                        adapter.Fill(dataTable);

                        // Limpiar las columnas existentes en el DataGridView
                        dataGridView1.Columns.Clear();

                        // Asignar la fuente de datos al DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }


        private void CargarValoresEnComboBox()
        {
            string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Usuarios'";

            using (SqlConnection connection = new SqlConnection(_baseDatosManager.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxUsuarios.Items.Add(reader["COLUMN_NAME"].ToString());
                        }
                    }
                }
            }
        }


        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            string columnaSeleccionada = comboBoxUsuarios.SelectedItem?.ToString();
            string valorActual = textBoxValorActual.Text;
            string nuevoValor = textBoxNuevoValor.Text;

            if (string.IsNullOrEmpty(columnaSeleccionada) || string.IsNullOrEmpty(valorActual) || string.IsNullOrEmpty(nuevoValor))
            {
                MessageBox.Show("Selecciona una columna y proporciona los valores adecuados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas modificar el valor de '{columnaSeleccionada}' de '{valorActual}' a '{nuevoValor}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string updateQuery = $"UPDATE dbo.Usuarios SET {columnaSeleccionada} = @nuevoValor WHERE {columnaSeleccionada} = @valorActual";

                using (SqlConnection connection = new SqlConnection(_baseDatosManager.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@nuevoValor", nuevoValor);
                        command.Parameters.AddWithValue("@valorActual", valorActual);

                        command.ExecuteNonQuery();
                    }
                }

                // Volver a cargar los datos en el DataGridView después de la modificación
                MostrarDatosEnDataGridView();

                MessageBox.Show("El valor se ha modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }





        private void Boton_Volver_BaseDeDatos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_alquiler alquiler = new Form_alquiler();
            alquiler.ShowDialog();
        }
    }
}


