namespace formulario_parcial
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            Boton_Volver_Usuarios = new RoundButton();
            dataGridView_Usuarios = new DataGridView();
            Columna_Usuario = new DataGridViewTextBoxColumn();
            Columna_Contraseña = new DataGridViewTextBoxColumn();
            Columna_Rol = new DataGridViewTextBoxColumn();
            Columna_Estado = new DataGridViewTextBoxColumn();
            Boton_Mostrar_Usuarios = new Button();
            textBox_Baja = new TextBox();
            Bonton_Baja = new Button();
            Boton_Reactivar_Usuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Usuarios).BeginInit();
            SuspendLayout();
            // 
            // Boton_Volver_Usuarios
            // 
            Boton_Volver_Usuarios.BackColor = Color.Transparent;
            Boton_Volver_Usuarios.FlatStyle = FlatStyle.Flat;
            Boton_Volver_Usuarios.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Boton_Volver_Usuarios.ForeColor = SystemColors.ActiveCaptionText;
            Boton_Volver_Usuarios.Location = new Point(0, 394);
            Boton_Volver_Usuarios.Name = "Boton_Volver_Usuarios";
            Boton_Volver_Usuarios.Size = new Size(57, 56);
            Boton_Volver_Usuarios.TabIndex = 8;
            Boton_Volver_Usuarios.Text = "↩";
            Boton_Volver_Usuarios.UseVisualStyleBackColor = false;
            Boton_Volver_Usuarios.Click += Boton_Volver_Usuarios_Click;
            // 
            // dataGridView_Usuarios
            // 
            dataGridView_Usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Usuarios.Columns.AddRange(new DataGridViewColumn[] { Columna_Usuario, Columna_Contraseña, Columna_Rol, Columna_Estado });
            dataGridView_Usuarios.Location = new Point(0, -1);
            dataGridView_Usuarios.Name = "dataGridView_Usuarios";
            dataGridView_Usuarios.RowTemplate.Height = 25;
            dataGridView_Usuarios.Size = new Size(443, 389);
            dataGridView_Usuarios.TabIndex = 9;
            // 
            // Columna_Usuario
            // 
            Columna_Usuario.HeaderText = "Usuario";
            Columna_Usuario.Name = "Columna_Usuario";
            // 
            // Columna_Contraseña
            // 
            Columna_Contraseña.HeaderText = "Contraseña";
            Columna_Contraseña.Name = "Columna_Contraseña";
            // 
            // Columna_Rol
            // 
            Columna_Rol.HeaderText = "Rol";
            Columna_Rol.Name = "Columna_Rol";
            // 
            // Columna_Estado
            // 
            Columna_Estado.HeaderText = "Estado";
            Columna_Estado.Name = "Columna_Estado";
            // 
            // Boton_Mostrar_Usuarios
            // 
            Boton_Mostrar_Usuarios.BackColor = Color.LightSkyBlue;
            Boton_Mostrar_Usuarios.FlatStyle = FlatStyle.Flat;
            Boton_Mostrar_Usuarios.Location = new Point(476, 12);
            Boton_Mostrar_Usuarios.Name = "Boton_Mostrar_Usuarios";
            Boton_Mostrar_Usuarios.Size = new Size(133, 23);
            Boton_Mostrar_Usuarios.TabIndex = 10;
            Boton_Mostrar_Usuarios.Text = "Mostrar usuarios";
            Boton_Mostrar_Usuarios.UseVisualStyleBackColor = false;
            
            // 
            // textBox_Baja
            // 
            textBox_Baja.Location = new Point(680, 69);
            textBox_Baja.Name = "textBox_Baja";
            textBox_Baja.PlaceholderText = "Usuarios";
            textBox_Baja.Size = new Size(108, 23);
            textBox_Baja.TabIndex = 11;
            // 
            // Bonton_Baja
            // 
            Bonton_Baja.BackColor = Color.LightSkyBlue;
            Bonton_Baja.FlatStyle = FlatStyle.Flat;
            Bonton_Baja.Location = new Point(476, 69);
            Bonton_Baja.Name = "Bonton_Baja";
            Bonton_Baja.Size = new Size(133, 23);
            Bonton_Baja.TabIndex = 12;
            Bonton_Baja.Text = "Dar De BaJa";
            Bonton_Baja.UseVisualStyleBackColor = false;
            Bonton_Baja.Click += Bonton_Baja_Click;
            // 
            // Boton_Reactivar_Usuario
            // 
            Boton_Reactivar_Usuario.BackColor = Color.LightSkyBlue;
            Boton_Reactivar_Usuario.FlatStyle = FlatStyle.Flat;
            Boton_Reactivar_Usuario.Location = new Point(476, 126);
            Boton_Reactivar_Usuario.Name = "Boton_Reactivar_Usuario";
            Boton_Reactivar_Usuario.Size = new Size(133, 23);
            Boton_Reactivar_Usuario.TabIndex = 13;
            Boton_Reactivar_Usuario.Text = "Reactivar Usuario";
            Boton_Reactivar_Usuario.UseVisualStyleBackColor = false;
            Boton_Reactivar_Usuario.Click += Boton_Reactivar_Usuario_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(Boton_Reactivar_Usuario);
            Controls.Add(Bonton_Baja);
            Controls.Add(textBox_Baja);
            Controls.Add(Boton_Mostrar_Usuarios);
            Controls.Add(Boton_Volver_Usuarios);
            Controls.Add(dataGridView_Usuarios);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Usuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Usuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundButton Boton_Volver_Usuarios;
        private DataGridView dataGridView_Usuarios;
        private Button Boton_Mostrar_Usuarios;
        private DataGridViewTextBoxColumn Columna_Usuario;
        private DataGridViewTextBoxColumn Columna_Contraseña;
        private DataGridViewTextBoxColumn Columna_Rol;
        private DataGridViewTextBoxColumn Columna_Estado;
        private TextBox textBox_Baja;
        private Button Bonton_Baja;
        private Button Boton_Reactivar_Usuario;
    }
}