using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;

using BQPaintNS.Addons;
/* 
 * Copyright © 2011 by BuSiQ
 * DO NOT DISTRIBUTE (bo chłam... [słaba znajomość szarpa + 0 dotNeta])
 * Zlepek funkcji, który działa, ale jest jak lektura z polskiego.
 * Prawdopodobnie są wycieki pamięci, nie testowałem pod tym kątem a nie ufam jakoś GC :P
 * www.BuSiQ.eu  
*/

namespace BQPaintNS
{      
    public partial class BQPaint : Form
    {
        public Bitmap main_bitmap;
        Graphics g;

        public Workspace workspace;
        // lista narzędzi
        List<Tool> tools = new List<Tool>();

        public BQPaint()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            splitContainer1.SplitterDistance = 700;
            this.DoubleBuffered = true;
            layers_list_SelectedIndexChanged(null, null);
            workspace.brush = new SolidBrush(Color.Black);
            workspace.pen = new Pen(Color.Black);
            SetColor(Color.FromArgb(0, 0, 0));

            //!: WTF?! enum nie da sie wstawić 'na czysto' jako int -.- <3 ansi c
            tools.Insert((int)PaintTools.TPencil, new Addons.Tools.TPencil());
            tools.Insert((int)PaintTools.TLine, new Addons.Tools.TLine());
            tools.Insert((int)PaintTools.TShape, new Addons.Tools.TShape());
            tools.Insert((int)PaintTools.TFreeShape, new Addons.Tools.TFreeShape());
            tools.Insert((int)PaintTools.TFill, new Addons.Tools.TFill());
        }

        //Dodaje wiadomość do status baru
        private void AddMessage(string msg)
        {
            status_txt.Text = msg;
            status_timer.Enabled = true;
        }

        private void status_timer_Tick(object sender, EventArgs e)
        {
            status_txt.Text = "";
            status_timer.Enabled = false;
        }

        // Odznacza narzedzia
        //!: by jedno zaznaczyc, no-sense, ale działa.
        private void SelectTool(object sender)
        {
            foreach (ToolStripItem ctrl in toolStrip1.Items)
            {
                if (ctrl.GetType().ToString() == "System.Windows.Forms.ToolStripButton")
                {
                    (ctrl as ToolStripButton).CheckState = CheckState.Unchecked;
                }
            }
            (sender as ToolStripButton).CheckState = CheckState.Checked;
            tool_txt.Text = "Wybrane narzędzie: " + (sender as ToolStripButton).Text;
        }

        // Skleja bitmapy z warstw
        // !: działa cholernie wolno, pomyśl nad poprawką
        // !!: coś z unsafe gdzies w necie było, przejrzyj.
        public bool MergeLayers()
        {
            g.Clear(Color.Transparent);
            for (int x = layers_list.Items.Count - 1; x >= 0; x--)
            {
                if (layers_list.Items[x].Checked)
                {
                    g.DrawImage((layers_list.Items[x].Tag as Bitmap), 0, 0);
                }
            }
            return true;
        }

        public void ReDraw()
        {
            if (MergeLayers())
            {
                picture.Image = main_bitmap;
                picture.Refresh();
            }
        }

        // Tworzy workspace [szerokosc,wysokosc,nazwa]
        public void CreateWorkspace(int width, int height, string name)
        {
            if (layers_list.Items.Count > 0)
                DeleteAllLayersBMP();

            // Główna bitmapa [scalajaca]
            main_bitmap = new Bitmap(width, height);
            workspace.temp = new Bitmap(width, height);
            layers_list.Clear();

            // Ustalanie wielkości obrazka
            picture.Height = height;
            workspace.Height = height;
            picture.Width = width;
            workspace.Width = width;

            // zabawa z nazwą
            workspace.Name = name;
            Text = "BQPaint - " + name;

            // Tworzenie czystej warstwy [1]
            ListViewItem li = new ListViewItem("Warstwa 1");
            li.Checked = true;
            li.Selected = true;
            Bitmap bmp = new Bitmap(width, height);
            workspace.graphics = Graphics.FromImage(bmp);
            workspace.graphics.Clear(Color.White);
            li.Tag = bmp;

            g = Graphics.FromImage(main_bitmap);

            //Przypisanie glownej bitmapy
            picture.Image = main_bitmap;
            layers_list.Items.Add(li);
            ReDraw();
            picture.Show();
            add_layer_btn.Enabled = true;
            tool_pencil_btn_Click(tool_pencil_btn, null);
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!picture.Visible)
            {
                new_file_window nfw = new new_file_window(this);
                nfw.ShowDialog();
            }
            else
            {
                if (MessageBox.Show("Czy chcesz nadpisać istniejący obraz?", "Pytanko", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    new_file_window nfw = new new_file_window(this);
                    nfw.ShowDialog();
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_programie op = new o_programie();
            op.ShowDialog();
        }

        private void layers_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (layers_list.SelectedIndices.Count > 0)
            {
                delete_layer_btn.Enabled = true;
                layer_hide_btn.Enabled = true;
                layer_up_btn.Enabled = true;
                layer_down_btn.Enabled = true;

                if (layers_list.SelectedIndices[0] == 0)
                {
                    layer_up_btn.Enabled = false;
                }

                if (layers_list.SelectedIndices[0] == layers_list.Items.Count - 1)
                {
                    layer_down_btn.Enabled = false;
                }

                workspace.SelectedLayer = layers_list.SelectedIndices[0];
                selected_layer_txt.Text = string.Format("Wybrana warstwa: {0}", layers_list.Items[workspace.SelectedLayer].Text);
                
            }
            else
            {
                delete_layer_btn.Enabled = false;
                layer_hide_btn.Enabled = false;
                layer_up_btn.Enabled = false;
                layer_down_btn.Enabled = false;
            }

            if (layers_list.Items.Count == 1)
            {
                delete_layer_btn.Enabled = false;
                layer_hide_btn.Enabled = false;
            }

        }

        private void add_layer_btn_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem(string.Format("Warstwa {0}", layers_list.Items.Count + 1));
            li.Checked = true;
            li.Selected = true;
            li.Tag = new Bitmap(workspace.Width, workspace.Height);
            // Chyba tak lepiej, dodaje warstwę na górę listy.
            layers_list.Items.Insert(0, li);
            //layers_list.Items.Add(li);
            ReDraw();
        }

        //!: anty-leak pamieci przy tworzeniu nowego workspace
        private void DeleteAllLayersBMP()
        {
            main_bitmap.Dispose();
            foreach (ListViewItem item in layers_list.Items)
            {
                using (Bitmap bmp = item.Tag as Bitmap)
                {
                    bmp.Dispose();
                }
            }
            
        }

        private void delete_layer_btn_Click(object sender, EventArgs e)
        {
            // Usunięcie bitmapy z pamięci (nie wierzę GC niestety ;P)
            // !: ehh, skubane nawyki z C i tęsknota za wskaznikami.
            using (Bitmap bmp = layers_list.Items[layers_list.SelectedIndices[0]].Tag as Bitmap)
            {
                bmp.Dispose();
            }
            // Usunięci wpisu z listy warstw
            layers_list.Items.RemoveAt(layers_list.SelectedItems[0].Index);


            if (workspace.SelectedLayer != 0)
                layers_list.Items[workspace.SelectedLayer - 1].Selected = true;
            else
                layers_list.Items[layers_list.Items.Count - 1].Selected = true;

            ReDraw();
        }

        private void layer_hide_btn_Click(object sender, EventArgs e)
        {
            if (layers_list.SelectedItems[0].Checked)
                layers_list.SelectedItems[0].Checked = false;
            else
                layers_list.SelectedItems[0].Checked = true;

            ReDraw();
        }

        // Swap dla listy warstw (gora/dol)
        private void layer_list_move(string where)
        {
            int id;
            if (where == "up")
                id = layers_list.SelectedIndices[0] - 1;
            else
                id = layers_list.SelectedIndices[0] + 1;

            ListViewItem temp = layers_list.Items[id];

            layers_list.Items[id] = layers_list.SelectedItems[0].Clone() as ListViewItem;
            layers_list.Items[layers_list.SelectedIndices[0]] = temp;
            layers_list.Items[id].Selected = true;
            ReDraw();
        }

        private void layer_up_btn_Click(object sender, EventArgs e)
        {
            layer_list_move("up");
        }

        private void layer_down_btn_Click(object sender, EventArgs e)
        {
            layer_list_move("down");
        }

        private void SetColor(Color c)
        {
            color_box.ForeColor = ColorManager.GetNegative(c);
            color_box.BackColor = c;
            workspace.color = c;
            workspace.brush.Color = c;
            workspace.pen.Color = c;
        }

        // umożliwia wybieranie z wartości htmlowych koloru
        private void color_box_TextChanged(object sender, EventArgs e)
        {
            if (color_box.Text.Length == 7)
            {
                try
                {
                    SetColor(ColorTranslator.FromHtml(color_box.Text));
                }
                catch { }
            }
        }

        private void color_btn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SetColor(cd.Color);
                color_box.Text = ColorTranslator.ToHtml(cd.Color).ToString();
            }
        }

        private void layers_list_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_position_txt.Text = String.Format("X: {0}; Y: {1}", e.X, e.Y);
            tools[workspace.SelectedTool].OnMouseMove(e, workspace);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                ReDraw();
        }

        private void picture_MouseLeave(object sender, EventArgs e)
        {
            mouse_position_txt.Text = "Poza obszarem roboczym";
        }


        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            workspace.graphics = Graphics.FromImage(layers_list.SelectedItems[0].Tag as Bitmap);
            // myk dla TLine, TShape & TFill
            if (workspace.SelectedTool == (int)PaintTools.TShape || workspace.SelectedTool == (int)PaintTools.TLine ||
                workspace.SelectedTool == (int)PaintTools.TFill)
                workspace.temp = new Bitmap(layers_list.SelectedItems[0].Tag as Bitmap);
            tools[workspace.SelectedTool].OnMouseDown(e,workspace);
            ReDraw();
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            // tak samo myk dla TLine, TShape & TFill
            if (workspace.SelectedTool == (int)PaintTools.TShape || workspace.SelectedTool == (int)PaintTools.TLine ||
                workspace.SelectedTool == (int)PaintTools.TFill) 
                workspace.temp.Dispose();

            tools[workspace.SelectedTool].OnMouseUp(e,workspace);
            ReDraw();
        }

        private void toolStripNC_ValueChanged(object sender, EventArgs e)
        {
            workspace.pen.Width = (float)toolStripNC.NumericUpDownControl.Value;
        }

        private void tool_pencil_btn_Click(object sender, EventArgs e)
        {
            SelectTool(sender);
            workspace.SelectedTool = (int)PaintTools.TPencil;
        }

        private void tool_line_btn_Click(object sender, EventArgs e)
        {
            SelectTool(sender);
            workspace.SelectedTool = (int)PaintTools.TLine;
        }

        private void tool_shape_btn_Click(object sender, EventArgs e)
        {
            SelectTool(sender);
            workspace.SelectedTool = (int)PaintTools.TShape;
        }

        private void tool_fill_btn_Click(object sender, EventArgs e)
        {
            SelectTool(sender);
            workspace.SelectedTool = (int)PaintTools.TFill;
        }

        private void kwadratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Image = (sender as ToolStripMenuItem).Image;
            workspace.SelectedShape = (int)Shapes.SRectangle;
            SelectTool(tool_shape_btn);
            workspace.SelectedTool = (int)PaintTools.TShape;
        }

        private void trójkatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Image = (sender as ToolStripMenuItem).Image;
            SelectTool(tool_shape_btn);
            workspace.SelectedTool = (int)PaintTools.TFreeShape;
        }

        private void elipsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Image = (sender as ToolStripMenuItem).Image;
            workspace.SelectedShape = (int)Shapes.SElipse;
            SelectTool(tool_shape_btn);
            workspace.SelectedTool = (int)PaintTools.TShape;
        }

        private void toolStripCC_Click(object sender, EventArgs e)
        {
            workspace.ShapeFill = toolStripCC.CheckBoxControl.Checked;
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!picture.Visible)
            {
                Application.Exit();
            }
            else
            {
                if (MessageBox.Show("Na pewno zamknąć program?", "Pytanko", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void OpenFile()
        {
            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Bitmap bitmap = new Bitmap(openDialog.FileName);
                    CreateWorkspace(bitmap.Width, bitmap.Height, openDialog.FileName);
                    using (Graphics graph = Graphics.FromImage(layers_list.Items[workspace.SelectedLayer].Tag as Bitmap))
                    {
                        graph.DrawImage(bitmap, 0, 0);
                    }
                    ReDraw();
                }
                catch (Exception)
                {
                    MessageBox.Show("Niestety nie udało mi się otworzyć takiego formatu");
                }
                 
            }
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!picture.Visible)
            {
                OpenFile();
            }
            else
            {
                if (MessageBox.Show("Otwarcie pliku usunie aktualny obszar roboczy, chcesz kontynuować?", "Pytanko", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    OpenFile();
                }
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picture.Visible&&saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    ReDraw();
                    string a = System.IO.Path.GetExtension(saveDialog.FileName);
                    switch (a.ToLower())
                    {
                        case ".bmp": main_bitmap.Save(saveDialog.FileName, ImageFormat.Bmp);
                            break;
                        case ".png": main_bitmap.Save(saveDialog.FileName, ImageFormat.Png);
                            break;
                        case ".jpg": main_bitmap.Save(saveDialog.FileName, ImageFormat.Jpeg);
                            break;
                        case ".gif": main_bitmap.Save(saveDialog.FileName, ImageFormat.Gif);
                            break;
                        default: throw new Exception("Baranek nie wybrał rozszerzenia");
                    }
                    MessageBox.Show("Plik zapisany!");
                }
                catch (Exception ee) { MessageBox.Show(ee.Message); }
                
            }
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picture.Visible)
            {
                RGBFilter rgb = new RGBFilter(this);
                rgb.ShowDialog();
            }
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picture.Visible)
                if (Clipboard.ContainsImage())
                {
                    using(Graphics graph = Graphics.FromImage(layers_list.Items[workspace.SelectedLayer].Tag as Bitmap))
                    {
                        graph.DrawImage(Clipboard.GetImage(), 0, 0);
                        ReDraw();
                    }
                }
                else
                    MessageBox.Show("Niestety, w schowku nie znajduje się żaden obraz.");
            else
                MessageBox.Show("Utwórz najpierw obszar roboczy, by móc cokolwiek wklejać!");
        }

        private void warstwęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picture.Visible)
            {
                Clipboard.SetImage(layers_list.Items[workspace.SelectedLayer].Tag as Bitmap);
                AddMessage("Skopiowano " + layers_list.Items[workspace.SelectedLayer].Text);
            }
            else
                MessageBox.Show("Ciekawe co chcesz skopiować...");
        }

        private void całyObrazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picture.Visible)
            {
                ReDraw();
                Clipboard.SetImage(main_bitmap);
                AddMessage("Skopiowano cały obraz");
            }
            else
                MessageBox.Show("Ciekawe co chcesz skopiować...");
        }

    }
}
