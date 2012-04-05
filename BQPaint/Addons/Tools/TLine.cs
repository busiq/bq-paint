using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BQPaintNS.Addons.Tools
{
    class TLine : Tool
    {

        public TLine() : base() 
        {
        }

        private void DrawPseudo(Workspace w, Point start, Point end)
        {
            w.graphics.Clear(Color.Transparent);
            w.graphics.DrawImage(w.temp, 0, 0);
            w.graphics.DrawLine(w.pen, start, end);
        }

        public override void OnMouseUp(MouseEventArgs e, Workspace w)
        {
            base.OnMouseUp(e, w);
            w.graphics.DrawLine(w.pen, ClickPoint, MousePosition);
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
