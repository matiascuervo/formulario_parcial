﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace formulario_parcial
{
    public class RoundButton : Button
    {
        public RoundButton()
        {
            
            this.Width = 100;
            this.Height = 100;
            this.Padding = new Padding(0);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int cornerRadius = Math.Min(Width, Height); // Radio de las esquinas redondeadas
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
                this.Region = new Region(path);
            }

            
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillEllipse(brush, new Rectangle(0, 0, Width - 1, Height - 1));
            }

            
        }
    }
}