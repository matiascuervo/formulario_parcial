namespace formulario_parcial
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            textBox_Nombre_Registro = new TextBox();
            textBox_Contraseña_Registro = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Boton_registro = new Button();
            pictureBox1 = new PictureBox();
            Boton_Volver_Registro = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox_Nombre_Registro
            // 
            textBox_Nombre_Registro.Cursor = Cursors.IBeam;
            textBox_Nombre_Registro.Location = new Point(467, 135);
            textBox_Nombre_Registro.Name = "textBox_Nombre_Registro";
            textBox_Nombre_Registro.Size = new Size(100, 23);
            textBox_Nombre_Registro.TabIndex = 0;
            // 
            // textBox_Contraseña_Registro
            // 
            textBox_Contraseña_Registro.Cursor = Cursors.IBeam;
            textBox_Contraseña_Registro.ForeColor = SystemColors.WindowText;
            textBox_Contraseña_Registro.Location = new Point(467, 221);
            textBox_Contraseña_Registro.Name = "textBox_Contraseña_Registro";
            textBox_Contraseña_Registro.PasswordChar = '*';
            textBox_Contraseña_Registro.Size = new Size(100, 23);
            textBox_Contraseña_Registro.TabIndex = 1;
           
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(226, 135);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(226, 221);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // Boton_registro
            // 
            Boton_registro.BackColor = Color.Black;
            Boton_registro.Cursor = Cursors.Hand;
            Boton_registro.FlatStyle = FlatStyle.Popup;
            Boton_registro.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Boton_registro.ForeColor = Color.Red;
            Boton_registro.Location = new Point(226, 302);
            Boton_registro.Name = "Boton_registro";
            Boton_registro.Size = new Size(108, 46);
            Boton_registro.TabIndex = 4;
            Boton_registro.Text = "Registrarme";
            Boton_registro.UseVisualStyleBackColor = false;
            Boton_registro.Click += Boton_registro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(146, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(547, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Boton_Volver_Registro
            // 
            Boton_Volver_Registro.BackColor = Color.Transparent;
            Boton_Volver_Registro.FlatStyle = FlatStyle.Popup;
            Boton_Volver_Registro.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Boton_Volver_Registro.ForeColor = SystemColors.ActiveCaptionText;
            Boton_Volver_Registro.Location = new Point(742, 398);
            Boton_Volver_Registro.Name = "Boton_Volver_Registro";
            Boton_Volver_Registro.Size = new Size(57, 56);
            Boton_Volver_Registro.TabIndex = 6;
            Boton_Volver_Registro.Text = "↩";
            Boton_Volver_Registro.UseVisualStyleBackColor = false;
            Boton_Volver_Registro.Click += Boton_Volver_Registro_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Boton_Volver_Registro);
            Controls.Add(Boton_registro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Contraseña_Registro);
            Controls.Add(textBox_Nombre_Registro);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += Registro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Nombre_Registro;
        private TextBox textBox_Contraseña_Registro;
        private Label label1;
        private Label label2;
        private Button Boton_registro;
        private PictureBox pictureBox1;
        private RoundButton Boton_Volver_Registro;
    }
}