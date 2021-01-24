using CommnetBoxLive.usercontrol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommnetBoxLive
{
    public partial class choosepage : UserControl
    {
        public choosepage()
        {
            InitializeComponent();
        }
        public void FillPageContainer(object data, Action<object> callback)
        {

            foreach (var page in (data as dynamic).data)
            {
                //dùng conver lamda express qua Methodivo hoa 
                //dùng action cũng dc
                this.Invoke((MethodInvoker)(()=>{
                        pageitemmodeluc modepageitem = new pageitemmodeluc()
                        {
                            Height = 120,
                            Width = 460
                           
                        };
                    modepageitem.Location = new Point(0, 0);


                    Panel container = modepageitem.Controls["pageitemmodel"].Controls["childmincontairner"] as Panel;
                        string pagename = page.name;
                        string pageimageurl = page.picture.data.url;
                        //cai text va image
                        boxlabel pagelabel = container.Controls["panelpagename"].Controls["pagename"] as boxlabel;
                        pagelabel.Text = pagename;
                        //tag la du lieu truyen ve tu ham cakk bacjk 
                        pagelabel.Tag = new
                        {
                            PAGETOKEN = page.access_token,
                            PAGENAME = page.name,
                            PAGEIMAGEURL = page.picture.data.url
                        };
                        pagelabel.Click += (o, s) =>
                        {
                            boxlabel sp = o as boxlabel;
                            sp.BackColor = Color.FromArgb(189, 255, 203);
                            //gui duw lieu ve
                            callback(sp.Tag);
                        };
                    //cai hinh
                    (container.Controls["panelimage"].Controls["imageboxpanel"].Controls["imagepage"] as PictureBox).ImageLocation = pageimageurl;
                        pagecontainer.Controls.Add(modepageitem);
                        //MessageBox.Show(a.Text);
                        Debug.WriteLine("PAGE ĐÃ LOAD | " + pagename + " | " + scrollpanel.Controls.Count);
                })
               );

            }
        }


    }

    public static class ObjectCopier
    {
        public static T Clone<T>(this T source)
        {
            if (Object.ReferenceEquals(source, null))
            {
                return default(T);
            }

            var deserializeSettings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace };

            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source), deserializeSettings);
        }

    }
}
