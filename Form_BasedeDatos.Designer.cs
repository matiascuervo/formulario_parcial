namespace formulario_parcial
{
    partial class Form_BasedeDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BasedeDatos));
            dataGridView1 = new DataGridView();
            Boton_Volver_BaseDeDatos = new RoundButton();
            comboBoxUsuarios = new ComboBox();
            textBoxNuevoValor = new TextBox();
            buttonConfirmar = new Button();
            textBoxValorActual = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(97, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(603, 300);
            dataGridView1.TabIndex = 1;
            // 
            // Boton_Volver_BaseDeDatos
            // 
            Boton_Volver_BaseDeDatos.BackColor = Color.Transparent;
            Boton_Volver_BaseDeDatos.FlatStyle = FlatStyle.Popup;
            Boton_Volver_BaseDeDatos.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Boton_Volver_BaseDeDatos.ForeColor = Color.Gold;
            Boton_Volver_BaseDeDatos.Location = new Point(12, 382);
            Boton_Volver_BaseDeDatos.Name = "Boton_Volver_BaseDeDatos";
            Boton_Volver_BaseDeDatos.Size = new Size(57, 56);
            Boton_Volver_BaseDeDatos.TabIndex = 8;
            Boton_Volver_BaseDeDatos.Text = "↩";
            Boton_Volver_BaseDeDatos.UseVisualStyleBackColor = false;
            Boton_Volver_BaseDeDatos.Click += Boton_Volver_BaseDeDatos_Click;
            // 
            // comboBoxUsuarios
            // 
            comboBoxUsuarios.FormattingEnabled = true;
            comboBoxUsuarios.Location = new Point(88, 327);
            comboBoxUsuarios.Name = "comboBoxUsuarios";
            comboBoxUsuarios.Size = new Size(121, 23);
            comboBoxUsuarios.TabIndex = 9;
            // 
            // textBoxNuevoValor
            // 
            textBoxNuevoValor.Location = new Point(441, 327);
            textBoxNuevoValor.Name = "textBoxNuevoValor";
            textBoxNuevoValor.Size = new Size(100, 23);
            textBoxNuevoValor.TabIndex = 10;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Location = new Point(453, 382);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(101, 27);
            buttonConfirmar.TabIndex = 11;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // textBoxValorActual
            // 
            textBoxValorActual.Location = new Point(276, 327);
            textBoxValorActual.Name = "textBoxValorActual";
            textBoxValorActual.Size = new Size(100, 23);
            textBoxValorActual.TabIndex = 12;
            // 
            // Form_BasedeDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxValorActual);
            Controls.Add(buttonConfirmar);
            Controls.Add(textBoxNuevoValor);
            Controls.Add(comboBoxUsuarios);
            Controls.Add(Boton_Volver_BaseDeDatos);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_BasedeDatos";
            Text = "BasedeDatos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private RoundButton Boton_Volver_BaseDeDatos;
        private ComboBox comboBoxUsuarios;
        private TextBox textBoxNuevoValor;
        private Button buttonConfirmar;
        private TextBox textBoxValorActual;
    }
}