using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BQPaintNS.Addons.Tools
{
    class TShape : Tool
    {

        public TShape()
            : base()
        {
        }

        // Zwraca Recta ktory jest w stanie podarzac za mysza
        private Rectangle GetRect(Point p1, Point p2)
        {
            Rectangle rect = new Rectangle();
            if (p1.X < p2.X)
            {
                rect.X = p1.X;
                rect.Width = p2.X - p1.X;
            }
            else
            {
                rect.X = p2.X;
                rect.Width = p1.X - p2.X;
            }
            if (p1.Y < p2.Y)
            {
                rect.Y = p1.Y;
                rect.Height = p2.Y - p1.Y;
            }
            else
            {
                rect.Y = p2.Y;
                rect.Height = p1.Y - p2.Y;
            }

            return rect;
        }

        private void DrawShape(Workspace w)
        {
            if (w.SelectedShape == (int)Shapes.SRectangle)
            {
                if (w.ShapeFill)
                    w.graphics.FillRectangle(w.brush, GetRect(ClickPoint, MousePosition));
                else
                    w.graphics.DrawRectangle(w.pen, GetRect(ClickPoint, MousePosition));
            }

            if (w.SelectedShape == (int)Shapes.SElipse)
            {
                if (w.ShapeFill)
                    w.graphics.FillEllipse(w.brush, GetRect(ClickPoint, MousePosition));
                else
                    w.graphics.DrawEllipse(w.pen, GetRect(ClickPoint, MousePosition));
            }
        }

        private void DrawPseudo(Workspace w, Point start, Point end)
        {
            w.graphics.Clear(Color.Transparent);
            w.graphics.DrawImage(w.temp, 0, 0);
            DrawShape(w);
        }

        public override void OnMouseUp(MouseEventArgs e, Workspace w)
        {
            base.OnMouseUp(e, w);
            DrawShape(w);
        }

        public override void OnMouseMove(MouseEventArgs e, Workspace w)
        {
            base.OnMouseMove(e, w);
            if (isDragging)
            {
                DrawPseudo(w, ClickPoint, MousePosition);
            }
        }

    }
}
