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
            label_fecha = new Label();
            dateTime_Venta = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox_Bolsones = new ComboBox();
            label10 = new Label();
            label_BCantidad = new Label();
            label_Medida = new Label();
            textBox_Cantidad_Bolsones = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Tamaño";
            // 
            // comboBox_ventas
            // 
            comboBox_ventas.FormattingEnabled = true;
            comboBox_ventas.Location = new Point(137, 14);
            comboBox_ventas.Name = "comboBox_ventas";
            comboBox_ventas.Size = new Size(121, 23);
            comboBox_ventas.TabIndex = 1;
            comboBox_ventas.SelectedIndexChanged += comboBox_ventas_SelectedIndexChanged;
            // 
            // textBox_Cantidad
            // 
            textBox_Cantidad.Location = new Point(137, 188);
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
            Label_Cantidad.Location = new Point(39, 183);
            Label_Cantidad.Name = "Label_Cantidad";
            Label_Cantidad.Size = new Size(92, 25);
            Label_Cantidad.TabIndex = 3;
            Label_Cantidad.Text = "Cantidad";
            // 
            // Button_Pedir
            // 
            Button_Pedir.BackColor = Color.Gold;
            Button_Pedir.FlatStyle = FlatStyle.Flat;
            Button_Pedir.Location = new Point(595, 391);
            Button_Pedir.Name = "Button_Pedir";
            Button_Pedir.Size = new Size(153, 40);
            Button_Pedir.TabIndex = 9;
            Button_Pedir.Text = "Finalizar Pedido";
            Button_Pedir.UseVisualStyleBackColor = false;
            Button_Pedir.Click += Button_Pedir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(347, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 214);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Boton_Volver_Ventas
            // 
            Boton_Volver_Ventas.BackColor = Color.Transparent;
            Boton_Volver_Ventas.FlatStyle = FlatStyle.Popup;
            Boton_Volver_Ventas.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Boton_Volver_Ventas.ForeColor = SystemColors.ActiveCaptionText;
            Boton_Volver_Ventas.Location = new Point(-4, 455);
            Boton_Volver_Ventas.Name = "Boton_Volver_Ventas";
            Boton_Volver_Ventas.Size = new Size(57, 56);
            Boton_Volver_Ventas.TabIndex = 10;
            Boton_Volver_Ventas.Text = "↩";
            Boton_Volver_Ventas.UseVisualStyleBackColor = false;
            Boton_Volver_Ventas.Click += Boton_Volver_Ventas_Click;
            // 
            // label_Localidad
            // 
            label_Localidad.AutoSize = true;
            label_Localidad.BackColor = Color.Gold;
            label_Localidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Localidad.Location = new Point(39, 51);
            label_Localidad.Name = "label_Localidad";
            label_Localidad.Size = new Size(97, 25);
            label_Localidad.TabIndex = 8;
            label_Localidad.Text = "Localidad";
            // 
            // comboBox_Localidad
            // 
            comboBox_Localidad.FormattingEnabled = true;
            comboBox_Localidad.Location = new Point(137, 56);
            comboBox_Localidad.Name = "comboBox_Localidad";
            comboBox_Localidad.Size = new Size(121, 23);
            comboBox_Localidad.TabIndex = 2;
            comboBox_Localidad.SelectedIndexChanged += comboBox_Localidad_SelectedIndexChanged;
            // 
            // textBox_Nombre_Final
            // 
            textBox_Nombre_Final.Location = new Point(137, 103);
            textBox_Nombre_Final.Name = "textBox_Nombre_Final";
            textBox_Nombre_Final.Size = new Size(121, 23);
            textBox_Nombre_Final.TabIndex = 3;
            // 
            // label_Nombre_Final
            // 
            label_Nombre_Final.AutoSize = true;
            label_Nombre_Final.BackColor = Color.Gold;
            label_Nombre_Final.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nombre_Final.Location = new Point(39, 98);
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
            label_Dirrecion.Location = new Point(39, 142);
            label_Dirrecion.Name = "label_Dirrecion";
            label_Dirrecion.Size = new Size(95, 25);
            label_Dirrecion.TabIndex = 12;
            label_Dirrecion.Text = "Dirrecion";
            // 
            // TextBox_Direccion
            // 
            TextBox_Direccion.Location = new Point(137, 142);
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
            // label_fecha
            // 
            label_fecha.AutoSize = true;
            label_fecha.BackColor = Color.Gold;
            label_fecha.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_fecha.Location = new Point(595, 298);
            label_fecha.Name = "label_fecha";
            label_fecha.Size = new Size(114, 20);
            label_fecha.TabIndex = 15;
            label_fecha.Text = "Fecha De Envio";
            // 
            // dateTime_Venta
            // 
            dateTime_Venta.Location = new Point(595, 337);
            dateTime_Venta.Name = "dateTime_Venta";
            dateTime_Venta.Size = new Size(200, 23);
            dateTime_Venta.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Snow;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(401, 51);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 17;
            label3.Text = "$ 20.000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(683, 51);
            label4.Name = "label4";
            label4.Size = new Size(64, 19);
            label4.TabIndex = 18;
            label4.Text = "$ 40.000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gold;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(374, 9);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 19;
            label5.Text = "Volquetes";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(347, 310);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(211, 149);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Snow;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(361, 288);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 21;
            label6.Text = "$ 16.000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Snow;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(468, 288);
            label7.Name = "label7";
            label7.Size = new Size(64, 19);
            label7.TabIndex = 22;
            label7.Text = "$ 10.000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gold;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(361, 252);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 23;
            label8.Text = "2m3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gold;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(468, 252);
            label9.Name = "label9";
            label9.Size = new Size(51, 25);
            label9.TabIndex = 24;
            label9.Text = "1m3";
            // 
            // comboBox_Bolsones
            // 
            comboBox_Bolsones.FormattingEnabled = true;
            comboBox_Bolsones.Location = new Point(156, 294);
            comboBox_Bolsones.Name = "comboBox_Bolsones";
            comboBox_Bolsones.Size = new Size(121, 23);
            comboBox_Bolsones.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Gold;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(46, 252);
            label10.Name = "label10";
            label10.Size = new Size(91, 25);
            label10.TabIndex = 26;
            label10.Text = "Bolsones";
            // 
            // label_BCantidad
            // 
            label_BCantidad.AutoSize = true;
            label_BCantidad.BackColor = Color.Gold;
            label_BCantidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_BCantidad.Location = new Point(45, 362);
            label_BCantidad.Name = "label_BCantidad";
            label_BCantidad.Size = new Size(92, 25);
            label_BCantidad.TabIndex = 27;
            label_BCantidad.Text = "Cantidad";
            // 
            // label_Medida
            // 
            label_Medida.AutoSize = true;
            label_Medida.BackColor = Color.Gold;
            label_Medida.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Medida.Location = new Point(46, 292);
            label_Medida.Name = "label_Medida";
            label_Medida.Size = new Size(79, 25);
            label_Medida.TabIndex = 28;
            label_Medida.Text = "Medida";
            // 
            // textBox_Cantidad_Bolsones
            // 
            textBox_Cantidad_Bolsones.Location = new Point(156, 364);
            textBox_Cantidad_Bolsones.Name = "textBox_Cantidad_Bolsones";
            textBox_Cantidad_Bolsones.Size = new Size(121, 23);
            textBox_Cantidad_Bolsones.TabIndex = 7;
            // 
            // Form_ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(926, 509);
            Controls.Add(textBox_Cantidad_Bolsones);
            Controls.Add(label_Medida);
            Controls.Add(label_BCantidad);
            Controls.Add(label10);
            Controls.Add(comboBox_Bolsones);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTime_Venta);
            Controls.Add(label_fecha);
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
            Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label label_fecha;
        private DateTimePicker dateTime_Venta;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox_Bolsones;
        private Label label10;
        private Label label_BCantidad;
        private Label label_Medida;
        private TextBox textBox_Cantidad_Bolsones;
    }
}