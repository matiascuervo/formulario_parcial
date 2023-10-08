namespace formulario_parcial
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
            Boton_alquiler = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Boton_alquiler
            // 
            Boton_alquiler.BackColor = SystemColors.ControlLight;
            Boton_alquiler.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Boton_alquiler.Location = new Point(31, 117);
            Boton_alquiler.Name = "Boton_alquiler";
            Boton_alquiler.Size = new Size(145, 44);
            Boton_alquiler.TabIndex = 0;
            Boton_alquiler.Text = "Alquiler";
            Boton_alquiler.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(31, 198);
            button2.Name = "button2";
            button2.Size = new Size(145, 43);
            button2.TabIndex = 1;
            button2.Text = "Ventas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(31, 281);
            button3.Name = "button3";
            button3.Size = new Size(145, 43);
            button3.TabIndex = 2;
            button3.Text = "Pédidos";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form_alquiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Boton_alquiler);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_alquiler";
            Text = "VOLQUETES_POLY";
            ResumeLayout(false);
        }

        #endregion

        private Button Boton_alquiler;
        private Button button2;
        private Button button3;
    }
}