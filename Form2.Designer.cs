namespace formulario_parcial
{
    partial class FormularioUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioUsuario));
            textBoxNombre = new TextBox();
            textBoxDNI = new TextBox();
            label_Nombre = new Label();
            label_DNI = new Label();
            Boton_login = new Button();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(273, 85);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Ingrese Su Nombre";
            textBoxNombre.Size = new Size(119, 23);
            textBoxNombre.TabIndex = 0;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(273, 172);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.PlaceholderText = "EJM:40832326";
            textBoxDNI.Size = new Size(119, 23);
            textBoxDNI.TabIndex = 1;
            textBoxDNI.TextChanged += textBoxDNI_TextChanged;
            // 
            // label_Nombre
            // 
            label_Nombre.AutoSize = true;
            label_Nombre.BackColor = Color.Gold;
            label_Nombre.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nombre.ForeColor = SystemColors.ControlText;
            label_Nombre.Location = new Point(145, 85);
            label_Nombre.Name = "label_Nombre";
            label_Nombre.Size = new Size(83, 23);
            label_Nombre.TabIndex = 2;
            label_Nombre.Text = "Nombre\r\n";
            label_Nombre.TextAlign = ContentAlignment.BottomLeft;
            label_Nombre.Click += label1_Click;
            // 
            // label_DNI
            // 
            label_DNI.AutoSize = true;
            label_DNI.BackColor = Color.Gold;
            label_DNI.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_DNI.Location = new Point(145, 172);
            label_DNI.Name = "label_DNI";
            label_DNI.Size = new Size(54, 23);
            label_DNI.TabIndex = 3;
            label_DNI.Text = "D.N.I\r\n";
            // 
            // Boton_login
            // 
            Boton_login.BackColor = SystemColors.HotTrack;
            Boton_login.FlatStyle = FlatStyle.System;
            Boton_login.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Boton_login.Location = new Point(209, 240);
            Boton_login.Name = "Boton_login";
            Boton_login.Size = new Size(105, 32);
            Boton_login.TabIndex = 4;
            Boton_login.Text = "Aceptar";
            Boton_login.UseVisualStyleBackColor = false;
            Boton_login.Click += Boton_login_Click;
            // 
            // FormularioUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(529, 284);
            Controls.Add(Boton_login);
            Controls.Add(label_DNI);
            Controls.Add(label_Nombre);
            Controls.Add(textBoxDNI);
            Controls.Add(textBoxNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioUsuario";
            Text = "VOLQUETES_POLY";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxDNI;
        private Label label_Nombre;
        private Label label_DNI;
        private Button Boton_login;
    }
}