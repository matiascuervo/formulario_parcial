﻿namespace formulario_parcial
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
            label_PrecioBolsaG = new Label();
            label_PrecioBolsaC = new Label();
            label_MedidaBolsaGrande = new Label();
            label_MedidaBolsaGChica = new Label();
            comboBox_Bolsones = new ComboBox();
            label_Bolsones = new Label();
            label_BCantidad = new Label();
            label_Medida = new Label();
            textBox_Cantidad_Bolsones = new TextBox();
            radioButton_Bolson = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(728, 73);
            label1.Name = "label1";
            label1.Size = new Size(149, 23);
            label1.TabIndex = 0;
            label1.Text = "Tipo De Volquete";
            // 
            // comboBox_ventas
            // 
            comboBox_ventas.FormattingEnabled = true;
            comboBox_ventas.Location = new Point(728, 115);
            comboBox_ventas.Name = "comboBox_ventas";
            comboBox_ventas.Size = new Size(121, 23);
            comboBox_ventas.TabIndex = 1;
            comboBox_ventas.SelectedIndexChanged += comboBox_ventas_SelectedIndexChanged;
            // 
            // textBox_Cantidad
            // 
            textBox_Cantidad.Location = new Point(728, 185);
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
            Label_Cantidad.Location = new Point(728, 157);
            Label_Cantidad.Name = "Label_Cantidad";
            Label_Cantidad.Size = new Size(92, 25);
            Label_Cantidad.TabIndex = 3;
            Label_Cantidad.Text = "Cantidad";
            // 
            // Button_Pedir
            // 
            Button_Pedir.BackColor = Color.Gold;
            Button_Pedir.FlatStyle = FlatStyle.Flat;
            Button_Pedir.Location = new Point(167, 397);
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
            pictureBox1.Location = new Point(296, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 268);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Boton_Volver_Ventas
            // 
            Boton_Volver_Ventas.BackColor = Color.Transparent;
            Boton_Volver_Ventas.FlatStyle = FlatStyle.Popup;
            Boton_Volver_Ventas.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Boton_Volver_Ventas.ForeColor = SystemColors.ActiveCaptionText;
            Boton_Volver_Ventas.Location = new Point(1, 411);
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
            label_Localidad.Location = new Point(1, 75);
            label_Localidad.Name = "label_Localidad";
            label_Localidad.Size = new Size(97, 25);
            label_Localidad.TabIndex = 8;
            label_Localidad.Text = "Localidad";
            // 
            // comboBox_Localidad
            // 
            comboBox_Localidad.FormattingEnabled = true;
            comboBox_Localidad.Location = new Point(167, 75);
            comboBox_Localidad.Name = "comboBox_Localidad";
            comboBox_Localidad.Size = new Size(121, 23);
            comboBox_Localidad.TabIndex = 2;
            // 
            // textBox_Nombre_Final
            // 
            textBox_Nombre_Final.Location = new Point(169, 191);
            textBox_Nombre_Final.Name = "textBox_Nombre_Final";
            textBox_Nombre_Final.Size = new Size(121, 23);
            textBox_Nombre_Final.TabIndex = 3;
            // 
            // label_Nombre_Final
            // 
            label_Nombre_Final.AutoSize = true;
            label_Nombre_Final.BackColor = Color.Gold;
            label_Nombre_Final.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nombre_Final.Location = new Point(1, 183);
            label_Nombre_Final.Name = "label_Nombre_Final";
            label_Nombre_Final.Size = new Size(75, 25);
            label_Nombre_Final.TabIndex = 11;
            label_Nombre_Final.Text = "Recibe ";
            // 
            // label_Dirrecion
            // 
            label_Dirrecion.AutoSize = true;
            label_Dirrecion.BackColor = Color.Gold;
            label_Dirrecion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Dirrecion.Location = new Point(2, 128);
            label_Dirrecion.Name = "label_Dirrecion";
            label_Dirrecion.Size = new Size(96, 25);
            label_Dirrecion.TabIndex = 12;
            label_Dirrecion.Text = "Direccion";
            // 
            // TextBox_Direccion
            // 
            TextBox_Direccion.Location = new Point(167, 133);
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
            label_fecha.Location = new Point(1, 257);
            label_fecha.Name = "label_fecha";
            label_fecha.Size = new Size(114, 20);
            label_fecha.TabIndex = 15;
            label_fecha.Text = "Fecha De Envio";
            // 
            // dateTime_Venta
            // 
            dateTime_Venta.Location = new Point(167, 255);
            dateTime_Venta.Name = "dateTime_Venta";
            dateTime_Venta.Size = new Size(156, 23);
            dateTime_Venta.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(326, 52);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 17;
            label3.Text = "$ 20.000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gold;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(545, 52);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 18;
            label4.Text = "$ 40.000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(430, 75);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 19;
            label5.Text = "Volquetes";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(391, 318);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label_PrecioBolsaG
            // 
            label_PrecioBolsaG.AutoSize = true;
            label_PrecioBolsaG.BackColor = Color.White;
            label_PrecioBolsaG.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_PrecioBolsaG.Location = new Point(391, 318);
            label_PrecioBolsaG.Name = "label_PrecioBolsaG";
            label_PrecioBolsaG.Size = new Size(64, 19);
            label_PrecioBolsaG.TabIndex = 21;
            label_PrecioBolsaG.Text = "$ 16.000";
            label_PrecioBolsaG.Visible = false;
            // 
            // label_PrecioBolsaC
            // 
            label_PrecioBolsaC.AutoSize = true;
            label_PrecioBolsaC.BackColor = Color.White;
            label_PrecioBolsaC.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_PrecioBolsaC.Location = new Point(502, 408);
            label_PrecioBolsaC.Name = "label_PrecioBolsaC";
            label_PrecioBolsaC.Size = new Size(64, 19);
            label_PrecioBolsaC.TabIndex = 22;
            label_PrecioBolsaC.Text = "$ 10.000";
            label_PrecioBolsaC.Visible = false;
            // 
            // label_MedidaBolsaGrande
            // 
            label_MedidaBolsaGrande.AutoSize = true;
            label_MedidaBolsaGrande.BackColor = Color.Gold;
            label_MedidaBolsaGrande.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_MedidaBolsaGrande.Location = new Point(391, 293);
            label_MedidaBolsaGrande.Name = "label_MedidaBolsaGrande";
            label_MedidaBolsaGrande.Size = new Size(51, 25);
            label_MedidaBolsaGrande.TabIndex = 23;
            label_MedidaBolsaGrande.Text = "2m3";
            label_MedidaBolsaGrande.Visible = false;
            // 
            // label_MedidaBolsaGChica
            // 
            label_MedidaBolsaGChica.AutoSize = true;
            label_MedidaBolsaGChica.BackColor = Color.Gold;
            label_MedidaBolsaGChica.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_MedidaBolsaGChica.Location = new Point(515, 427);
            label_MedidaBolsaGChica.Name = "label_MedidaBolsaGChica";
            label_MedidaBolsaGChica.Size = new Size(51, 25);
            label_MedidaBolsaGChica.TabIndex = 24;
            label_MedidaBolsaGChica.Text = "1m3";
            label_MedidaBolsaGChica.Visible = false;
            // 
            // comboBox_Bolsones
            // 
            comboBox_Bolsones.FormattingEnabled = true;
            comboBox_Bolsones.Location = new Point(728, 299);
            comboBox_Bolsones.Name = "comboBox_Bolsones";
            comboBox_Bolsones.Size = new Size(121, 23);
            comboBox_Bolsones.TabIndex = 6;
            comboBox_Bolsones.Visible = false;
            comboBox_Bolsones.SelectedIndexChanged += comboBox_BolsonesSelectedIndexChanged;
            // 
            // label_Bolsones
            // 
            label_Bolsones.AutoSize = true;
            label_Bolsones.BackColor = Color.Gold;
            label_Bolsones.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Bolsones.Location = new Point(729, 237);
            label_Bolsones.Name = "label_Bolsones";
            label_Bolsones.Size = new Size(91, 25);
            label_Bolsones.TabIndex = 26;
            label_Bolsones.Text = "Bolsones";
            label_Bolsones.Visible = false;
            // 
            // label_BCantidad
            // 
            label_BCantidad.AutoSize = true;
            label_BCantidad.BackColor = Color.Gold;
            label_BCantidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_BCantidad.Location = new Point(729, 325);
            label_BCantidad.Name = "label_BCantidad";
            label_BCantidad.Size = new Size(92, 25);
            label_BCantidad.TabIndex = 27;
            label_BCantidad.Text = "Cantidad";
            label_BCantidad.Visible = false;
            // 
            // label_Medida
            // 
            label_Medida.AutoSize = true;
            label_Medida.BackColor = Color.Gold;
            label_Medida.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Medida.Location = new Point(729, 271);
            label_Medida.Name = "label_Medida";
            label_Medida.Size = new Size(79, 25);
            label_Medida.TabIndex = 28;
            label_Medida.Text = "Medida";
            label_Medida.Visible = false;
            // 
            // textBox_Cantidad_Bolsones
            // 
            textBox_Cantidad_Bolsones.Location = new Point(728, 353);
            textBox_Cantidad_Bolsones.Name = "textBox_Cantidad_Bolsones";
            textBox_Cantidad_Bolsones.Size = new Size(121, 23);
            textBox_Cantidad_Bolsones.TabIndex = 7;
            textBox_Cantidad_Bolsones.Visible = false;
            textBox_Cantidad_Bolsones.TextChanged += textBox_Cantidad_BolsonestChanged;
            // 
            // radioButton_Bolson
            // 
            radioButton_Bolson.AutoSize = true;
            radioButton_Bolson.BackColor = Color.Gold;
            radioButton_Bolson.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton_Bolson.Location = new Point(608, 243);
            radioButton_Bolson.Name = "radioButton_Bolson";
            radioButton_Bolson.Size = new Size(110, 19);
            radioButton_Bolson.TabIndex = 31;
            radioButton_Bolson.TabStop = true;
            radioButton_Bolson.Text = "Agregar Bolson";
            radioButton_Bolson.UseVisualStyleBackColor = false;
            radioButton_Bolson.CheckedChanged += radioButton_Bolson_CheckedChanged;
            // 
            // Form_ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(954, 514);
            Controls.Add(radioButton_Bolson);
            Controls.Add(textBox_Cantidad_Bolsones);
            Controls.Add(label_Medida);
            Controls.Add(label_BCantidad);
            Controls.Add(label_Bolsones);
            Controls.Add(comboBox_Bolsones);
            Controls.Add(label_MedidaBolsaGChica);
            Controls.Add(label_MedidaBolsaGrande);
            Controls.Add(label_PrecioBolsaC);
            Controls.Add(label_PrecioBolsaG);
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
        private Label label_PrecioBolsaG;
        private Label label_PrecioBolsaC;
        private Label label_MedidaBolsaGrande;
        private Label label_MedidaBolsaGChica;
        private ComboBox comboBox_Bolsones;
        private Label label_Bolsones;
        private Label label_BCantidad;
        private Label label_Medida;
        private TextBox textBox_Cantidad_Bolsones;
        private CheckBox checkBox_Bolsones;
        private RadioButton radioButton_Bolson;
    }
}