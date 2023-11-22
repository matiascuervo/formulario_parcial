﻿namespace formulario_parcial
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
            toolStripButton_Pedidos = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox_Pedidos = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            dataGridView_Pedidos = new DataGridView();
            columna_Usuario = new DataGridViewTextBoxColumn();
            Columna_Nombre = new DataGridViewTextBoxColumn();
            Columna_Tipo = new DataGridViewTextBoxColumn();
            Columna_Cantidad = new DataGridViewTextBoxColumn();
            Columna_MontoAPagar = new DataGridViewTextBoxColumn();
            Columna_Numero_De_Pedido = new DataGridViewTextBoxColumn();
            Columna_Direccion = new DataGridViewTextBoxColumn();
            Columna_Estado = new DataGridViewTextBoxColumn();
            Boton_Volver_Pedidos = new RoundButton();
            button_Cancelar = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Pedidos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton_Pedidos, toolStripLabel1, toolStripTextBox_Pedidos, toolStripSeparator1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Pedidos
            // 
            toolStripButton_Pedidos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Pedidos.Image = (Image)resources.GetObject("toolStripButton_Pedidos.Image");
            toolStripButton_Pedidos.ImageTransparentColor = Color.Magenta;
            toolStripButton_Pedidos.Name = "toolStripButton_Pedidos";
            toolStripButton_Pedidos.Size = new Size(23, 22);
            toolStripButton_Pedidos.Text = "toolStripButton1";
            toolStripButton_Pedidos.Click += toolStripButton_Pedidos_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(49, 22);
            toolStripLabel1.Text = "Pedidos";
            // 
            // toolStripTextBox_Pedidos
            // 
            toolStripTextBox_Pedidos.Name = "toolStripTextBox_Pedidos";
            toolStripTextBox_Pedidos.Size = new Size(100, 25);
            toolStripTextBox_Pedidos.Click += toolStripTextBox_Pedidos_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // dataGridView_Pedidos
            // 
            dataGridView_Pedidos.BackgroundColor = SystemColors.ButtonFace;
            dataGridView_Pedidos.BorderStyle = BorderStyle.None;
            dataGridView_Pedidos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView_Pedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_Pedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Pedidos.Columns.AddRange(new DataGridViewColumn[] { columna_Usuario, Columna_Nombre, Columna_Tipo, Columna_Cantidad, Columna_MontoAPagar, Columna_Numero_De_Pedido, Columna_Direccion, Columna_Estado });
            dataGridView_Pedidos.GridColor = SystemColors.ControlDarkDark;
            dataGridView_Pedidos.Location = new Point(0, 28);
            dataGridView_Pedidos.Name = "dataGridView_Pedidos";
            dataGridView_Pedidos.RowTemplate.Height = 25;
            dataGridView_Pedidos.Size = new Size(788, 100);
            dataGridView_Pedidos.TabIndex = 1;
            dataGridView_Pedidos.CellContentClick += dataGridView_Pedidos_CellContentClick;
            // 
            // columna_Usuario
            // 
            columna_Usuario.HeaderText = "Usuario";
            columna_Usuario.Name = "columna_Usuario";
            // 
            // Columna_Nombre
            // 
            Columna_Nombre.HeaderText = "Nombre";
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
            // Boton_Volver_Pedidos
            // 
            Boton_Volver_Pedidos.BackColor = Color.Transparent;
            Boton_Volver_Pedidos.FlatStyle = FlatStyle.Popup;
            Boton_Volver_Pedidos.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Boton_Volver_Pedidos.ForeColor = SystemColors.ActiveCaptionText;
            Boton_Volver_Pedidos.Location = new Point(0, 376);
            Boton_Volver_Pedidos.Name = "Boton_Volver_Pedidos";
            Boton_Volver_Pedidos.Size = new Size(74, 76);
            Boton_Volver_Pedidos.TabIndex = 8;
            Boton_Volver_Pedidos.Text = "↩";
            Boton_Volver_Pedidos.UseVisualStyleBackColor = false;
            Boton_Volver_Pedidos.Click += Boton_Volver_Pedidos_Click_1;
            // 
            // button_Cancelar
            // 
            button_Cancelar.BackColor = Color.WhiteSmoke;
            button_Cancelar.BackgroundImageLayout = ImageLayout.Stretch;
            button_Cancelar.FlatStyle = FlatStyle.Popup;
            button_Cancelar.Location = new Point(12, 277);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(116, 37);
            button_Cancelar.TabIndex = 9;
            button_Cancelar.Text = "Cancelar Pedido";
            button_Cancelar.UseVisualStyleBackColor = false;
            button_Cancelar.Click += button_Cancelar_Click;
            // 
            // Pedidos_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button_Cancelar);
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
        private ToolStripButton toolStripButton_Pedidos;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox toolStripTextBox_Pedidos;
        private DataGridView dataGridView_Pedidos;
        private DataGridViewTextBoxColumn columna_Usuario;
        private DataGridViewTextBoxColumn Columna_Nombre;
        private DataGridViewTextBoxColumn Columna_Tipo;
        private DataGridViewTextBoxColumn Columna_Cantidad;
        private DataGridViewTextBoxColumn Columna_MontoAPagar;
        private DataGridViewTextBoxColumn Columna_Numero_De_Pedido;
        private DataGridViewTextBoxColumn Columna_Direccion;
        private RoundButton Boton_Volver_Pedidos;
        private Button button_Cancelar;
        private DataGridViewTextBoxColumn Columna_Estado;
    }
}