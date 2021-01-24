using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace taspkpanelib
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class taspkpaneUi : UserControl
    {
        public taspkpaneUi()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {

            facebookicon.Source = new BitmapImage(new Uri(@"/Resources/facebookicon.png",UriKind.Relative));

        }
       
    }

}
