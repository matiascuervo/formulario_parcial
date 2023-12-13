namespace formulario_parcial
{
    partial class PedidosDeLosUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidosDeLosUsuarios));
            Boton_Volver_PedidosU = new RoundButton();
            dataGridView_Pedidos = new DataGridView();
            columna_Usuario = new DataGridViewTextBoxColumn();
            Columna_Nombre = new DataGridViewTextBoxColumn();
            Columna_Tipo = new DataGridViewTextBoxColumn();
            Columna_Cantidad = new DataGridViewTextBoxColumn();
            Columna_MontoAPagar = new DataGridViewTextBoxColumn();
            Columna_Numero_De_Pedido = new DataGridViewTextBoxColumn();
            Columna_Direccion = new DataGridViewTextBoxColumn();
            Columna_Estado = new DataGridViewTextBoxColumn();
            Columna_FechaEntrega = new DataGridViewTextBoxColumn();
            Columna_FechaRetiro = new DataGridViewTextBoxColumn();
            columna_bolsones = new DataGridViewTextBoxColumn();
            Columna_cantidadbolsones = new DataGridViewTextBoxColumn();
            Columna_Preciobolsones = new DataGridViewTextBoxColumn();
            textBox_Nombre_Buscado = new TextBox();
            button_buscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Pedidos).BeginInit();
            SuspendLayout();
            // 
            // Boton_Volver_PedidosU
            // 
            Boton_Volver_PedidosU.BackColor = Color.Transparent;
            Boton_Volver_PedidosU.FlatStyle = FlatStyle.Popup;
            Boton_Volver_PedidosU.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Boton_Volver_PedidosU.ForeColor = SystemColors.ActiveCaptionText;
            Boton_Volver_PedidosU.Location = new Point(2, 393);
            Boton_Volver_PedidosU.Name = "Boton_Volver_PedidosU";
            Boton_Volver_PedidosU.Size = new Size(57, 56);
            Boton_Volver_PedidosU.TabIndex = 8;
            Boton_Volver_PedidosU.Text = "↩";
            Boton_Volver_PedidosU.UseVisualStyleBackColor = false;
            Boton_Volver_PedidosU.Click += Boton_Volver_PedidosU_Click;
            // 
            // dataGridView_Pedidos
            // 
            dataGridView_Pedidos.BackgroundColor = SystemColors.ButtonFace;
            dataGridView_Pedidos.BorderStyle = BorderStyle.None;
            dataGridView_Pedidos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView_Pedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_Pedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Pedidos.Columns.AddRange(new DataGridViewColumn[] { columna_Usuario, Columna_Nombre, Columna_Tipo, Columna_Cantidad, Columna_MontoAPagar, Columna_Numero_De_Pedido, Columna_Direccion, Columna_Estado, Columna_FechaEntrega, Columna_FechaRetiro, columna_bolsones, Columna_cantidadbolsones, Columna_Preciobolsones });
            dataGridView_Pedidos.GridColor = SystemColors.ControlDarkDark;
            dataGridView_Pedidos.Location = new Point(2, 1);
            dataGridView_Pedidos.Name = "dataGridView_Pedidos";
            dataGridView_Pedidos.RowTemplate.Height = 25;
            dataGridView_Pedidos.Size = new Size(800, 333);
            dataGridView_Pedidos.TabIndex = 9;
            // 
            // columna_Usuario
            // 
            columna_Usuario.HeaderText = "Usuario";
            columna_Usuario.Name = "columna_Usuario";
            // 
            // Columna_Nombre
            // 
            Columna_Nombre.HeaderText = "Recibe";
            Columna_Nombre.Name = "Columna_Nombre";
            // 
            // Columna_Tipo
            // 
            Columna_Tipo.HeaderText = "Tipo de volquete";
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
            // Columna_Estado
            // 
            Columna_Estado.HeaderText = "Estado Del Pedido";
            Columna_Estado.Name = "Columna_Estado";
            // 
            // Columna_FechaEntrega
            // 
            Columna_FechaEntrega.HeaderText = "Fecha De Entrega";
            Columna_FechaEntrega.Name = "Columna_FechaEntrega";
            // 
            // Columna_FechaRetiro
            // 
            Columna_FechaRetiro.HeaderText = "Fecha De Retiro";
            Columna_FechaRetiro.Name = "Columna_FechaRetiro";
            // 
            // columna_bolsones
            // 
            columna_bolsones.HeaderText = "Bolsones";
            columna_bolsones.Name = "columna_bolsones";
            // 
            // Columna_cantidadbolsones
            // 
            Columna_cantidadbolsones.HeaderText = "Cantidad Bolsones";
            Columna_cantidadbolsones.Name = "Columna_cantidadbolsones";
            // 
            // Columna_Preciobolsones
            // 
            Columna_Preciobolsones.HeaderText = "Monto Bolsones";
            Columna_Preciobolsones.Name = "Columna_Preciobolsones";
            // 
            // textBox_Nombre_Buscado
            // 
            textBox_Nombre_Buscado.Location = new Point(656, 355);
            textBox_Nombre_Buscado.Name = "textBox_Nombre_Buscado";
            textBox_Nombre_Buscado.Size = new Size(100, 23);
            textBox_Nombre_Buscado.TabIndex = 10;
            textBox_Nombre_Buscado.Enter += MostrarPedidosUsuario_Click;
            // 
            // button_buscar
            // 
            button_buscar.Location = new Point(550, 355);
            button_buscar.Name = "button_buscar";
            button_buscar.Size = new Size(75, 23);
            button_buscar.TabIndex = 11;
            button_buscar.Text = "button1";
            button_buscar.UseVisualStyleBackColor = true;
            button_buscar.Click += MostrarPedidosUsuario_Click;
            // 
            // PedidosDeLosUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_buscar);
            Controls.Add(textBox_Nombre_Buscado);
            Controls.Add(dataGridView_Pedidos);
            Controls.Add(Boton_Volver_PedidosU);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PedidosDeLosUsuarios";
            Text = "PedidosDeLosUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Pedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RoundButton Boton_Volver_PedidosU;
        private DataGridView dataGridView_Pedidos;
        private DataGridViewTextBoxColumn columna_Usuario;
        private DataGridViewTextBoxColumn Columna_Nombre;
        private DataGridViewTextBoxColumn Columna_Tipo;
        private DataGridViewTextBoxColumn Columna_Cantidad;
        private DataGridViewTextBoxColumn Columna_MontoAPagar;
        private DataGridViewTextBoxColumn Columna_Numero_De_Pedido;
        private DataGridViewTextBoxColumn Columna_Direccion;
        private DataGridViewTextBoxColumn Columna_Estado;
        private DataGridViewTextBoxColumn Columna_FechaEntrega;
        private DataGridViewTextBoxColumn Columna_FechaRetiro;
        private DataGridViewTextBoxColumn columna_bolsones;
        private DataGridViewTextBoxColumn Columna_cantidadbolsones;
        private DataGridViewTextBoxColumn Columna_Preciobolsones;
        private TextBox textBox_Nombre_Buscado;
        private Button button_buscar;
    }
}