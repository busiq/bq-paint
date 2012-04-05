namespace BQPaintNS
{
    partial class BQPaint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BQPaint));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.warstwęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.całyObrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.status_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.tool_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.selected_layer_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.mouse_position_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picture = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.color_btn = new System.Windows.Forms.Button();
            this.color_box = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.layers_list = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.layer_down_btn = new System.Windows.Forms.Button();
            this.layer_up_btn = new System.Windows.Forms.Button();
            this.layer_hide_btn = new System.Windows.Forms.Button();
            this.delete_layer_btn = new System.Windows.Forms.Button();
            this.add_layer_btn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tool_pencil_btn = new System.Windows.Forms.ToolStripButton();
            this.tool_line_btn = new System.Windows.Forms.ToolStripButton();
            this.tool_shape_btn = new System.Windows.Forms.ToolStripButton();
            this.tool_fill_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripNC = new BQPaintNS.Addons.ToolStripNumberControl();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.kwadratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trójkatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripCC = new BQPaintNS.Addons.ToolStripCheckBoxControl();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.status_timer = new System.Windows.Forms.Timer(this.components);
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.kopiujToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(900, 24);
            this.menu.TabIndex = 5;
            this.menu.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.toolStripSeparator1,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Image = global::BQPaintNS.Properties.Resources.page;
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Image = global::BQPaintNS.Properties.Resources.folder;
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Image = global::BQPaintNS.Properties.Resources.disk;
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warstwęToolStripMenuItem,
            this.całyObrazToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::BQPaintNS.Properties.Resources.clipboard_sign;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem1.Text = "Kopiuj";
            // 
            // warstwęToolStripMenuItem
            // 
            this.warstwęToolStripMenuItem.Name = "warstwęToolStripMenuItem";
            this.warstwęToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.C)));
            this.warstwęToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.warstwęToolStripMenuItem.Text = "Warstwę";
            this.warstwęToolStripMenuItem.Click += new System.EventHandler(this.warstwęToolStripMenuItem_Click);
            // 
            // całyObrazToolStripMenuItem
            // 
            this.całyObrazToolStripMenuItem.Name = "całyObrazToolStripMenuItem";
            this.całyObrazToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.całyObrazToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.całyObrazToolStripMenuItem.Text = "Cały obraz";
            this.całyObrazToolStripMenuItem.Click += new System.EventHandler(this.całyObrazToolStripMenuItem_Click);
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Image = global::BQPaintNS.Properties.Resources.applications_graphics;
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.kopiujToolStripMenuItem.Text = "Filtr RGB";
            this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.kopiujToolStripMenuItem_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_txt,
            this.tool_txt,
            this.selected_layer_txt,
            this.mouse_position_txt});
            this.status.Location = new System.Drawing.Point(0, 490);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.status.Size = new System.Drawing.Size(900, 25);
            this.status.TabIndex = 9;
            this.status.Text = "statusStrip1";
            // 
            // status_txt
            // 
            this.status_txt.AutoSize = false;
            this.status_txt.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.status_txt.Name = "status_txt";
            this.status_txt.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.status_txt.Size = new System.Drawing.Size(250, 20);
            this.status_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tool_txt
            // 
            this.tool_txt.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tool_txt.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.tool_txt.Image = global::BQPaintNS.Properties.Resources.paintbrush;
            this.tool_txt.Name = "tool_txt";
            this.tool_txt.Size = new System.Drawing.Size(126, 20);
            this.tool_txt.Text = "Wybrane narzędzie";
            // 
            // selected_layer_txt
            // 
            this.selected_layer_txt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.selected_layer_txt.Image = global::BQPaintNS.Properties.Resources.layers;
            this.selected_layer_txt.Name = "selected_layer_txt";
            this.selected_layer_txt.Size = new System.Drawing.Size(120, 20);
            this.selected_layer_txt.Text = "Wybrana warstwa";
            // 
            // mouse_position_txt
            // 
            this.mouse_position_txt.AutoToolTip = true;
            this.mouse_position_txt.Image = global::BQPaintNS.Properties.Resources.mouse;
            this.mouse_position_txt.Name = "mouse_position_txt";
            this.mouse_position_txt.Size = new System.Drawing.Size(99, 20);
            this.mouse_position_txt.Text = "Pozycja myszy";
            this.mouse_position_txt.ToolTipText = "Pozycja myszy";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel1.Controls.Add(this.picture);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2MinSize = 180;
            this.splitContainer1.Size = new System.Drawing.Size(900, 440);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 10;
            // 
            // picture
            // 
            this.picture.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picture.Location = new System.Drawing.Point(3, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(100, 50);
            this.picture.TabIndex = 5;
            this.picture.TabStop = false;
            this.picture.Visible = false;
            this.picture.WaitOnLoad = true;
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseLeave += new System.EventHandler(this.picture_MouseLeave);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(690, 440);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.color_btn);
            this.groupBox2.Controls.Add(this.color_box);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kolor";
            // 
            // color_btn
            // 
            this.color_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.color_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.color_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color_btn.Image = global::BQPaintNS.Properties.Resources.color_swatch_2;
            this.color_btn.Location = new System.Drawing.Point(14, 23);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(21, 23);
            this.color_btn.TabIndex = 10;
            this.color_btn.UseVisualStyleBackColor = false;
            this.color_btn.Click += new System.EventHandler(this.color_btn_Click);
            // 
            // color_box
            // 
            this.color_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_box.Location = new System.Drawing.Point(42, 23);
            this.color_box.Name = "color_box";
            this.color_box.Size = new System.Drawing.Size(133, 20);
            this.color_box.TabIndex = 0;
            this.color_box.TextChanged += new System.EventHandler(this.color_box_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.layers_list);
            this.groupBox3.Controls.Add(this.layer_down_btn);
            this.groupBox3.Controls.Add(this.layer_up_btn);
            this.groupBox3.Controls.Add(this.layer_hide_btn);
            this.groupBox3.Controls.Add(this.delete_layer_btn);
            this.groupBox3.Controls.Add(this.add_layer_btn);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(193, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.groupBox3.Size = new System.Drawing.Size(184, 163);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Warstwy";
            // 
            // layers_list
            // 
            this.layers_list.AutoArrange = false;
            this.layers_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layers_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.layers_list.HideSelection = false;
            this.layers_list.LabelEdit = true;
            this.layers_list.Location = new System.Drawing.Point(7, 23);
            this.layers_list.MultiSelect = false;
            this.layers_list.Name = "layers_list";
            this.layers_list.ShowGroups = false;
            this.layers_list.Size = new System.Drawing.Size(170, 97);
            this.layers_list.StateImageList = this.imageList1;
            this.layers_list.TabIndex = 16;
            this.layers_list.UseCompatibleStateImageBehavior = false;
            this.layers_list.View = System.Windows.Forms.View.List;
            this.layers_list.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.layers_list_ItemCheck);
            this.layers_list.SelectedIndexChanged += new System.EventHandler(this.layers_list_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "layer_treansparent.png");
            this.imageList1.Images.SetKeyName(1, "eye.png");
            // 
            // layer_down_btn
            // 
            this.layer_down_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.layer_down_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.layer_down_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.layer_down_btn.Image = global::BQPaintNS.Properties.Resources.down;
            this.layer_down_btn.Location = new System.Drawing.Point(147, 126);
            this.layer_down_btn.Name = "layer_down_btn";
            this.layer_down_btn.Size = new System.Drawing.Size(28, 28);
            this.layer_down_btn.TabIndex = 15;
            this.layer_down_btn.UseVisualStyleBackColor = false;
            this.layer_down_btn.Click += new System.EventHandler(this.layer_down_btn_Click);
            // 
            // layer_up_btn
            // 
            this.layer_up_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.layer_up_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.layer_up_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.layer_up_btn.Image = global::BQPaintNS.Properties.Resources.up;
            this.layer_up_btn.Location = new System.Drawing.Point(112, 126);
            this.layer_up_btn.Name = "layer_up_btn";
            this.layer_up_btn.Size = new System.Drawing.Size(28, 28);
            this.layer_up_btn.TabIndex = 14;
            this.layer_up_btn.UseVisualStyleBackColor = false;
            this.layer_up_btn.Click += new System.EventHandler(this.layer_up_btn_Click);
            // 
            // layer_hide_btn
            // 
            this.layer_hide_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.layer_hide_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.layer_hide_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.layer_hide_btn.Image = global::BQPaintNS.Properties.Resources.eye;
            this.layer_hide_btn.Location = new System.Drawing.Point(75, 126);
            this.layer_hide_btn.Name = "layer_hide_btn";
            this.layer_hide_btn.Size = new System.Drawing.Size(28, 28);
            this.layer_hide_btn.TabIndex = 13;
            this.layer_hide_btn.UseVisualStyleBackColor = false;
            this.layer_hide_btn.Click += new System.EventHandler(this.layer_hide_btn_Click);
            // 
            // delete_layer_btn
            // 
            this.delete_layer_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delete_layer_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.delete_layer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_layer_btn.Image = global::BQPaintNS.Properties.Resources.cross;
            this.delete_layer_btn.Location = new System.Drawing.Point(41, 126);
            this.delete_layer_btn.Name = "delete_layer_btn";
            this.delete_layer_btn.Size = new System.Drawing.Size(28, 28);
            this.delete_layer_btn.TabIndex = 12;
            this.delete_layer_btn.UseVisualStyleBackColor = false;
            this.delete_layer_btn.Click += new System.EventHandler(this.delete_layer_btn_Click);
            // 
            // add_layer_btn
            // 
            this.add_layer_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_layer_btn.Enabled = false;
            this.add_layer_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.add_layer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_layer_btn.Image = global::BQPaintNS.Properties.Resources.add;
            this.add_layer_btn.Location = new System.Drawing.Point(7, 126);
            this.add_layer_btn.Name = "add_layer_btn";
            this.add_layer_btn.Size = new System.Drawing.Size(28, 28);
            this.add_layer_btn.TabIndex = 11;
            this.add_layer_btn.UseVisualStyleBackColor = false;
            this.add_layer_btn.Click += new System.EventHandler(this.add_layer_btn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_pencil_btn,
            this.tool_line_btn,
            this.tool_shape_btn,
            this.tool_fill_btn,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.toolStripNC,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.toolStripDropDownButton1,
            this.toolStripLabel3,
            this.toolStripCC});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(900, 26);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tool_pencil_btn
            // 
            this.tool_pencil_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_pencil_btn.Image = global::BQPaintNS.Properties.Resources.pencil;
            this.tool_pencil_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_pencil_btn.Name = "tool_pencil_btn";
            this.tool_pencil_btn.Size = new System.Drawing.Size(23, 23);
            this.tool_pencil_btn.Text = "Pędzel";
            this.tool_pencil_btn.Click += new System.EventHandler(this.tool_pencil_btn_Click);
            // 
            // tool_line_btn
            // 
            this.tool_line_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_line_btn.Image = global::BQPaintNS.Properties.Resources.vector;
            this.tool_line_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_line_btn.Name = "tool_line_btn";
            this.tool_line_btn.Size = new System.Drawing.Size(23, 23);
            this.tool_line_btn.Text = "Linia";
            this.tool_line_btn.Click += new System.EventHandler(this.tool_line_btn_Click);
            // 
            // tool_shape_btn
            // 
            this.tool_shape_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_shape_btn.Image = global::BQPaintNS.Properties.Resources.shape_handles;
            this.tool_shape_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_shape_btn.Name = "tool_shape_btn";
            this.tool_shape_btn.Size = new System.Drawing.Size(23, 23);
            this.tool_shape_btn.Text = "Kształt";
            this.tool_shape_btn.Click += new System.EventHandler(this.tool_shape_btn_Click);
            // 
            // tool_fill_btn
            // 
            this.tool_fill_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_fill_btn.Image = global::BQPaintNS.Properties.Resources.paintcan;
            this.tool_fill_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_fill_btn.Name = "tool_fill_btn";
            this.tool_fill_btn.Size = new System.Drawing.Size(23, 23);
            this.tool_fill_btn.Text = "Wypełnienie";
            this.tool_fill_btn.Click += new System.EventHandler(this.tool_fill_btn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(91, 23);
            this.toolStripLabel1.Text = "Grubość pędzla:";
            // 
            // toolStripNC
            // 
            this.toolStripNC.Name = "toolStripNC";
            this.toolStripNC.Size = new System.Drawing.Size(41, 23);
            this.toolStripNC.Text = "1";
            this.toolStripNC.ValueChanged += new System.EventHandler(this.toolStripNC_ValueChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(44, 23);
            this.toolStripLabel2.Text = "Kształt:";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kwadratToolStripMenuItem,
            this.elipsaToolStripMenuItem,
            this.trójkatToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::BQPaintNS.Properties.Resources.shape_square;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 23);
            // 
            // kwadratToolStripMenuItem
            // 
            this.kwadratToolStripMenuItem.Image = global::BQPaintNS.Properties.Resources.shape_square;
            this.kwadratToolStripMenuItem.Name = "kwadratToolStripMenuItem";
            this.kwadratToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.kwadratToolStripMenuItem.Text = "Kwadrat";
            this.kwadratToolStripMenuItem.Click += new System.EventHandler(this.kwadratToolStripMenuItem_Click);
            // 
            // elipsaToolStripMenuItem
            // 
            this.elipsaToolStripMenuItem.Image = global::BQPaintNS.Properties.Resources.sport_golf;
            this.elipsaToolStripMenuItem.Name = "elipsaToolStripMenuItem";
            this.elipsaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.elipsaToolStripMenuItem.Text = "Elipsa";
            this.elipsaToolStripMenuItem.Click += new System.EventHandler(this.elipsaToolStripMenuItem_Click);
            // 
            // trójkatToolStripMenuItem
            // 
            this.trójkatToolStripMenuItem.Image = global::BQPaintNS.Properties.Resources.ruler_triangle;
            this.trójkatToolStripMenuItem.Name = "trójkatToolStripMenuItem";
            this.trójkatToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.trójkatToolStripMenuItem.Text = "Dowolny";
            this.trójkatToolStripMenuItem.Click += new System.EventHandler(this.trójkatToolStripMenuItem_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(75, 23);
            this.toolStripLabel3.Text = "Wypełnienie:";
            // 
            // toolStripCC
            // 
            this.toolStripCC.Name = "toolStripCC";
            this.toolStripCC.Size = new System.Drawing.Size(15, 23);
            this.toolStripCC.Click += new System.EventHandler(this.toolStripCC_Click);
            // 
            // status_timer
            // 
            this.status_timer.Interval = 2000;
            this.status_timer.Tick += new System.EventHandler(this.status_timer_Tick);
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "Portable Network Graphics(PNG)|*.png|JPEG|*.jpg|Bitmapa|*.bmp|Gif|*.gif";
            // 
            // openDialog
            // 
            this.openDialog.Filter = "Obsługiwane pliki graficzne(*.bmp, *.gif, *.png, *.jpg, *.exif, *.tiff)|*.bmp;*.g" +
                "if;*.png;*.jpg;*.jpeg;*.exif;*.tiff|Wszystkie pliki|*.*";
            this.openDialog.Title = "Otwórz plik";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BQPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 515);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BQPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BQPaint - simple the best";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel status_txt;
        private System.Windows.Forms.ToolStripStatusLabel tool_txt;
        private System.Windows.Forms.ToolStripStatusLabel selected_layer_txt;
        private System.Windows.Forms.ToolStripStatusLabel mouse_position_txt;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button color_btn;
        private System.Windows.Forms.TextBox color_box;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button layer_down_btn;
        private System.Windows.Forms.Button layer_up_btn;
        private System.Windows.Forms.Button layer_hide_btn;
        private System.Windows.Forms.Button delete_layer_btn;
        private System.Windows.Forms.Button add_layer_btn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tool_pencil_btn;
        private System.Windows.Forms.ToolStripButton tool_line_btn;
        private System.Windows.Forms.ToolStripButton tool_shape_btn;
        private System.Windows.Forms.ToolStripButton tool_fill_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private Addons.ToolStripNumberControl toolStripNC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.Timer status_timer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem kwadratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trójkatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private Addons.ToolStripCheckBoxControl toolStripCC;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
        public System.Windows.Forms.ListView layers_list;
        private System.Windows.Forms.ToolStripMenuItem warstwęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem całyObrazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
    }
}