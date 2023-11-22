namespace formulario_parcial
{
    partial class Form_inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_inicio));
            Boton_nombre = new Button();
            button_Registro = new Button();
            Label_Nombre_Inicio = new Label();
            SuspendLayout();
            // 
            // Boton_nombre
            // 
            Boton_nombre.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Boton_nombre.BackColor = SystemColors.Highlight;
            Boton_nombre.Cursor = Cursors.Hand;
            Boton_nombre.DialogResult = DialogResult.OK;
            Boton_nombre.FlatStyle = FlatStyle.Flat;
            Boton_nombre.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Boton_nombre.Location = new Point(65, 283);
            Boton_nombre.Name = "Boton_nombre";
            Boton_nombre.Size = new Size(117, 49);
            Boton_nombre.TabIndex = 1;
            Boton_nombre.Text = "Iniciar sesion ";
            Boton_nombre.UseVisualStyleBackColor = false;
            Boton_nombre.Click += button1_Click;
            // 
            // button_Registro
            // 
            button_Registro.BackColor = Color.Red;
            button_Registro.Cursor = Cursors.Hand;
            button_Registro.FlatStyle = FlatStyle.Flat;
            button_Registro.Font = new Font("Tahoma", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button_Registro.ForeColor = Color.Black;
            button_Registro.Location = new Point(364, 283);
            button_Registro.Name = "button_Registro";
            button_Registro.Size = new Size(127, 49);
            button_Registro.TabIndex = 0;
            button_Registro.Text = "Registrarse";
            button_Registro.UseVisualStyleBackColor = false;
            button_Registro.Click += button_Registro_Click;
            // 
            // Label_Nombre_Inicio
            // 
            Label_Nombre_Inicio.AutoSize = true;
            Label_Nombre_Inicio.BackColor = SystemColors.ActiveCaptionText;
            Label_Nombre_Inicio.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Nombre_Inicio.ForeColor = Color.Yellow;
            Label_Nombre_Inicio.Location = new Point(171, 43);
            Label_Nombre_Inicio.Name = "Label_Nombre_Inicio";
            Label_Nombre_Inicio.Size = new Size(203, 40);
            Label_Nombre_Inicio.TabIndex = 2;
            Label_Nombre_Inicio.Text = "Volquetes Poly";
            Label_Nombre_Inicio.Click += label1_Click;
            // 
            // Form_inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(536, 376);
            Controls.Add(Label_Nombre_Inicio);
            Controls.Add(button_Registro);
            Controls.Add(Boton_nombre);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_inicio";
            Text = "VOLQUETES_POLY";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Boton_nombre;
        private Button button_Registro;
        private Label Label_Nombre_Inicio;
    }
}