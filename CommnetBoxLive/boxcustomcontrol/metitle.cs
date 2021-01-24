using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommnetBoxLive
{
    [System.ComponentModel.DesignerCategory("Code")]
    class metitle :  Label
    {
        public metitle()
        {
            dfsetup();
        }
        private void dfsetup()
        {
            this.AutoSize = false;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(85)))));
            this.Font = new System.Drawing.Font("Be Vietnam Thin", 16F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
        }
    }
}
