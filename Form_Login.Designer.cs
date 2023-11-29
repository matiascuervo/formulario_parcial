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
            Boton_login = new Button();
            Boton_Atras_Login = new RoundButton();
            roundButton1 = new RoundButton();
            roundButton2 = new RoundButton();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(209, 92);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Ingrese Su Usuario";
            textBoxNombre.Size = new Size(119, 23);
            textBoxNombre.TabIndex = 0;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(209, 172);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.PlaceholderText = "******";
            textBoxDNI.Size = new Size(119, 23);
            textBoxDNI.TabIndex = 1;
            textBoxDNI.UseSystemPasswordChar = true;
            textBoxDNI.TextChanged += textBoxDNI_TextChanged;
            // 
            // Boton_login
            // 
            Boton_login.BackColor = Color.Gold;
            Boton_login.FlatStyle = FlatStyle.Popup;
            Boton_login.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Boton_login.Location = new Point(209, 240);
            Boton_login.Name = "Boton_login";
            Boton_login.Size = new Size(105, 32);
            Boton_login.TabIndex = 4;
            Boton_login.Text = "Aceptar";
            Boton_login.UseVisualStyleBackColor = false;
            Boton_login.Click += Boton_login_Click;
            // 
            // Boton_Atras_Login
            // 
            Boton_Atras_Login.BackColor = Color.Transparent;
            Boton_Atras_Login.FlatStyle = FlatStyle.Popup;
            Boton_Atras_Login.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            Boton_Atras_Login.Location = new Point(12, 228);
            Boton_Atras_Login.Name = "Boton_Atras_Login";
            Boton_Atras_Login.Size = new Size(68, 58);
            Boton_Atras_Login.TabIndex = 5;
            Boton_Atras_Login.Text = "↩";
            Boton_Atras_Login.UseVisualStyleBackColor = false;
            Boton_Atras_Login.Click += Boton_Atras_Login_Click;
            // 
            // roundButton1
            // 
            roundButton1.BackColor = Color.Transparent;
            roundButton1.BackgroundImage = (Image)resources.GetObject("roundButton1.BackgroundImage");
            roundButton1.BackgroundImageLayout = ImageLayout.Stretch;
            roundButton1.FlatStyle = FlatStyle.Popup;
            roundButton1.Location = new Point(105, 76);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(47, 39);
            roundButton1.TabIndex = 11;
            roundButton1.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            roundButton2.BackColor = Color.Transparent;
            roundButton2.BackgroundImage = (Image)resources.GetObject("roundButton2.BackgroundImage");
            roundButton2.BackgroundImageLayout = ImageLayout.Stretch;
            roundButton2.FlatStyle = FlatStyle.Popup;
            roundButton2.Location = new Point(105, 162);
            roundButton2.Name = "roundButton2";
            roundButton2.Size = new Size(42, 40);
            roundButton2.TabIndex = 12;
            roundButton2.UseVisualStyleBackColor = false;
            // 
            // FormularioUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(529, 284);
            Controls.Add(roundButton2);
            Controls.Add(roundButton1);
            Controls.Add(Boton_Atras_Login);
            Controls.Add(Boton_login);
            Controls.Add(textBoxDNI);
            Controls.Add(textBoxNombre);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioUsuario";
            Text = "Login";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxDNI;
        private Button Boton_login;
        private RoundButton Boton_Atras_Login;
        private RoundButton roundButton1;
        private RoundButton roundButton2;
    }
}