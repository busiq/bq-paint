using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using BQPaintNS.Addons;
using System.Diagnostics;

namespace BQPaintNS.Addons.Tools
{
    class TPencil : Tool
    {
        public TPencil() : base() {} // kontruktor, poki co czysty
        GraphicsPath gp = new GraphicsPath();
        private Point lastPoint;

        public void Draw(Pen pen, Graphics g)
        {
            gp.Widen(pen); //To coś daje
            gp.Flatten(); //To też :)
            g.DrawPath(pen, gp);
            gp.Reset();
        }

        public override void OnMouseDown(System.Windows.Forms.MouseEventArgs e, Workspace w)
        {
            base.OnMouseDown(e, w);
            lastPoint = MousePosition;
        }

        public override void OnMouseMove(System.Windows.Forms.MouseEventArgs e, Workspace w)
        {
            base.OnMouseMove(e, w);
            if (isDragging)
            {
                if (lastPoint != MousePosition)
                {
                    gp.AddLine(MousePosition, lastPoint);
                    lastPoint = MousePosition;
                    Draw(w.pen, w.graphics);
                }
            }
        }
    }
}
