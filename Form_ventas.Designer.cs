namespace formulario_parcial
{
    partial class Form_ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ventas));
            label1 = new Label();
            comboBox_ventas = new ComboBox();
            textBox_Cantidad = new TextBox();
            Label_Cantidad = new Label();
            Button_Pedir = new Button();
            pictureBox1 = new PictureBox();
            Boton_Volver_Ventas = new RoundButton();
            label_Localidad = new Label();
            comboBox_Localidad = new ComboBox();
            textBox_Nombre_Final = new TextBox();
            label_Nombre_Final = new Label();
            label_Dirrecion = new Label();
            TextBox_Direccion = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 46);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Tamaño";
            // 
            // comboBox_ventas
            // 
            comboBox_ventas.FormattingEnabled = true;
            comboBox_ventas.Location = new Point(137, 51);
            comboBox_ventas.Name = "comboBox_ventas";
            comboBox_ventas.Size = new Size(121, 23);
            comboBox_ventas.TabIndex = 1;
            // 
            // textBox_Cantidad
            // 
            textBox_Cantidad.Location = new Point(135, 204);
            textBox_Cantidad.Name = "textBox_Cantidad";
            textBox_Cantidad.Size = new Size(121, 23);
            textBox_Cantidad.TabIndex = 5;
            textBox_Cantidad.TextChanged += textBox_Cantidad_TextChanged;
            // 
            // Label_Cantidad
            // 
            Label_Cantidad.AutoSize = true;
            Label_Cantidad.BackColor = Color.Gold;
            Label_Cantidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Cantidad.Location = new Point(39, 199);
            Label_Cantidad.Name = "Label_Cantidad";
            Label_Cantidad.Size = new Size(92, 25);
            Label_Cantidad.TabIndex = 3;
            Label_Cantidad.Text = "Cantidad";
            // 
            // Button_Pedir
            // 
            Button_Pedir.BackColor = Color.Red;
            Button_Pedir.FlatStyle = FlatStyle.System;
            Button_Pedir.Location = new Point(321, 283);
            Button_Pedir.Name = "Button_Pedir";
            Button_Pedir.Size = new Size(153, 40);
            Button_Pedir.TabIndex = 6;
            Button_Pedir.Text = "Finalizar Pedido";
            Button_Pedir.UseVisualStyleBackColor = false;
            Button_Pedir.Click += Button_Pedir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(292, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(501, 231);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Boton_Volver_Ventas
            // 
            Boton_Volver_Ventas.BackColor = Color.Transparent;
            Boton_Volver_Ventas.FlatStyle = FlatStyle.Popup;
            Boton_Volver_Ventas.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Boton_Volver_Ventas.ForeColor = SystemColors.ActiveCaptionText;
            Boton_Volver_Ventas.Location = new Point(12, 283);
            Boton_Volver_Ventas.Name = "Boton_Volver_Ventas";
            Boton_Volver_Ventas.Size = new Size(57, 56);
            Boton_Volver_Ventas.TabIndex = 6;
            Boton_Volver_Ventas.Text = "↩";
            Boton_Volver_Ventas.UseVisualStyleBackColor = false;
            Boton_Volver_Ventas.Click += Boton_Volver_Ventas_Click;
            // 
            // label_Localidad
            // 
            label_Localidad.AutoSize = true;
            label_Localidad.BackColor = Color.Gold;
            label_Localidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Localidad.Location = new Point(39, 80);
            label_Localidad.Name = "label_Localidad";
            label_Localidad.Size = new Size(97, 25);
            label_Localidad.TabIndex = 8;
            label_Localidad.Text = "Localidad";
            // 
            // comboBox_Localidad
            // 
            comboBox_Localidad.FormattingEnabled = true;
            comboBox_Localidad.Location = new Point(137, 80);
            comboBox_Localidad.Name = "comboBox_Localidad";
            comboBox_Localidad.Size = new Size(121, 23);
            comboBox_Localidad.TabIndex = 2;
            comboBox_Localidad.SelectedIndexChanged += comboBox_Localidad_SelectedIndexChanged;
            // 
            // textBox_Nombre_Final
            // 
            textBox_Nombre_Final.Location = new Point(137, 122);
            textBox_Nombre_Final.Name = "textBox_Nombre_Final";
            textBox_Nombre_Final.Size = new Size(121, 23);
            textBox_Nombre_Final.TabIndex = 3;
            // 
            // label_Nombre_Final
            // 
            label_Nombre_Final.AutoSize = true;
            label_Nombre_Final.BackColor = Color.Gold;
            label_Nombre_Final.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nombre_Final.Location = new Point(39, 117);
            label_Nombre_Final.Name = "label_Nombre_Final";
            label_Nombre_Final.Size = new Size(86, 25);
            label_Nombre_Final.TabIndex = 11;
            label_Nombre_Final.Text = "Nombre";
            // 
            // label_Dirrecion
            // 
            label_Dirrecion.AutoSize = true;
            label_Dirrecion.BackColor = Color.Gold;
            label_Dirrecion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Dirrecion.Location = new Point(39, 156);
            label_Dirrecion.Name = "label_Dirrecion";
            label_Dirrecion.Size = new Size(95, 25);
            label_Dirrecion.TabIndex = 12;
            label_Dirrecion.Text = "Dirrecion";
            // 
            // TextBox_Direccion
            // 
            TextBox_Direccion.Location = new Point(135, 161);
            TextBox_Direccion.Name = "TextBox_Direccion";
            TextBox_Direccion.Size = new Size(121, 23);
            TextBox_Direccion.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 252);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 13;
            // 
            // Form_ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(828, 373);
            Controls.Add(label2);
            Controls.Add(TextBox_Direccion);
            Controls.Add(label_Dirrecion);
            Controls.Add(label_Nombre_Final);
            Controls.Add(textBox_Nombre_Final);
            Controls.Add(comboBox_Localidad);
            Controls.Add(label_Localidad);
            Controls.Add(Boton_Volver_Ventas);
            Controls.Add(pictureBox1);
            Controls.Add(Button_Pedir);
            Controls.Add(Label_Cantidad);
            Controls.Add(textBox_Cantidad);
            Controls.Add(comboBox_ventas);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_ventas";
            Text = "Form_ventas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private ComboBox comboBox_ventas;
        private TextBox textBox_Cantidad;
        private Label Label_Cantidad;
        private Button Button_Pedir;
        private PictureBox pictureBox1;
        private RoundButton Boton_Volver_Ventas;
        private Label label_Localidad;
        private ComboBox comboBox_Localidad;
        private TextBox textBox_Nombre_Final;
        private Label label_Nombre_Final;
        private Label label_Dirrecion;
        private TextBox TextBox_Direccion;
        private Label label2;
    }
}