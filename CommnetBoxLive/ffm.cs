using CommnetBoxLive.usercontrol;
using Facebook;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CommnetBoxLive
{
    public partial class ffm : Form
    {

        private FacebookClient fb = new FacebookClient();

        public ffm()
        {
            InitializeComponent();
            this.Show();
        }

        private void ffm_Load(object sender, EventArgs e)
        {

          
        }
        #region Function
        public void QuickStartnow(ThisAddIn thisAdd,Action<object> datafallback)
        {
            //login fb lay token
            var loginfb = new loginfacebook();
            SwithControluse(loginfb);
            loginfb.StartBTN.Click += (o, s) =>
            {
                var wb = new mewebview();
                wb.LoginFb(repose =>
                {
                    try
                    {
                        var accesstoken = GetUriParameter(repose, "access_token");

                    if (accesstoken == null)
                    {
                        Debug.WriteLine("User refuse !");
                    }
                    else
                    {
                        dynamic repo = fb.Get("oauth/access_token?", new
                        {
                            grant_type = "fb_exchange_token",
                            client_id = FacebookApp.AppId,
                            client_secret = FacebookApp.AppSecret,
                            fb_exchange_token = accesstoken
                        });
                          
                        string Laccesstoken = repo.access_token;
                        Debug.WriteLine("Get token sucess !");
                        //go to choose page 2
                        ChoosePage(thisAdd,Laccesstoken, pagedata => {
                            //page sau khi duoc chon
                            ///code here bro
                            ConfigCommnenBoxShapeName(thisAdd, shapename =>
                             {
                                 dynamic da = fb.Get("me?fields=picture.type(large),name");

                                 //dữ liệu của box shape
                                 var fulldata = new
                                 {
                                     PAGETOKEN = (pagedata as dynamic).PAGETOKEN,
                                     PAGENAME = (pagedata as dynamic).PAGENAME,
                                     PAGEIMAGEURL = (pagedata as dynamic).PAGEIMAGEURL,
                                     SHAPEBOXNAME = shapename,
                                     USERNAME = da.name,
                                     USERIMAGEURL = da.picture.data.url,
                                     USERTOKEN = Laccesstoken
                                 };
                                 datafallback(fulldata);
                             });
                        });
                        }
                    }
                    catch (Exception e)
                    {
                       Debug.WriteLine(repose +"||||"+e.ToString());
                    }   

                }, FacebookApp.AppId, FacebookApp.RedrictUri, FacebookApp.Statecode);
            };
            //
        }

        public void ConfigurationUser(object config,Action<object> reponse)
        {
            configurationpanel cfig = new configurationpanel();
            SwithControluse(cfig);
            //cài giá trị chp biến
            cfig.DataConfig = config;
            cfig.DoneBTN.Click += (o, s) =>
            {
                //trả về config mới
                reponse(cfig.DataConfig);
                this.Close();
            };
        }
        public void ChoosePage(ThisAddIn thisAdd,string Longtimeaccesstoken,Action<object> Reponse)
        {
            Debug.WriteLine("Đã vào chọn page ! : long live token " + Longtimeaccesstoken);
            var choosepage = new choosepage();
            SwithControluse(choosepage);
            new Thread(() =>
            {
                //token tamj thoi
                
                //
                dynamic data = CheckFbsdkok("me/accounts?", new
                {
                    fields = "name,picture.type(large),access_token"
                }, Longtimeaccesstoken);
                // trả thẳng dữ liệu về cho người gọi hàm ngày
                choosepage.FillPageContainer((object)data,Reponse);
            })
            { IsBackground = true}.Start();
        }

        public void ConfigCommnenBoxShapeName(ThisAddIn thisAdd,Action<string> reponse)
        {
            Debug.WriteLine(" <Đã vào Name box comment tab >");
            var config = new configpage();
            SwithControluse(config);
            config.Donebtn.Click += (o, s) =>
            {
                reponse(config.ShapeName.TBext);
                this.Close();
            };
            
        }

        public void Logout(Action<string> callback)
        {
            this.Close();
            DialogResult dialog = MessageBox.Show("Do you want to logout ?", "Comment Box Live", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {

                callback("LOGOUT");
            }
            else
            {
                callback("CANCEL");
            }
        }
        private void SwithControluse(UserControl userControl)
        {
            if(this.Controls.Count > 0)
            {
                this.Controls.Clear();
            }
            this.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }
        private NameValueCollection GetQueryParameters(string dataWithQuery)
        {
            dataWithQuery = dataWithQuery.Replace("#", "?");
            NameValueCollection result = new NameValueCollection();
            string[] parts = dataWithQuery.Split('?');
            if (parts.Length > 0)
            {
                string QueryParameter = parts.Length > 1 ? parts[1] : parts[0];
                if (!string.IsNullOrEmpty(QueryParameter))
                {
                    string[] p = QueryParameter.Split('&');
                    foreach (string s in p)
                    {
                        if (s.IndexOf('=') > -1)
                        {
                            string[] temp = s.Split('=');
                            result.Add(temp[0], temp[1]);
                        }
                        else
                        {
                            result.Add(s, string.Empty);
                        }
                    }
                }
            }
            return result;
        }

        private string GetUriParameter(string uri,string varname)
        {
            NameValueCollection dtQueryString = GetQueryParameters(uri);
            string para = dtQueryString[varname];
            return para;
        }
        private dynamic CheckFbsdkok(string uri,object para,string token)
        {
            try
            {
                fb.AccessToken = token;
                var data = fb.Get(uri, para);
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("Please exit app", "App error",MessageBoxButtons.OK);
                Application.Exit();
            }
            return null;
        }
        
        
        #endregion

    }
}
