using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

/* To coś pozwala dodawać CheckBox do ToolStripa
 * Tym razem już samemu napisany :p */

namespace BQPaintNS.Addons
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip)]
    public class ToolStripCheckBoxControl : ToolStripControlHost
    {
        public CheckBox cb;
        public ToolStripCheckBoxControl()
            : base(new CheckBox())
        {
 
        }

        public CheckBox CheckBoxControl
        {
            get { return Control as CheckBox; }
        }

    }
}
