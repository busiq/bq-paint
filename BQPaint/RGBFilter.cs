using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace BQPaintNS
{
    public partial class RGBFilter : Form
    {
        public bool ThumbnailCallback()
        {
            return false;
        }
        private Image copy;
        private BQPaint f;

        public RGBFilter(BQPaint f)
        {
            InitializeComponent();
            this.f = f;
            Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);

            copy = f.main_bitmap.GetThumbnailImage(120, 120, myCallback, IntPtr.Zero);
            thumbnail.Image = copy;
        }

        private void ReDraw()
        {
            thumbnail.Image = Addons.ColorManager.GetFiltered(new Bitmap(copy), 
                Color.FromArgb((int)redNC.Value, (int)greenNC.Value, (int)blueNC.Value));
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jesteś pewien? Zastosowanie filtra złączy istniejące warstwy w jedną. Procesu tego nie można odwrócić!", "pytanie", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                progressBar1.Maximum = f.main_bitmap.Height * f.main_bitmap.Width;
                progressBar1.Show();
                f.main_bitmap = Addons.ColorManager.GetFiltered(f.main_bitmap,
                    Color.FromArgb((int)redNC.Value, (int)greenNC.Value, (int)blueNC.Value),
                    progressBar1);
                Bitmap copy = new Bitmap(f.main_bitmap);
                f.CreateWorkspace(copy.Width, copy.Height, null);
                f.layers_list.Items[f.workspace.SelectedLayer].Tag = copy;
                f.ReDraw();

                if (progressBar1.Value == progressBar1.Maximum)
                    Close();
            }
        }

        private void colorTB_ValueChanged(object sender, EventArgs e)
        {
            redNC.Value = redTB.Value;
            greenNC.Value = greenTB.Value;
            blueNC.Value = blueTB.Value;
        }

        private void colorNC_ValueChanged(object sender, EventArgs e)
        {
            redTB.Value = (int)redNC.Value;
            greenTB.Value = (int)greenNC.Value;
            blueTB.Value = (int)blueNC.Value;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void colorTB_MouseUp(object sender, MouseEventArgs e)
        {
            ReDraw();
        }

        private void colorNC_Validated(object sender, EventArgs e)
        {
            ReDraw();
        }
    }
}
