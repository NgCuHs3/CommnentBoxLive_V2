
using System.Windows.Forms;

namespace CommnetBoxLive
{
    partial class loginfacebook
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mbox1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startbtn = new CommnetBoxLive.boxbutton();
            this.title = new CommnetBoxLive.metitle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mbox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mbox1
            // 
            this.mbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(85)))));
            this.mbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mbox1.Controls.Add(this.linkLabel1);
            this.mbox1.Controls.Add(this.panel2);
            this.mbox1.Controls.Add(this.label2);
            this.mbox1.Controls.Add(this.label1);
            this.mbox1.Controls.Add(this.panel1);
            this.mbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbox1.Location = new System.Drawing.Point(0, 0);
            this.mbox1.Name = "mbox1";
            this.mbox1.Size = new System.Drawing.Size(502, 792);
            this.mbox1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel1.Font = new System.Drawing.Font("Be Vietnam Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.linkLabel1.Location = new System.Drawing.Point(0, 546);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(500, 71);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create !";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Navy;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.startbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 635);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 155);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Be Vietnam Thin", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.label2.Location = new System.Drawing.Point(0, 501);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.label2.Size = new System.Drawing.Size(500, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "if you did\'t create any pages create now !";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Be Vietnam Thin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.label1.Location = new System.Drawing.Point(0, 363);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.label1.Size = new System.Drawing.Size(500, 138);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login your facebook and choose your page which one you want to be receiver messag" +
    "e.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 363);
            this.panel1.TabIndex = 1;
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbtn.Font = new System.Drawing.Font("Be Vietnam Thin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.startbtn.Location = new System.Drawing.Point(33, 35);
            this.startbtn.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(431, 88);
            this.startbtn.TabIndex = 6;
            this.startbtn.Text = "Authenticate now";
            this.startbtn.UseVisualStyleBackColor = false;
     
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.title.Font = new System.Drawing.Font("Be Vietnam Thin", 23F);
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(502, 71);
            this.title.TabIndex = 5;
            this.title.Text = "Let\'s go";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CommnetBoxLive.Properties.Resources.facebookicon;
            this.pictureBox1.Location = new System.Drawing.Point(174, 173);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginfacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mbox1);
            this.Name = "loginfacebook";
            this.Size = new System.Drawing.Size(502, 792);
            this.Load += new System.EventHandler(this.loginfacebook_Load);
            this.mbox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private Panel mbox1;
        private metitle title;
        private Panel panel1;
        private PictureBox pictureBox1;
        #endregion

        private Label label1;
        private Label label2;
        private Panel panel2;
        private boxbutton startbtn;
        private LinkLabel linkLabel1;
    }
}
