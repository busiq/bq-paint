using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BQPaintNS
{
    public partial class new_file_window : Form
    {
        private BQPaint f;
        public new_file_window(BQPaint f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.CreateWorkspace((int)width.Value, (int)height.Value, name.Text);
            Close();
        }

        private void new_file_window_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                MessageBox.Show("ENTER");
            else
                MessageBox.Show(e.KeyChar.ToString());
        }
    }
}
