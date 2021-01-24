
namespace CommnetBoxLive.usercontrol
{
    partial class configurationpanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panescroll = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.altext = new System.Windows.Forms.CheckBox();
            this.alimage = new System.Windows.Forms.CheckBox();
            this.alsound = new System.Windows.Forms.CheckBox();
            this.alseprate = new System.Windows.Forms.CheckBox();
            this.alcommand = new System.Windows.Forms.CheckBox();
            this.donebtn = new CommnetBoxLive.boxbutton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.shapenametb = new CommnetBoxLive.boxcustomcontrol.boxtextinput();
            this.boxlabel1 = new CommnetBoxLive.boxlabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pageimage = new System.Windows.Forms.PictureBox();
            this.pagename = new CommnetBoxLive.boxlabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userimage = new System.Windows.Forms.PictureBox();
            this.username = new CommnetBoxLive.boxlabel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panescroll.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageimage)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userimage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 792);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panescroll);
            this.panel5.Controls.Add(this.donebtn);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 214);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(502, 566);
            this.panel5.TabIndex = 1;
            // 
            // panescroll
            // 
            this.panescroll.AutoScroll = true;
            this.panescroll.Controls.Add(this.flowLayoutPanel1);
            this.panescroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.panescroll.Location = new System.Drawing.Point(0, 176);
            this.panescroll.Name = "panescroll";
            this.panescroll.Size = new System.Drawing.Size(502, 269);
            this.panescroll.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.altext);
            this.flowLayoutPanel1.Controls.Add(this.alimage);
            this.flowLayoutPanel1.Controls.Add(this.alsound);
            this.flowLayoutPanel1.Controls.Add(this.alseprate);
            this.flowLayoutPanel1.Controls.Add(this.alcommand);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(476, 325);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // altext
            // 
            this.altext.Font = new System.Drawing.Font("Be Vietnam Light", 14F);
            this.altext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.altext.Location = new System.Drawing.Point(55, 3);
            this.altext.Margin = new System.Windows.Forms.Padding(55, 3, 3, 3);
            this.altext.Name = "altext";
            this.altext.Size = new System.Drawing.Size(392, 59);
            this.altext.TabIndex = 12;
            this.altext.Text = "Allow Text";
            this.altext.UseVisualStyleBackColor = true;
            // 
            // alimage
            // 
            this.alimage.Font = new System.Drawing.Font("Be Vietnam Light", 14F);
            this.alimage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.alimage.Location = new System.Drawing.Point(55, 68);
            this.alimage.Margin = new System.Windows.Forms.Padding(55, 3, 3, 3);
            this.alimage.Name = "alimage";
            this.alimage.Size = new System.Drawing.Size(392, 59);
            this.alimage.TabIndex = 10;
            this.alimage.Text = "Allow Image";
            this.alimage.UseVisualStyleBackColor = true;
            // 
            // alsound
            // 
            this.alsound.Font = new System.Drawing.Font("Be Vietnam Light", 14F);
            this.alsound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.alsound.Location = new System.Drawing.Point(55, 133);
            this.alsound.Margin = new System.Windows.Forms.Padding(55, 3, 3, 3);
            this.alsound.Name = "alsound";
            this.alsound.Size = new System.Drawing.Size(392, 59);
            this.alsound.TabIndex = 15;
            this.alsound.Text = "Allow Sound";
            this.alsound.UseVisualStyleBackColor = true;
            // 
            // alseprate
            // 
            this.alseprate.Font = new System.Drawing.Font("Be Vietnam Light", 14F);
            this.alseprate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.alseprate.Location = new System.Drawing.Point(55, 198);
            this.alseprate.Margin = new System.Windows.Forms.Padding(55, 3, 3, 3);
            this.alseprate.Name = "alseprate";
            this.alseprate.Size = new System.Drawing.Size(392, 59);
            this.alseprate.TabIndex = 13;
            this.alseprate.Text = "Separate text and image";
            this.alseprate.UseVisualStyleBackColor = true;
            // 
            // alcommand
            // 
            this.alcommand.Font = new System.Drawing.Font("Be Vietnam Light", 14F);
            this.alcommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.alcommand.Location = new System.Drawing.Point(55, 263);
            this.alcommand.Margin = new System.Windows.Forms.Padding(55, 3, 3, 3);
            this.alcommand.Name = "alcommand";
            this.alcommand.Size = new System.Drawing.Size(392, 59);
            this.alcommand.TabIndex = 14;
            this.alcommand.Text = "Message code (beta)";
            this.alcommand.UseVisualStyleBackColor = true;
            // 
            // donebtn
            // 
            this.donebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.donebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donebtn.Font = new System.Drawing.Font("Be Vietnam Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.donebtn.Location = new System.Drawing.Point(28, 475);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(448, 88);
            this.donebtn.TabIndex = 6;
            this.donebtn.Text = "Done";
            this.donebtn.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.shapenametb);
            this.panel6.Controls.Add(this.boxlabel1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(502, 176);
            this.panel6.TabIndex = 4;
            // 
            // shapenametb
            // 
            this.shapenametb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.shapenametb.TBext = "shapeboxname1";
            this.shapenametb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.shapenametb.HbPadding = 4;
            this.shapenametb.Location = new System.Drawing.Point(28, 101);
            this.shapenametb.Name = "shapenametb";
            this.shapenametb.Padding = new System.Windows.Forms.Padding(4);
            this.shapenametb.Size = new System.Drawing.Size(445, 53);
            this.shapenametb.TabIndex = 3;
            this.shapenametb.TFontSize = 12F;
            // 
            // boxlabel1
            // 
            this.boxlabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.boxlabel1.Font = new System.Drawing.Font("Be Vietnam Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxlabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.boxlabel1.IsVerticalautoresize = false;
            this.boxlabel1.Location = new System.Drawing.Point(28, 21);
            this.boxlabel1.Name = "boxlabel1";
            this.boxlabel1.Size = new System.Drawing.Size(445, 63);
            this.boxlabel1.TabIndex = 2;
            this.boxlabel1.Text = "Box Message name";
            this.boxlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 214);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pageimage);
            this.panel4.Controls.Add(this.pagename);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(245, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 214);
            this.panel4.TabIndex = 1;
            // 
            // pageimage
            // 
            this.pageimage.Image = global::CommnetBoxLive.Properties.Resources.Comment_Box_Live;
            this.pageimage.Location = new System.Drawing.Point(69, 14);
            this.pageimage.Name = "pageimage";
            this.pageimage.Size = new System.Drawing.Size(120, 120);
            this.pageimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pageimage.TabIndex = 2;
            this.pageimage.TabStop = false;
            // 
            // pagename
            // 
            this.pagename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(38)))));
            this.pagename.Font = new System.Drawing.Font("Be Vietnam Thin", 14F);
            this.pagename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.pagename.IsVerticalautoresize = true;
            this.pagename.Location = new System.Drawing.Point(15, 149);
            this.pagename.Name = "pagename";
            this.pagename.Size = new System.Drawing.Size(213, 52);
            this.pagename.TabIndex = 1;
            this.pagename.Text = "page name";
            this.pagename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userimage);
            this.panel3.Controls.Add(this.username);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 214);
            this.panel3.TabIndex = 0;
            // 
            // userimage
            // 
            this.userimage.Image = global::CommnetBoxLive.Properties.Resources.facebookicon;
            this.userimage.Location = new System.Drawing.Point(50, 14);
            this.userimage.Name = "userimage";
            this.userimage.Size = new System.Drawing.Size(120, 120);
            this.userimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userimage.TabIndex = 1;
            this.userimage.TabStop = false;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(38)))));
            this.username.Font = new System.Drawing.Font("Be Vietnam Thin", 14F);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.username.IsVerticalautoresize = true;
            this.username.Location = new System.Drawing.Point(28, 149);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(193, 52);
            this.username.TabIndex = 0;
            this.username.Text = "user name";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // configurationpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "configurationpanel";
            this.Size = new System.Drawing.Size(502, 792);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panescroll.ResumeLayout(false);
            this.panescroll.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageimage)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private boxlabel pagename;
        private System.Windows.Forms.Panel panel3;
        private boxlabel username;
        private System.Windows.Forms.PictureBox pageimage;
        private System.Windows.Forms.PictureBox userimage;
        private System.Windows.Forms.Panel panel5;
        private boxcustomcontrol.boxtextinput shapenametb;
        private boxlabel boxlabel1;
        private System.Windows.Forms.Panel panel6;
        private boxbutton donebtn;
        private System.Windows.Forms.Panel panescroll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox alimage;
        private System.Windows.Forms.CheckBox altext;
        private System.Windows.Forms.CheckBox alseprate;
        private System.Windows.Forms.CheckBox alcommand;
        private System.Windows.Forms.CheckBox alsound;
    }
}
