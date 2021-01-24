
namespace CommnetBoxLive
{
    partial class mribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public mribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mribbon));
            this.mtab = this.Factory.CreateRibbonTab();
            this.quickg = this.Factory.CreateRibbonGroup();
            this.taskg = this.Factory.CreateRibbonGroup();
            this.pg = this.Factory.CreateRibbonGroup();
            this.quickstartbtn = this.Factory.CreateRibbonButton();
            this.configbtn = this.Factory.CreateRibbonButton();
            this.insertbtn = this.Factory.CreateRibbonButton();
            this.helpbtn = this.Factory.CreateRibbonButton();
            this.fbpagebtn = this.Factory.CreateRibbonButton();
            this.mtab.SuspendLayout();
            this.quickg.SuspendLayout();
            this.taskg.SuspendLayout();
            this.pg.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtab
            // 
            this.mtab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.mtab.Groups.Add(this.quickg);
            this.mtab.Groups.Add(this.taskg);
            this.mtab.Groups.Add(this.pg);
            this.mtab.Label = "Comment Box Live";
            this.mtab.Name = "mtab";
            // 
            // quickg
            // 
            this.quickg.Items.Add(this.quickstartbtn);
            this.quickg.Label = "Quick start";
            this.quickg.Name = "quickg";
            // 
            // taskg
            // 
            this.taskg.Items.Add(this.configbtn);
            this.taskg.Items.Add(this.insertbtn);
            this.taskg.Items.Add(this.helpbtn);
            this.taskg.Label = "Task";
            this.taskg.Name = "taskg";
            // 
            // pg
            // 
            this.pg.Items.Add(this.fbpagebtn);
            this.pg.Label = "Working Page";
            this.pg.Name = "pg";
            // 
            // quickstartbtn
            // 
            this.quickstartbtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.quickstartbtn.Image = global::CommnetBoxLive.Properties.Resources.startbtn;
            this.quickstartbtn.Label = "QuickStart now";
            this.quickstartbtn.Name = "quickstartbtn";
            this.quickstartbtn.ShowImage = true;
            this.quickstartbtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.quickstartbtn_Click);
            // 
            // configbtn
            // 
            this.configbtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.configbtn.Image = global::CommnetBoxLive.Properties.Resources.configbtn;
            this.configbtn.Label = "Configuration";
            this.configbtn.Name = "configbtn";
            this.configbtn.ShowImage = true;
            this.configbtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.quickstartbtn_Click);
            // 
            // insertbtn
            // 
            this.insertbtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.insertbtn.Image = ((System.Drawing.Image)(resources.GetObject("insertbtn.Image")));
            this.insertbtn.Label = "Insert Box Live";
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.ShowImage = true;
            this.insertbtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.quickstartbtn_Click);
            // 
            // helpbtn
            // 
            this.helpbtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.helpbtn.Image = global::CommnetBoxLive.Properties.Resources.helpyt;
            this.helpbtn.Label = "Howto use";
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.ShowImage = true;
            this.helpbtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.quickstartbtn_Click);
            // 
            // fbpagebtn
            // 
            this.fbpagebtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.fbpagebtn.Image = global::CommnetBoxLive.Properties.Resources.fbon;
            this.fbpagebtn.Label = "Facebook page";
            this.fbpagebtn.Name = "fbpagebtn";
            this.fbpagebtn.ShowImage = true;
            this.fbpagebtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.quickstartbtn_Click);
            // 
            // mribbon
            // 
            this.Name = "mribbon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.mtab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.mribbon_Load);
            this.mtab.ResumeLayout(false);
            this.mtab.PerformLayout();
            this.quickg.ResumeLayout(false);
            this.quickg.PerformLayout();
            this.taskg.ResumeLayout(false);
            this.taskg.PerformLayout();
            this.pg.ResumeLayout(false);
            this.pg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab mtab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup quickg;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton quickstartbtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup taskg;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton configbtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton fbpagebtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton helpbtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup pg;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insertbtn;
    }

    partial class ThisRibbonCollection
    {
        internal mribbon mribbon
        {
            get { return this.GetRibbon<mribbon>(); }
        }
    }
}
