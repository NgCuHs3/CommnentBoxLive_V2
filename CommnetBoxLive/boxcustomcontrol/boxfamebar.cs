using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CommnetBoxLive.boxcustomcontrol
{
    [System.ComponentModel.DesignerCategory("Code")]
    class boxfamebar : Panel
    {
        public Panel barpanel;
        public Panel contextpanel;
       
        private int barhigh = 50;
        private Point point;

        public int Barhigh { get { return barhigh; } set { 
                barhigh = value; this.Invalidate();
            } }
        //choons giat
        private const int WS_EX_COMPOSITED = 0x02000000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_COMPOSITED;
                return cp;
            }
        }

        public boxfamebar()
        {
            dfstyle();
        }
        private void dfstyle()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(38, 38, 85);
            this.Margin = new Padding(2);
            this.DoubleBuffered = true;
            this.Padding = new Padding(2, 2, 1, 1);
            //
            barpanel = new Panel();
            contextpanel = new Panel();

            barpanel.Dock = DockStyle.Top;
            barpanel.BackColor = Color.Red;
            barpanel.Height = 100;
            this.Controls.Add(barpanel);

        }
        //foucs mouse
        protected override void OnMouseDown(MouseEventArgs e)
        {
            point = e.Location;
            base.OnMouseDoubleClick(e);
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            Form parentForm = (this.Parent as Form);

            if (e.Button == MouseButtons.Left && (point.Y <= barhigh)) {
                parentForm.Left += e.X - point.X;
                parentForm.Top += e.Y - point.Y;
                
                }
            base.OnMouseMove(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            DrawRoundRect(e.Graphics, new Pen(Color.FromArgb(189, 255, 203), 3), Color.FromArgb(10, 10, 38), e.ClipRectangle.Left, e.ClipRectangle.Top, Barhigh);
           
        }
        public void DrawRoundRect(Graphics g, Pen p, Color barcolor, float X, float Y, int BBarheigh)
        {
            //clear afterimage
            this.Invalidate();
            //ve baro color
            GraphicsPath gpbarcolor = new GraphicsPath();


            gpbarcolor.CloseFigure();

            //vẽ bar và bõ
            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(
                  new PointF[]  {
                     new PointF(X, Y),
                     new PointF(X , Y  + BBarheigh),
                     new PointF(X + this.Width , Y  + BBarheigh),
                     new PointF(X + this.Width , Y +  this.Height),
                     new PointF(X  , Y  +  this.Height),
                     new PointF(X   , Y  +  BBarheigh),
                     new PointF(X +this.Width , Y  +  BBarheigh),
                     new PointF(X  +this.Width , Y )
                    }
                 );
            //
            Debug.WriteLine("AAA " + this.Width + "|" + this.Height + "|" +X + "|"+Y);
            Brush brush = new SolidBrush(barcolor);
            gp.CloseFigure();
            g.FillRectangle(brush, new Rectangle((int)X, (int)Y, Width, BBarheigh));
            g.DrawPath(p, gp);
            gp.Dispose();
          
        }
    }
}
