namespace BQPaintNS
{
    partial class RGBFilter
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
            this.redTB = new System.Windows.Forms.TrackBar();
            this.greenTB = new System.Windows.Forms.TrackBar();
            this.blueTB = new System.Windows.Forms.TrackBar();
            this.apply_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.blueNC = new System.Windows.Forms.NumericUpDown();
            this.greenNC = new System.Windows.Forms.NumericUpDown();
            this.redNC = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.thumbnail = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.redTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // redTB
            // 
            this.redTB.Location = new System.Drawing.Point(139, 55);
            this.redTB.Maximum = 255;
            this.redTB.Name = "redTB";
            this.redTB.Size = new System.Drawing.Size(319, 45);
            this.redTB.TabIndex = 0;
            this.redTB.Value = 255;
            this.redTB.ValueChanged += new System.EventHandler(this.colorTB_ValueChanged);
            this.redTB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.colorTB_MouseUp);
            // 
            // greenTB
            // 
            this.greenTB.Location = new System.Drawing.Point(138, 119);
            this.greenTB.Maximum = 255;
            this.greenTB.Name = "greenTB";
            this.greenTB.Size = new System.Drawing.Size(319, 45);
            this.greenTB.TabIndex = 1;
            this.greenTB.Value = 255;
            this.greenTB.ValueChanged += new System.EventHandler(this.colorTB_ValueChanged);
            this.greenTB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.colorTB_MouseUp);
            // 
            // blueTB
            // 
            this.blueTB.Location = new System.Drawing.Point(138, 190);
            this.blueTB.Maximum = 255;
            this.blueTB.Name = "blueTB";
            this.blueTB.Size = new System.Drawing.Size(319, 45);
            this.blueTB.TabIndex = 2;
            this.blueTB.Value = 255;
            this.blueTB.ValueChanged += new System.EventHandler(this.colorTB_ValueChanged);
            this.blueTB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.colorTB_MouseUp);
            // 
            // apply_btn
            // 
            this.apply_btn.Location = new System.Drawing.Point(301, 241);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(75, 23);
            this.apply_btn.TabIndex = 4;
            this.apply_btn.Text = "Zastosuj";
            this.apply_btn.UseVisualStyleBackColor = true;
            this.apply_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(382, 241);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Anuluj";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // blueNC
            // 
            this.blueNC.Location = new System.Drawing.Point(382, 164);
            this.blueNC.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueNC.Name = "blueNC";
            this.blueNC.Size = new System.Drawing.Size(75, 20);
            this.blueNC.TabIndex = 6;
            this.blueNC.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueNC.ValueChanged += new System.EventHandler(this.colorNC_ValueChanged);
            this.blueNC.Validated += new System.EventHandler(this.colorNC_Validated);
            // 
            // greenNC
            // 
            this.greenNC.Location = new System.Drawing.Point(382, 101);
            this.greenNC.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenNC.Name = "greenNC";
            this.greenNC.Size = new System.Drawing.Size(75, 20);
            this.greenNC.TabIndex = 7;
            this.greenNC.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenNC.ValueChanged += new System.EventHandler(this.colorNC_ValueChanged);
            this.greenNC.Validated += new System.EventHandler(this.colorNC_Validated);
            // 
            // redNC
            // 
            this.redNC.Location = new System.Drawing.Point(382, 31);
            this.redNC.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redNC.Name = "redNC";
            this.redNC.Size = new System.Drawing.Size(75, 20);
            this.redNC.TabIndex = 8;
            this.redNC.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redNC.ValueChanged += new System.EventHandler(this.colorNC_ValueChanged);
            this.redNC.Validated += new System.EventHandler(this.colorNC_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "RED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "GREEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "BLUE";
            // 
            // thumbnail
            // 
            this.thumbnail.Location = new System.Drawing.Point(12, 31);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(120, 120);
            this.thumbnail.TabIndex = 3;
            this.thumbnail.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Podgląd :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 240);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(280, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 13;
            // 
            // RGBFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 270);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redNC);
            this.Controls.Add(this.greenNC);
            this.Controls.Add(this.blueNC);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.apply_btn);
            this.Controls.Add(this.thumbnail);
            this.Controls.Add(this.blueTB);
            this.Controls.Add(this.greenTB);
            this.Controls.Add(this.redTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RGBFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filtr RGB";
            ((System.ComponentModel.ISupportInitialize)(this.redTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar redTB;
        private System.Windows.Forms.TrackBar greenTB;
        private System.Windows.Forms.TrackBar blueTB;
        private System.Windows.Forms.PictureBox thumbnail;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.NumericUpDown blueNC;
        private System.Windows.Forms.NumericUpDown greenNC;
        private System.Windows.Forms.NumericUpDown redNC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}