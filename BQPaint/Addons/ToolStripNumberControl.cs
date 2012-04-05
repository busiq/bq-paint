using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

/* To coś pozwala dodawać NumericUpDownControl do ToolStripa
 * Kod znaleziony w sieci ale zmodyfikowany pod moje potrzeby */

namespace BQPaintNS.Addons
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip)]
    public class ToolStripNumberControl : ToolStripControlHost
    {
        public NumericUpDown nc;
        public ToolStripNumberControl()
            : base(new NumericUpDown())
        {
          
        }

        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);
            ((NumericUpDown)control).ValueChanged += new EventHandler(OnValueChanged);
        }

        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);
            ((NumericUpDown)control).ValueChanged -= new EventHandler(OnValueChanged);
        }

        public event EventHandler ValueChanged;

        public NumericUpDown NumericUpDownControl
        {
            get { return Control as NumericUpDown; }
        }

        public void OnValueChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
            {
                ValueChanged(this, e);
            }
        }
    }
}
