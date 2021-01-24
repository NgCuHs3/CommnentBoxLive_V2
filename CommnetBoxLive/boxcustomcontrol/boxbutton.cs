using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommnetBoxLive
{
    [System.ComponentModel.DesignerCategory("Code")]
    public class boxbutton : Button
    {

        public boxbutton()
        {
            dfproperties();
        }
        private void dfproperties()
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.Font = new System.Drawing.Font("Be Vietnam Thin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.Text = "Button";
            this.UseVisualStyleBackColor = false;
            this.FlatStyle = FlatStyle.Flat;
            this.MouseDown += meMouseDown;
            this.MouseUp += meMouseUp;
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, 0.2f))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.FromArgb(189, 255, 203), 2.1f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }
        public void meMouseDown(object sender, MouseEventArgs e)
        {
            Button bt = sender as Button;
            bt.BackColor = Color.FromArgb(189, 255, 203);
            bt.ForeColor = Color.White;
        }

        public  void meMouseUp(object sender, MouseEventArgs e)
        {
            Button bt = sender as Button;
            bt.BackColor = Color.FromArgb(10, 10, 35);
            bt.ForeColor = Color.FromArgb(189, 255, 203); ;
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




       
    }
}
