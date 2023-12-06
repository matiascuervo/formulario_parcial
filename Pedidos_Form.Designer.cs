namespace formulario_parcial
{
    partial class Pedidos_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos_Form));
            toolStrip1 = new ToolStrip();
            toolStripButton_Cancelados = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton_VerPedidos = new ToolStripButton();
            toolStripLabel2 = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripLabel3 = new ToolStripLabel();
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
            Boton_Volver_Pedidos = new RoundButton();
            button_Buscar = new Button();
            textBox_Fecha = new TextBox();
            button_Generar_Pdf = new Button();
            textBox_Pdf = new TextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Pedidos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton_Cancelados, toolStripLabel1, toolStripSeparator1, toolStripButton_VerPedidos, toolStripLabel2, toolStripSeparator2, toolStripButton1, toolStripLabel3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Cancelados
            // 
            toolStripButton_Cancelados.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Cancelados.Image = (Image)resources.GetObject("toolStripButton_Cancelados.Image");
            toolStripButton_Cancelados.ImageTransparentColor = Color.Magenta;
            toolStripButton_Cancelados.Name = "toolStripButton_Cancelados";
            toolStripButton_Cancelados.Size = new Size(23, 22);
            toolStripButton_Cancelados.Text = "toolStripButton_Cancelados";
            toolStripButton_Cancelados.ToolTipText = "Precione Para Ver Sus Pedidos Cancelados";
            toolStripButton_Cancelados.Click += toolStripButton_Cancelados_Click_1;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(113, 22);
            toolStripLabel1.Text = "Pedidos Cancelados";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButton_VerPedidos
            // 
            toolStripButton_VerPedidos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_VerPedidos.Image = (Image)resources.GetObject("toolStripButton_VerPedidos.Image");
            toolStripButton_VerPedidos.ImageTransparentColor = Color.Magenta;
            toolStripButton_VerPedidos.Name = "toolStripButton_VerPedidos";
            toolStripButton_VerPedidos.Size = new Size(23, 22);
            toolStripButton_VerPedidos.Text = "toolStripButton1";
            toolStripButton_VerPedidos.TextDirection = ToolStripTextDirection.Horizontal;
            toolStripButton_VerPedidos.ToolTipText = "Precione Para Ver Sus Pedidos Activos";
            toolStripButton_VerPedidos.Click += toolStripButton_VerPedidos_Click;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(91, 22);
            toolStripLabel2.Text = "Pedidos Activos";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTipText = "Ver Todos Los Pedidos";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(105, 22);
            toolStripLabel3.Text = "Todos Mis Pedidos";
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
            dataGridView_Pedidos.Location = new Point(0, 28);
            dataGridView_Pedidos.Name = "dataGridView_Pedidos";
            dataGridView_Pedidos.RowTemplate.Height = 25;
            dataGridView_Pedidos.Size = new Size(800, 333);
            dataGridView_Pedidos.TabIndex = 1;
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
            // Boton_Volver_Pedidos
            // 
            Boton_Volver_Pedidos.BackColor = Color.Transparent;
            Boton_Volver_Pedidos.FlatStyle = FlatStyle.Popup;
            Boton_Volver_Pedidos.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Boton_Volver_Pedidos.ForeColor = Color.Yellow;
            Boton_Volver_Pedidos.Location = new Point(0, 376);
            Boton_Volver_Pedidos.Name = "Boton_Volver_Pedidos";
            Boton_Volver_Pedidos.Size = new Size(74, 76);
            Boton_Volver_Pedidos.TabIndex = 3;
            Boton_Volver_Pedidos.Text = "↩";
            Boton_Volver_Pedidos.UseVisualStyleBackColor = false;
            Boton_Volver_Pedidos.Click += Boton_Volver_Pedidos_Click_1;
            // 
            // button_Buscar
            // 
            button_Buscar.BackColor = Color.Gold;
            button_Buscar.BackgroundImageLayout = ImageLayout.Stretch;
            button_Buscar.FlatStyle = FlatStyle.Flat;
            button_Buscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Buscar.Location = new Point(607, 405);
            button_Buscar.Name = "button_Buscar";
            button_Buscar.Size = new Size(144, 37);
            button_Buscar.TabIndex = 1;
            button_Buscar.Text = "Buscar Pedidos";
            button_Buscar.UseVisualStyleBackColor = false;
            button_Buscar.Click += button_Buscar_Click;
            // 
            // textBox_Fecha
            // 
            textBox_Fecha.Location = new Point(607, 376);
            textBox_Fecha.Name = "textBox_Fecha";
            textBox_Fecha.PlaceholderText = "Ejem: 25/12/2023";
            textBox_Fecha.Size = new Size(144, 23);
            textBox_Fecha.TabIndex = 2;
            // 
            // button_Generar_Pdf
            // 
            button_Generar_Pdf.BackColor = Color.Gold;
            button_Generar_Pdf.BackgroundImageLayout = ImageLayout.Stretch;
            button_Generar_Pdf.FlatStyle = FlatStyle.Flat;
            button_Generar_Pdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Generar_Pdf.Location = new Point(408, 406);
            button_Generar_Pdf.Name = "button_Generar_Pdf";
            button_Generar_Pdf.Size = new Size(144, 37);
            button_Generar_Pdf.TabIndex = 4;
            button_Generar_Pdf.Text = "Descargar PDF";
            button_Generar_Pdf.UseVisualStyleBackColor = false;
            button_Generar_Pdf.TextChanged += button_Generar_Pdf_Click_1;
            button_Generar_Pdf.Click += button_Generar_Pdf_Click_1;
            // 
            // textBox_Pdf
            // 
            textBox_Pdf.Location = new Point(408, 376);
            textBox_Pdf.Name = "textBox_Pdf";
            textBox_Pdf.PlaceholderText = "N° De Pedido";
            textBox_Pdf.Size = new Size(144, 23);
            textBox_Pdf.TabIndex = 5;
            // 
            // Pedidos_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_Pdf);
            Controls.Add(button_Generar_Pdf);
            Controls.Add(textBox_Fecha);
            Controls.Add(button_Buscar);
            Controls.Add(Boton_Volver_Pedidos);
            Controls.Add(dataGridView_Pedidos);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pedidos_Form";
            Text = "Pedidos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Pedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton_Cancelados;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private DataGridView dataGridView_Pedidos;
        private RoundButton Boton_Volver_Pedidos;
        private Button button_Buscar;
        private TextBox textBox_Fecha;
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
        private ToolStripButton toolStripButton_VerPedidos;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel3;
        private Button button_Generar_Pdf;
        private TextBox textBox_Pdf;
    }
}