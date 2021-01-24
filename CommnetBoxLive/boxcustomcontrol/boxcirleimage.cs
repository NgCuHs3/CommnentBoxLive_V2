using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommnetBoxLive.boxcustomcontrol
{
    [System.ComponentModel.DesignerCategory("Code")]
    class boxcirleimage : PictureBox
    {
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(1, 1, Width - 4, Height - 4);
            Region rg = new Region(gp);
            this.Region = rg;
        }

    }

}
