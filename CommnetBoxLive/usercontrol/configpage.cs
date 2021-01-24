using CommnetBoxLive.boxcustomcontrol;
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
    public partial class configpage : UserControl
    {
        public configpage()
        {
            InitializeComponent();
        }
        public boxbutton Donebtn
        {
            get { return donebtn; }
        }
        public boxtextinput ShapeName
        {
            get { return shapenametb; }
        }
    }
}
