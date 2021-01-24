
namespace CommnetBoxLive
{
    partial class mewebview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mewebview));
            this.boxpanel1 = new CommnetBoxLive.boxcustomcontrol.boxpanel();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.boxpanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxpanel1
            // 
            this.boxpanel1.Controls.Add(this.webView21);
            this.boxpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxpanel1.Location = new System.Drawing.Point(1, 1);
            this.boxpanel1.Name = "boxpanel1";
            this.boxpanel1.Padding = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.boxpanel1.Size = new System.Drawing.Size(801, 526);
            this.boxpanel1.TabIndex = 0;
            // 
            // webView21
            // 
            this.webView21.CreationProperties = null;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(2, 2);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(798, 523);
            this.webView21.TabIndex = 0;
            this.webView21.Text = "webView21";
            this.webView21.ZoomFactor = 1D;
            // 
            // mewebview
            // 
            this.ClientSize = new System.Drawing.Size(804, 529);
            this.Controls.Add(this.boxpanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mewebview";
            this.Padding = new System.Windows.Forms.Padding(1, 1, 2, 2);
            this.Text = "Commnet Box Live";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.boxpanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private boxcustomcontrol.boxpanel boxpanel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}