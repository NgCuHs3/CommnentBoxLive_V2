using Facebook;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommnetBoxLive
{
    public partial class mewebview : Form
    {

        private FacebookClient fb;
        public mewebview()
        {
            InitializeComponent();
        }
        public async void LoginFb(Action<string> reponse, string Appid, string redricturi, string code = "2222")
        {
            fb = new FacebookClient();
            var loginurl = fb.GetLoginUrl(new
            {
                client_id = FacebookApp.AppId,
                redirect_uri = FacebookApp.RedrictUri,
                state = FacebookApp.Statecode,
                response_type = "token"
            });
            /**/
            var env = await CoreWebView2Environment.CreateAsync(null, GetWkdir()+ @"\Documents\CommentBoxLive\Webdata");
            /*ddoanwj code sieu quan trong*/
            await webView21.EnsureCoreWebView2Async(env);
            webView21.CoreWebView2.Navigate(loginurl.AbsoluteUri);
            //adasdadds
            FormClosedEventHandler usecloe = (o, s) =>
            {  
                reponse("Error!" + s.CloseReason);
            };
            webView21.NavigationCompleted += (o, s) =>
            {
                string checkurl = (o as WebView2).Source.ToString();
                if (checkurl.StartsWith(redricturi))
                {
                    this.FormClosed -= usecloe;
                    this.Close();
                    reponse(checkurl);
                }
            };
            //handle when close
            this.FormClosed += usecloe;
            this.Show();
        }

        private string GetWkdir()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }
 
    }
}
