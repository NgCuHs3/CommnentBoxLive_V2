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
    public class boxpanel : Panel
    {

        public boxpanel()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            DrawRoundRect(e.Graphics, new Pen(Color.FromArgb(189, 255, 203), 3), e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width, e.ClipRectangle.Height);
        }
        public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height)
        {
            g.DrawRectangle(p, new Rectangle((int)X, (int)Y, (int)width, (int)height));
        }
    }
}
