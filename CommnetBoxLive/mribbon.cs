using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace CommnetBoxLive
{
    public partial class mribbon
    {
        private void mribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        public delegate void cncommandclick(Object btn);
        public event cncommandclick OnCommandClick;

        private void quickstartbtn_Click(object sender, RibbonControlEventArgs e)
        {
            if(OnCommandClick != null)
            {
                OnCommandClick(sender);
            }
        }
    }
}
