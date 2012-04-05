using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace BQPaintNS.Addons.Tools
{
    class TFill : Tool
    {
        public TFill()
            : base()
        {
        }
        /* Kod pochodzi z
         * http://social.msdn.microsoft.com/Forums/en-NZ/csharplanguage/thread/9d926a16-0051-4ca3-b77c-8095fb489ae2
         * Rozumiem jak działa ale samemu bym chyba dzień na tym stracił
         * tym bardziej że nie wiedziałem o istnieniu Marshala i BitmapData
         */
        void FloodFill(Bitmap bitmap, int x, int y, Color color)
        {
            BitmapData data = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int[] bits = new int[data.Stride / 4 * data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);

            LinkedList<Point> check = new LinkedList<Point>();
            int floodTo = color.ToArgb();
            int floodFrom = bits[x + y * data.Stride / 4];
            bits[x + y * data.Stride / 4] = floodTo;

            if (floodFrom != floodTo)
            {
                check.AddLast(new Point(x, y));
                while (check.Count > 0)
                {
                    Point cur = check.First.Value;
                    check.RemoveFirst();

                    foreach (Point off in new Point[] {
                new Point(0, -1), new Point(0, 1), 
                new Point(-1, 0), new Point(1, 0)})
                    {
                        Point next = new Point(cur.X + off.X, cur.Y + off.Y);
                        if (next.X >= 0 && next.Y >= 0 &&
                            next.X < data.Width &&
                            next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride / 4] == floodFrom)
                            {
                                check.AddLast(next);
                                bits[next.X + next.Y * data.Stride / 4] = floodTo;
                            }
                        }
                    }
                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            bitmap.UnlockBits(data);
        }

        public override void OnMouseDown(System.Windows.Forms.MouseEventArgs e, Workspace w)
        {
            base.OnMouseDown(e, w);
            FloodFill(w.temp, ClickPoint.X, ClickPoint.Y, w.color);
            w.graphics.Clear(Color.Transparent);
            w.graphics.DrawImage(w.temp,0,0);
        }

    }
}
