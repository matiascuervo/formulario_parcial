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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Boton_nombre = new Button();
            SuspendLayout();
            // 
            // Boton_nombre
            // 
            Boton_nombre.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Boton_nombre.BackColor = SystemColors.HighlightText;
            Boton_nombre.DialogResult = DialogResult.OK;
            Boton_nombre.FlatStyle = FlatStyle.System;
            Boton_nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Boton_nombre.Location = new Point(194, 276);
            Boton_nombre.Name = "Boton_nombre";
            Boton_nombre.Size = new Size(127, 49);
            Boton_nombre.TabIndex = 0;
            Boton_nombre.Text = "Iniciar sesion ";
            Boton_nombre.UseVisualStyleBackColor = false;
            Boton_nombre.Click += button1_Click;
            // 
            // Form_inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(536, 376);
            Controls.Add(Boton_nombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_inicio";
            Text = "VOLQUETES_POLY";
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Boton_nombre;
    }
}