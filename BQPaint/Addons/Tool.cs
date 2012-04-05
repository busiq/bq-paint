using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BQPaintNS.Addons
{
    class Tool
    {
        // przygotowany konstruktor jakbym coś kiedyś zmienić chciał
        public Tool() {}

        protected Point MousePosition;
        protected Point ClickPoint;
        protected bool isLeftBtn, isRightBtn, isDragging;

        public virtual void Update(MouseEventArgs M)
        {
            MousePosition = M.Location;
        }

        public virtual void OnMouseMove(MouseEventArgs e, Workspace w)
        {
            Update(e);
        }

        public virtual void OnMouseUp(MouseEventArgs e, Workspace w)
        {
            isDragging = false;
        }

        public virtual void OnMouseDown(MouseEventArgs e, Workspace w)
        {
            ClickPoint = e.Location; // miejsce kliknięcia

            //sprawdzanie klawiszy
            isRightBtn = (e.Button == MouseButtons.Right) ? true : false;
            isLeftBtn = (e.Button == MouseButtons.Left) ? true : false;
            isDragging = true;

            // wygladzanie
            w.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //Update pozycji myszy
            Update(e);
        }
    }
}
