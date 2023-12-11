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
            textBox_Baja = new TextBox();
            Bonton_Baja = new Button();
            Boton_Reactivar_Usuario = new Button();
            textBox_Nuevo_Valor = new TextBox();
            Bonton_ModificarNombre = new Button();
            Bonton_ModificarContraseña = new Button();
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
            dataGridView_Usuarios.Size = new Size(442, 389);
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
            // textBox_Baja
            // 
            textBox_Baja.Location = new Point(476, 12);
            textBox_Baja.Name = "textBox_Baja";
            textBox_Baja.PlaceholderText = "Usuarios";
            textBox_Baja.Size = new Size(118, 23);
            textBox_Baja.TabIndex = 11;
            // 
            // Bonton_Baja
            // 
            Bonton_Baja.BackColor = Color.LightSkyBlue;
            Bonton_Baja.FlatStyle = FlatStyle.Flat;
            Bonton_Baja.Location = new Point(611, 11);
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
            Boton_Reactivar_Usuario.Location = new Point(611, 53);
            Boton_Reactivar_Usuario.Name = "Boton_Reactivar_Usuario";
            Boton_Reactivar_Usuario.Size = new Size(133, 23);
            Boton_Reactivar_Usuario.TabIndex = 13;
            Boton_Reactivar_Usuario.Text = "Reactivar Usuario";
            Boton_Reactivar_Usuario.UseVisualStyleBackColor = false;
            Boton_Reactivar_Usuario.Click += Boton_Reactivar_Usuario_Click;
            // 
            // textBox_Nuevo_Valor
            // 
            textBox_Nuevo_Valor.Location = new Point(476, 157);
            textBox_Nuevo_Valor.Name = "textBox_Nuevo_Valor";
            textBox_Nuevo_Valor.PlaceholderText = "Nombre/Contraseña";
            textBox_Nuevo_Valor.Size = new Size(118, 23);
            textBox_Nuevo_Valor.TabIndex = 14;
            // 
            // Bonton_ModificarNombre
            // 
            Bonton_ModificarNombre.BackColor = Color.LightSkyBlue;
            Bonton_ModificarNombre.FlatStyle = FlatStyle.Flat;
            Bonton_ModificarNombre.Location = new Point(611, 156);
            Bonton_ModificarNombre.Name = "Bonton_ModificarNombre";
            Bonton_ModificarNombre.Size = new Size(133, 23);
            Bonton_ModificarNombre.TabIndex = 15;
            Bonton_ModificarNombre.Text = "Modificar Nombre";
            Bonton_ModificarNombre.UseVisualStyleBackColor = false;
            Bonton_ModificarNombre.EnabledChanged += Bonton_ModificarNombre_Click;
            Bonton_ModificarNombre.Click += Bonton_ModificarNombre_Click;
            // 
            // Bonton_ModificarContraseña
            // 
            Bonton_ModificarContraseña.BackColor = Color.LightSkyBlue;
            Bonton_ModificarContraseña.FlatStyle = FlatStyle.Flat;
            Bonton_ModificarContraseña.Location = new Point(611, 196);
            Bonton_ModificarContraseña.Name = "Bonton_ModificarContraseña";
            Bonton_ModificarContraseña.Size = new Size(133, 23);
            Bonton_ModificarContraseña.TabIndex = 16;
            Bonton_ModificarContraseña.Text = "Modificar Contraseña";
            Bonton_ModificarContraseña.UseVisualStyleBackColor = false;
            Bonton_ModificarContraseña.EnabledChanged += Bonton_ModificarContraseña_Click;
            Bonton_ModificarContraseña.Click += Bonton_ModificarContraseña_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(Bonton_ModificarContraseña);
            Controls.Add(Bonton_ModificarNombre);
            Controls.Add(textBox_Nuevo_Valor);
            Controls.Add(Boton_Reactivar_Usuario);
            Controls.Add(Bonton_Baja);
            Controls.Add(textBox_Baja);
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
        private DataGridViewTextBoxColumn Columna_Usuario;
        private DataGridViewTextBoxColumn Columna_Contraseña;
        private DataGridViewTextBoxColumn Columna_Rol;
        private DataGridViewTextBoxColumn Columna_Estado;
        private TextBox textBox_Baja;
        private Button Bonton_Baja;
        private Button Boton_Reactivar_Usuario;
        private TextBox textBox_Nuevo_Valor;
        private Button Bonton_ModificarNombre;
        private Button Bonton_ModificarContraseña;
    }
}