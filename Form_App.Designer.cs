﻿namespace formulario_parcial
{
    partial class Form_alquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_alquiler));
            button_Ventas = new Button();
            button_Pedidos = new Button();
            Boton_Volver_App = new RoundButton();
            button_usuarios = new Button();
            pictureBox1 = new PictureBox();
            button_BaseDatos = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_Ventas
            // 
            button_Ventas.BackColor = Color.Gold;
            button_Ventas.FlatStyle = FlatStyle.Popup;
            button_Ventas.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Ventas.ForeColor = Color.Black;
            button_Ventas.Location = new Point(31, 130);
            button_Ventas.Name = "button_Ventas";
            button_Ventas.Size = new Size(145, 43);
            button_Ventas.TabIndex = 1;
            button_Ventas.Text = "Generar Pedidos";
            button_Ventas.UseVisualStyleBackColor = false;
            button_Ventas.Click += button_Ventas_Click;
            // 
            // button_Pedidos
            // 
            button_Pedidos.BackColor = Color.Gold;
            button_Pedidos.FlatStyle = FlatStyle.Popup;
            button_Pedidos.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Pedidos.Location = new Point(31, 281);
            button_Pedidos.Name = "button_Pedidos";
            button_Pedidos.Size = new Size(145, 43);
            button_Pedidos.TabIndex = 2;
            button_Pedidos.Text = "Mis Pédidos";
            button_Pedidos.UseVisualStyleBackColor = false;
            button_Pedidos.Click += button_Pedidos_Click;
            // 
            // Boton_Volver_App
            // 
            Boton_Volver_App.BackColor = Color.Transparent;
            Boton_Volver_App.FlatStyle = FlatStyle.Popup;
            Boton_Volver_App.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Boton_Volver_App.ForeColor = SystemColors.ActiveCaptionText;
            Boton_Volver_App.Location = new Point(31, 382);
            Boton_Volver_App.Name = "Boton_Volver_App";
            Boton_Volver_App.Size = new Size(57, 56);
            Boton_Volver_App.TabIndex = 7;
            Boton_Volver_App.Text = "↩";
            Boton_Volver_App.UseVisualStyleBackColor = false;
            Boton_Volver_App.Click += Boton_Volver_App_Click;
            // 
            // button_usuarios
            // 
            button_usuarios.BackColor = Color.CadetBlue;
            button_usuarios.FlatStyle = FlatStyle.Flat;
            button_usuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_usuarios.Location = new Point(629, 120);
            button_usuarios.Name = "button_usuarios";
            button_usuarios.Size = new Size(134, 43);
            button_usuarios.TabIndex = 8;
            button_usuarios.Text = "Usuarios";
            button_usuarios.UseVisualStyleBackColor = false;
            button_usuarios.Visible = false;
            button_usuarios.Click += button_usuarios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(182, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button_BaseDatos
            // 
            button_BaseDatos.BackColor = Color.CadetBlue;
            button_BaseDatos.FlatStyle = FlatStyle.Flat;
            button_BaseDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_BaseDatos.Location = new Point(629, 281);
            button_BaseDatos.Name = "button_BaseDatos";
            button_BaseDatos.Size = new Size(134, 43);
            button_BaseDatos.TabIndex = 11;
            button_BaseDatos.Text = "Base De Datos";
            button_BaseDatos.UseVisualStyleBackColor = false;
            button_BaseDatos.Visible = false;
            button_BaseDatos.Click += button1_Click;
            // 
            // Form_alquiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button_BaseDatos);
            Controls.Add(pictureBox1);
            Controls.Add(button_usuarios);
            Controls.Add(Boton_Volver_App);
            Controls.Add(button_Pedidos);
            Controls.Add(button_Ventas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_alquiler";
            Text = "VOLQUETES POLY";
            TransparencyKey = Color.Linen;
            Load += Form_alquiler_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button_Ventas;
        private Button button_Pedidos;
        private RoundButton Boton_Volver_App;
        private Button button_usuarios;
        private PictureBox pictureBox1;
        private Button button_BaseDatos;
    }
}