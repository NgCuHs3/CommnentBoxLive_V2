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
    public class boxtextinput : Panel
    {

        private string btext;
        private int hbPadding = 4;
        private Single tFontSize = 14F;
        

        private TextBox  tb = new TextBox();
        private Panel  pn = new Panel();


        public string TBext
        {
            get { return tb.Text; }
            set { tb.Text = value; }

        }

        public int HbPadding
        {
            get { return hbPadding; }
            set
            {
                hbPadding = value;
                updatesize();
            }
        }

        public float TFontSize
        {
            get { return tFontSize; }
            set
            {
                tFontSize = value;
                tb.Font = new System.Drawing.Font("Be Vietnam Thin", tFontSize);
            }
        }

        public boxtextinput()
        {
          
            dfsetup();
        }
        private void dfsetup()
        {
            this.BorderStyle = BorderStyle.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            //
            pn.Dock = DockStyle.Fill;
            //
            tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            tb.Font = new System.Drawing.Font("Be Vietnam Thin", TFontSize);
            tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            tb.Dock = DockStyle.Fill;
            tb.BorderStyle = BorderStyle.None;
          
            //          
            pn.Padding = new Padding(0, pn.Height / 2 - tb.Height / 2, 0, pn.Height / 2 - tb.Height / 2);
            this.Padding = new Padding(hbPadding, 4, hbPadding, 4);
            //
            pn.Controls.Add(tb);
            this.Controls.Add(pn);
        }
        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            updatesize();
        }
        private void updatesize()
        {
            pn.Padding = new Padding(5, pn.Height / 2 - tb.Height / 2, 5, pn.Height / 2 - tb.Height / 2);
            this.Padding = new Padding(hbPadding, 4, hbPadding, 4);
        }
        GraphicsPath GetRoundPath(RectangleF Rect, float radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, 0.2f))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.FromArgb(189, 255, 203), 2f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
            //
            //TextRenderer.DrawText(e.Graphics, Text, this.Font, this.ClientRectangle, this.ForeColor);
        }
    }


}
