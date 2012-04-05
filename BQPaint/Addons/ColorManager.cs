using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BQPaintNS.Addons
{
    class ColorManager
    {
        // Zwraca kolor 'przeciwny' podanemu
        static public Color GetNegative(Color c)
        {
           return Color.FromArgb((byte)~c.R, (byte)~c.G, (byte)~c.B);
        }

        // bardzo wolny filtr kolorow (nasycenie poszczegolnych składowych)
        //!: znowu unsafe i iteracje po wskaznikach by się chyba przydały
        static public Bitmap GetFiltered(Bitmap bmp,Color c, ProgressBar pb = null)
        {
            float r,g,b;
            for(int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color get = bmp.GetPixel(x, y);
                    r = (c.R > 0) ? (float)get.R * ((float)c.R / 255) : 0;
                    g = (c.G > 0) ? (float)get.G * ((float)c.G / 255) : 0;
                    b = (c.B > 0) ? (float)get.B * ((float)c.B / 255) : 0;
                    Color set = Color.FromArgb((int)r,(int)g,(int)b);
                    bmp.SetPixel(x, y, set);
                    if (pb != null)
                        pb.Increment(1);
                }
            }
            return bmp;
        }

    }
}
