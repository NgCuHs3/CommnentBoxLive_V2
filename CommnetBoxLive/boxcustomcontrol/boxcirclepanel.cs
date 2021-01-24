using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommnetBoxLive.boxcustomcontrol
{
    [System.ComponentModel.DesignerCategory("Code")]
    class boxcirclepanel : Panel
    {
        public boxcirclepanel()
        {
            this.Padding = new Padding(2, 2, 2, 2);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            
            base.OnPaint(e);
            Pen xPen = new Pen(Color.FromArgb(189,255,203),2);
            // Create rectangle for circle.
            Rectangle rect = new Rectangle(2, 2, Width-6, Height-6);

            // Draw circle.
            e.Graphics.DrawEllipse(xPen, rect);

        }

    }
}
