using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BQPaintNS.Addons.Tools
{
    class TFreeShape : Tool
    {
        public TFreeShape()
            : base()
        {
        }

        private List<Point> points = new List<Point>();

        private void DrawPolygon(Workspace w)
        {
            if (w.ShapeFill)
                w.graphics.FillPolygon(w.brush, points.ToArray());
            else
                w.graphics.DrawPolygon(w.pen, points.ToArray());

            points.Clear();
        }

        public override void OnMouseDown(MouseEventArgs e, Workspace w)
        {
            base.OnMouseDown(e, w);
            if (isLeftBtn)
            {
                points.Add(ClickPoint);
                w.graphics.FillEllipse(w.brush, ClickPoint.X, ClickPoint.Y, 2, 2);
            }

            if (isRightBtn && points.Count > 1)
            {
                DrawPolygon(w);
            }
        }
        
    }
}
