using System.Drawing;

namespace BQPaintNS
{
    // Strukturka opisująca workspace
    // !: dziwnie to w szarpie wyglada,wszedobylska obiektowosc,pomysleć o zmianie
    public struct Workspace
    {
        public string Name;
        public int Height, Width, SelectedLayer, SelectedTool, SelectedShape;
        public bool ShapeFill;
        public Color color;
        public SolidBrush brush;
        public Pen pen;
        public Graphics graphics;
        public Bitmap temp; // dla narzedzi TLine i TRect...
    }
}