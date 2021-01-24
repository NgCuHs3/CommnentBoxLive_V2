
namespace CommnetBoxLive.usercontrol
{
    partial class pageitemmodeluc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageitemmodel = new System.Windows.Forms.Panel();
            this.childmincontairner = new System.Windows.Forms.Panel();
            this.panelpagename = new System.Windows.Forms.Panel();
            this.pagename = new CommnetBoxLive.boxlabel();
            this.panelimage = new System.Windows.Forms.Panel();
            this.imageboxpanel = new CommnetBoxLive.boxcustomcontrol.boxpanel();
            this.imagepage = new System.Windows.Forms.PictureBox();
            this.pageitemmodel.SuspendLayout();
            this.childmincontairner.SuspendLayout();
            this.panelpagename.SuspendLayout();
            this.panelimage.SuspendLayout();
            this.imageboxpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagepage)).BeginInit();
            this.SuspendLayout();
            // 
            // pageitemmodel
            // 
            this.pageitemmodel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(85)))));
            this.pageitemmodel.Controls.Add(this.childmincontairner);
            this.pageitemmodel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageitemmodel.Location = new System.Drawing.Point(0, 0);
            this.pageitemmodel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pageitemmodel.Name = "pageitemmodel";
            this.pageitemmodel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pageitemmodel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pageitemmodel.Size = new System.Drawing.Size(460, 120);
            this.pageitemmodel.TabIndex = 1;
            // 
            // childmincontairner
            // 
            this.childmincontairner.Controls.Add(this.panelpagename);
            this.childmincontairner.Controls.Add(this.panelimage);
            this.childmincontairner.Dock = System.Windows.Forms.DockStyle.Top;
            this.childmincontairner.Location = new System.Drawing.Point(0, 0);
            this.childmincontairner.Name = "childmincontairner";
            this.childmincontairner.Size = new System.Drawing.Size(460, 100);
            this.childmincontairner.TabIndex = 0;
            // 
            // panelpagename
            // 
            this.panelpagename.Controls.Add(this.pagename);
            this.panelpagename.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelpagename.Location = new System.Drawing.Point(145, 0);
            this.panelpagename.Name = "panelpagename";
            this.panelpagename.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.panelpagename.Size = new System.Drawing.Size(315, 100);
            this.panelpagename.TabIndex = 1;
            // 
            // pagename
            // 
            this.pagename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(85)))));
            this.pagename.Dock = System.Windows.Forms.DockStyle.Left;
            this.pagename.Font = new System.Drawing.Font("Be Vietnam Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.pagename.IsVerticalautoresize = true;
            this.pagename.Location = new System.Drawing.Point(0, 2);
            this.pagename.Name = "pagename";
            this.pagename.Size = new System.Drawing.Size(265, 96);
            this.pagename.TabIndex = 0;
            this.pagename.Text = "pagename";
            this.pagename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelimage
            // 
            this.panelimage.Controls.Add(this.imageboxpanel);
            this.panelimage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelimage.Location = new System.Drawing.Point(0, 0);
            this.panelimage.Name = "panelimage";
            this.panelimage.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.panelimage.Size = new System.Drawing.Size(141, 100);
            this.panelimage.TabIndex = 0;
            // 
            // imageboxpanel
            // 
            this.imageboxpanel.Controls.Add(this.imagepage);
            this.imageboxpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.imageboxpanel.Location = new System.Drawing.Point(41, 2);
            this.imageboxpanel.Name = "imageboxpanel";
            this.imageboxpanel.Padding = new System.Windows.Forms.Padding(2);
            this.imageboxpanel.Size = new System.Drawing.Size(100, 96);
            this.imageboxpanel.TabIndex = 0;
            // 
            // imagepage
            // 
            this.imagepage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagepage.Image = global::CommnetBoxLive.Properties.Resources.Comment_Box_Live;
            this.imagepage.Location = new System.Drawing.Point(2, 2);
            this.imagepage.Name = "imagepage";
            this.imagepage.Size = new System.Drawing.Size(96, 92);
            this.imagepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagepage.TabIndex = 0;
            this.imagepage.TabStop = false;
            // 
            // pageitemmodeluc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pageitemmodel);
            this.Name = "pageitemmodeluc";
            this.Size = new System.Drawing.Size(460, 120);
            this.pageitemmodel.ResumeLayout(false);
            this.childmincontairner.ResumeLayout(false);
            this.panelpagename.ResumeLayout(false);
            this.panelimage.ResumeLayout(false);
            this.imageboxpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagepage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pageitemmodel;
        private System.Windows.Forms.Panel childmincontairner;
        private System.Windows.Forms.Panel panelpagename;
        private System.Windows.Forms.Panel panelimage;
        private boxlabel pagename;
        private boxcustomcontrol.boxpanel imageboxpanel;
        private System.Windows.Forms.PictureBox imagepage;
    }
}
