using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommnetBoxLive.usercontrol
{
    public partial class pageitemmodeluc : UserControl
    {
        public pageitemmodeluc()
        {
            InitializeComponent();
            dfstyle();
        }
        private void dfstyle()
        {
            panelpagename.Width = childmincontairner.Width - panelimage.Width;
        }
    }
}
