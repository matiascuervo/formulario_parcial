namespace formulario_parcial
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            Boton_Volver_Usuarios = new RoundButton();
            dataGridView_Usuarios = new DataGridView();
            Column_Usuario = new DataGridViewTextBoxColumn();
            Columna_Nombre = new DataGridViewTextBoxColumn();
            Columna_Tipo = new DataGridViewTextBoxColumn();
            Columna_Cantidad = new DataGridViewTextBoxColumn();
            Columna_MontoAPagar = new DataGridViewTextBoxColumn();
            Columna_Numero_De_Pedido = new DataGridViewTextBoxColumn();
            Columna_Direccion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Usuarios).BeginInit();
            SuspendLayout();
            // 
            // Boton_Volver_Usuarios
            // 
            Boton_Volver_Usuarios.BackColor = Color.Transparent;
            Boton_Volver_Usuarios.FlatStyle = FlatStyle.Flat;
            Boton_Volver_Usuarios.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Boton_Volver_Usuarios.ForeColor = SystemColors.ActiveCaptionText;
            Boton_Volver_Usuarios.Location = new Point(-5, 396);
            Boton_Volver_Usuarios.Name = "Boton_Volver_Usuarios";
            Boton_Volver_Usuarios.Size = new Size(57, 56);
            Boton_Volver_Usuarios.TabIndex = 8;
            Boton_Volver_Usuarios.Text = "↩";
            Boton_Volver_Usuarios.UseVisualStyleBackColor = false;
            Boton_Volver_Usuarios.Click += Boton_Volver_Usuarios_Click;
            // 
            // dataGridView_Usuarios
            // 
            dataGridView_Usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Usuarios.Columns.AddRange(new DataGridViewColumn[] { Column_Usuario, Columna_Nombre, Columna_Tipo, Columna_Cantidad, Columna_MontoAPagar, Columna_Numero_De_Pedido, Columna_Direccion });
            dataGridView_Usuarios.Location = new Point(25, 12);
            dataGridView_Usuarios.Name = "dataGridView_Usuarios";
            dataGridView_Usuarios.RowTemplate.Height = 25;
            dataGridView_Usuarios.Size = new Size(745, 149);
            dataGridView_Usuarios.TabIndex = 9;
            dataGridView_Usuarios.CellContentClick += dataGridView_Usuarios_CellContentClick;
            // 
            // Column_Usuario
            // 
            Column_Usuario.HeaderText = "Usuario";
            Column_Usuario.Name = "Column_Usuario";
            // 
            // Columna_Nombre
            // 
            Columna_Nombre.HeaderText = "Nombre";
            Columna_Nombre.Name = "Columna_Nombre";
            // 
            // Columna_Tipo
            // 
            Columna_Tipo.HeaderText = "Tipo De Volquete";
            Columna_Tipo.Name = "Columna_Tipo";
            // 
            // Columna_Cantidad
            // 
            Columna_Cantidad.HeaderText = "Cantidad";
            Columna_Cantidad.Name = "Columna_Cantidad";
            // 
            // Columna_MontoAPagar
            // 
            Columna_MontoAPagar.HeaderText = "Monto A Pagar";
            Columna_MontoAPagar.Name = "Columna_MontoAPagar";
            // 
            // Columna_Numero_De_Pedido
            // 
            Columna_Numero_De_Pedido.HeaderText = "Numero De Pedido";
            Columna_Numero_De_Pedido.Name = "Columna_Numero_De_Pedido";
            // 
            // Columna_Direccion
            // 
            Columna_Direccion.HeaderText = "Domicilio";
            Columna_Direccion.Name = "Columna_Direccion";
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_Usuarios);
            Controls.Add(Boton_Volver_Usuarios);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Usuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Usuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundButton Boton_Volver_Usuarios;
        private DataGridView dataGridView_Usuarios;
        private DataGridViewTextBoxColumn Column_Usuario;
        private DataGridViewTextBoxColumn Columna_Nombre;
        private DataGridViewTextBoxColumn Columna_Tipo;
        private DataGridViewTextBoxColumn Columna_Cantidad;
        private DataGridViewTextBoxColumn Columna_MontoAPagar;
        private DataGridViewTextBoxColumn Columna_Numero_De_Pedido;
        private DataGridViewTextBoxColumn Columna_Direccion;
    }
}