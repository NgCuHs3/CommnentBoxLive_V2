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
    public partial class configurationpanel : UserControl
    {
        public configurationpanel()
        {
            InitializeComponent();
        }

        public boxbutton DoneBTN
        {
            get
            {
                return donebtn;
            }
        }
        public object DataConfig
        {
            get
            {
              
                return new 
                {
                  
                  USERNAME = username.Text,
                  USERIMAGE = userimage.ImageLocation,
                  PAGENAME = pagename.Text,
                  PAGEIMAGE = pageimage.ImageLocation,
                  SHAPEBOXNAME = shapenametb.TBext,
                  ALLOWTEXT = altext.Checked,
                  ALLOWIMAGE = alimage.Checked,
                  ALLOWAUDIO = alsound.Checked,
                  ALLOWSEPRATE = alseprate.Checked,
                  ALLOWCOMMAND = alcommand.Checked// beta 
            };
            }
            set
            {
                //gắn dũ liệu cho các control
                dynamic dat = value as dynamic;
                username.Text = dat.USERNAME;
                userimage.ImageLocation = dat.USERIMAGE;
                pagename.Text = dat.PAGENAME;
                pageimage.ImageLocation = dat.PAGEIMAGE;
                shapenametb.TBext = dat.SHAPEBOXNAME;
                altext.Checked = dat.ALLOWTEXT;
                alimage.Checked = dat.ALLOWIMAGE;
                alsound.Checked = dat.ALLOWAUDIO;
                alseprate.Checked = dat.ALLOWSEPRATE;
                alcommand.Checked = dat.ALLOWCOMMAND;
            }
        }
    }
}
