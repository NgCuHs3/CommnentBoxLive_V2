using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.PowerPoint;
using System.Diagnostics;
using System.Windows.Media;
using System.Threading;
using Facebook;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Net;
using Newtonsoft.Json;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using Color = System.Drawing.Color;

namespace CommnetBoxLive
{
    public partial class ThisAddIn
    {

        private FacebookClient fb;
        private bool hotcheckfbauthen = false;
        #region User PorperTies

        //biến app hoạt động
        private bool perAppOn = false;

        private bool PerAppOn
        {
            get
            {
                return perAppOn;
            }
            set
            {
                perAppOn = value;
                SetIconforOnbtn(value);
            }
        }

        private string PerShapeName = "CommentBox";
        private string PerPageToken = "NULL";
        private string PerPageImageurl = "NULL";
        private string PerPagename = "NULL";
        private string PerMessageAudioPlayTime = "INFINITY";  // mặc đinh là 20 s
        private string PerUserName = "NULL";
        private string PerUserImageurl = "NULL";
        private string PerUserToken = "NULL";
        private bool PerAllowAudio = true;
        private bool PerAllowImage = true;
        private bool PerAllowText = true;
        private bool PerSeprate = false;
        private bool PerCommandCode = false;


        //biến đại diện cho tất cả dữ liệu
      
        private object Configdat
        {
            get {
                return new
                {
                    //trả các biến ra
                    APPON = PerAppOn,
                    USERNAME = PerUserName,
                    USERIMAGE = PerUserImageurl,
                    USERTOKEN = PerUserToken,
                    PAGENAME = PerPagename,
                    PAGEIMAGE = PerPageImageurl,
                    PAGETOKEN = PerPageToken,
                    SOUNDTIME = PerMessageAudioPlayTime,
                    ALLOWAUDIO = PerAllowAudio,
                    ALLOWIMAGE = PerAllowImage,
                    ALLOWTEXT = PerAllowText,
                    ALLOWSEPRATE = PerSeprate,
                    ALLOWCOMMAND = PerCommandCode,
                    SHAPEBOXNAME = PerShapeName
                };
            }
            set
            {
                //cài giá trị vô biến                       
                PerUserName = (value as dynamic).USERNAME ?? PerUserName;
                PerUserImageurl = (value as dynamic).USERIMAGE ?? PerUserImageurl;
                PerUserToken = (value as dynamic).USERTOKEN ?? PerUserToken;
                PerPagename = (value as dynamic).PAGENAME ?? PerPagename;
                PerPageImageurl = (value as dynamic).PAGEIMAGE ?? PerPageImageurl;
                PerPageToken = (value as dynamic).PAGETOKEN ?? PerPageToken;
                PerMessageAudioPlayTime = (value as dynamic).SOUNDTIME ?? PerMessageAudioPlayTime;
                PerAllowAudio = (value as dynamic).ALLOWAUDIO ?? PerAllowAudio;
                PerAllowImage = (value as dynamic).ALLOWIMAGE ?? PerAllowImage;
                PerAllowText = (value as dynamic).ALLOWTEXT ?? PerAllowText;
                PerSeprate = (value as dynamic).ALLOWSEPRATE ?? PerSeprate;
                PerCommandCode = (value as dynamic).ALLOWCOMMAND ?? PerCommandCode;
                PerShapeName = (value as dynamic).SHAPEBOXNAME ?? PerShapeName;
                PerAppOn = (value as dynamic).APPON ?? PerAppOn;
            }
        }

        #endregion
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {

            ConfigAddins();     
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion

        #region Setup
        private void ConfigAddins()
        {
            ReadConfig();
            fb = new FacebookClient();
            infofill();
            Globals.Ribbons.mribbon.OnCommandClick += Mribbon_OnCommandClick;
            NetworkChange.NetworkAvailabilityChanged += NetworkChange_NetworkAvailabilityChanged; ;
            Application.SlideShowNextSlide += GetCurentSlide;
            Application.SlideShowBegin += Application_SlideShowBegin;
            Application.SlideShowEnd += Application_SlideShowEnd;
        }

 
        #region file config
        private void SaveConfig()
        {
            string fileconfig = GetWkdir() + @"\Documents\CommentBoxLive\config\commentbox.config";
            string dirconfig = GetWkdir() + @"\Documents\CommentBoxLive\config\";
            //tạo dữ liệu
            dynamic dat = Configdat as dynamic;
            string jsondata = JsonConvert.SerializeObject(dat);

            //tạo file
            if (!Directory.Exists(dirconfig))
            {
                Directory.CreateDirectory(dirconfig);
            }
            FileStream f = File.Create(fileconfig);
            StreamWriter wd = new StreamWriter(f);
            wd.Write(jsondata);
            wd.Close();
            Debug.WriteLine("Đã lưu config : " + jsondata);
        }
        private void ReadConfig()
        {
            string fileconfig = GetWkdir()+ @"\Documents\CommentBoxLive\config\commentbox.config";
            if (File.Exists(fileconfig))
            {
                StreamReader rd = new StreamReader(fileconfig);
                string jsondata = rd.ReadToEnd();
                rd.Close();
                dynamic dat = JsonConvert.DeserializeObject(jsondata);
                Configdat = dat as object;
            }
            else
            {
                SaveConfig();
            }
        }
        #endregion

        private void Application_SlideShowEnd(Presentation Pres)
        {
            if (!PerAppOn) return;
            //dừng nghe tin nhaăn
            StopListenMessage();
        }

        private void Application_SlideShowBegin(SlideShowWindow Wn)
        {
            if (!PerAppOn) return;
            //thêm thằng hanlder vào cho event listen message
            NewMessageHandler hlm = (textmessage, imageurlattachment) =>
            {
                SetTextContentForShape(PerShapeName, textmessage, imageurlattachment);
            };
            //tranh event bị add nhiều lần nghe tin nhắn với ảnh
            OnReciveNewMessage -= hlm;
            OnReciveNewMessage += hlm;
            //handler audio
            NewAudioHandler alm = (audiourl) =>
            {
                PlayAudioMessage(audiourl,PerMessageAudioPlayTime);
            };
            //nghe vent chơi audio tệp
            OnReciveNewAudio -= alm;
            OnReciveNewAudio += alm;
            //nghe tin  
            ListenMessageWorker(PerPageToken);
        }

        private void GetCurentSlide(SlideShowWindow Wn)
        {
            currentshowslideindex = Wn.View.Slide.sectionIndex;
        }


        private int currentshowslideindex;

        private void infofill()
        {
            hotcheckfbauthen = IsTokenValid(PerUserToken);
            SetIconForFacebookPageButton(PerPageImageurl, PerPagename);
        }
        private void Mribbon_OnCommandClick(object btn)
        {
            //kiem tra user dang nhap hay chua
            if(!NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("We need the internet connection ,please !" , "ERROR");
                return;
            }
            if (!hotcheckfbauthen)
            {
                new ffm().QuickStartnow(this, (fulldata) => {

                    string pagetoken = (fulldata as dynamic).PAGETOKEN;
                    string pagename = (fulldata as dynamic).PAGENAME;
                    string shapename = (fulldata as dynamic).SHAPEBOXNAME;
                    string imageurl = (fulldata as dynamic).PAGEIMAGEURL;

                    Debug.WriteLine("ALL DONE !  \n" + pagetoken +
                        "\n" + pagename + "\n" + shapename + "\n" + imageurl
                        );
                    //cài vào biết toàn cục
                    PerShapeName = shapename;
                    PerPageToken = pagetoken;
                    PerPageImageurl = imageurl;
                    PerPagename = pagename;
                    PerUserName = (fulldata as dynamic).USERNAME;
                    PerUserImageurl = (fulldata as dynamic).USERIMAGEURL;
                    PerUserToken = (fulldata as dynamic).USERTOKEN;
                    //lưu config                  
                    infofill();
                    PerAppOn = true;
                    SaveConfig();
                    //cài ảnh và fb icon
                    /*
                     * CÀI VALUE
                     */
                    Slide slide = Getselectedslide(); if (slide == null) return;
                    ClearShapeInslid(slide, PerShapeName);
                    ClearShapeInslid(slide, PerShapeName + ".PICTURE");
                    InsertShape(slide,shapename, "\"This will be message ! \n " +
                    "You should copy this shape for orther slide and reformat it ." +
                    " now enjoy PowerPoint :)\" \n " +
                     "--Comment Box Live--");
                    //tạo shape
                   
                    DialogResult rel = MessageBox.Show("Do you want start present right now ?", "Start", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rel == DialogResult.Yes)
                    {
                        Globals.ThisAddIn.Application.ActivePresentation.SlideShowSettings.Run();
                    }

                });
            }
            else
            {
                //voi truong token valid
                RibbonButton bt = btn as RibbonButton;
                switch (bt.Name)
                {
                    case "quickstartbtn":
                        PerAppOn = !PerAppOn;
                        SaveConfig();
                        break;
                    case "insertbtn": //insert shape
                        //xoa may cai cu di
                        Slide slide = Getselectedslide(); if (slide == null) return;
                        ClearShapeInslid(slide, PerShapeName);
                        ClearShapeInslid(slide, PerShapeName + ".PICTURE");
                        if (PerSeprate)
                        {//neeus
                            Shape box = InsertShape(slide, PerShapeName, "Text will here \n --CMBL--",120,100);
                            Shape picture = InsertShape(slide, PerShapeName + ".PICTURE", "Picture will here \n --CMBL--", box.Left + box.Width,box.Top);
                        }
                        else
                        {//neu 
                            InsertShape(slide, PerShapeName, "\"This will be message ! \n " +
                           "You should copy this shape for orther slide and reformat it ." +
                           " now enjoy PowerPoint :)\" \n " +
                            "--Comment Box Live--");
                        }
                        break;
                    case "configbtn": //cofiguration
                        new ffm().ConfigurationUser(Configdat, reps =>
                        {
                            dynamic rep = reps as dynamic;
                            PerUserName = rep.USERNAME;
                            PerUserImageurl = rep.USERIMAGE;
                            PerPagename = rep.PAGENAME;
                            PerPageImageurl = rep.PAGEIMAGE;
                            PerShapeName = rep.SHAPEBOXNAME;
                            PerAllowText = rep.ALLOWTEXT;
                            PerAllowImage = rep.ALLOWIMAGE;
                            PerAllowAudio = rep.ALLOWAUDIO;
                            PerSeprate = rep.ALLOWSEPRATE;
                            PerCommandCode = rep.ALLOWCOMMAND;
                            SaveConfig();
                        });
                        break;
                    case "helpbtn":
                        break;
                    case "fbpagebtn":
                        new ffm().Logout((res) =>
                        {
                            if (res == "CANCEL") return;
                            PerUserToken = "NULL";
                            PerPageImageurl = "NULL";
                            PerPagename = "NULL";
                            infofill();
                            PerAppOn = false;
                            SaveConfig();
                        });
                        break;
                    default:
                        break;
                }
            }   
        }

        private void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            if (e.IsAvailable)
            {
                Debug.WriteLine("Network connected! and check authention");
               
            }
            else
            {
               
                Debug.WriteLine("Network dis connected!");
            }
            infofill();
        }
      
        private bool IsTokenValid(string token)
        {
            try
            {
                dynamic fl = fb.Get("oauth/access_token_info?", new { client_id=FacebookApp.AppId, access_token = token });
                string tk = fl.access_token;
                if (tk == null) return false;
                return true;
            }
           catch (Exception)
            {
                return false;
            }
        }
        #region KO BIET NOI GI
        public Shape InsertShape(Slide slide,string ShapeName, string text, float left = 300, float top = 200)
        {
            Shape box = slide.Shapes.AddShape(Office.MsoAutoShapeType.msoShapeRectangle,left,top,400, 200);
            box.Name = ShapeName;

            box.TextEffect.Text = text;
            
            box.Fill.ForeColor.RGB = 0x230A0A;
            box.Line.ForeColor.RGB = 0xBDFFCB;
            box.Line.Weight = 4;
            return box;
        }
        private void SetIconForFacebookPageButton(string imageurl,string pagename)
        {
            try
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                // your path to image might be different
                image.UriSource = new Uri(imageurl);
                image.EndInit();
                Globals.Ribbons.mribbon.fbpagebtn.Label = pagename;
                Globals.Ribbons.mribbon.fbpagebtn.Image = Image.FromStream(GetStreamFromUrl(imageurl));
            }
            catch (Exception)
            {
                Globals.Ribbons.mribbon.fbpagebtn.Image = (Image)Properties.Resources.closebtnp;
            }         
        }

        private void SetIconforOnbtn(bool status)
        {
            try
            {
                Image image;
                string text;
                if (!status)
                {
                    image = ((System.Drawing.Image)(Properties.Resources.startbtn));
                    text = "QuickStart Now";
                }
                else
                {
                    image = ((System.Drawing.Image)(Properties.Resources.stopbtn));
                    text = "StopBox Live";
                }
                Globals.Ribbons.mribbon.quickstartbtn.Image = image;
                Globals.Ribbons.mribbon.quickstartbtn.Label = text;
            }
            catch (Exception)
            {
            }
        
        }

        private string GetWkdir()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }
        private static Stream GetStreamFromUrl(string url)
        {
            try
            {
                byte[] imageData = null;

                using (var wc = new System.Net.WebClient())
                    imageData = wc.DownloadData(url);

                return new MemoryStream(imageData);
            }
            catch (Exception)
            {
                return (Stream) new MemoryStream(BitmapToBytes(Properties.Resources.closebtn));
            } 
        }
        public static byte[] BitmapToBytes(Bitmap Bitmap)
        {
            MemoryStream ms = null;
            try
            {
                ms = new MemoryStream();
                Bitmap.Save(ms, Bitmap.RawFormat);
                byte[] byteImage = new Byte[ms.Length];
                byteImage = ms.ToArray();
                return byteImage;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            finally
            {
                ms.Close();
            }
        }
        #endregion

        #region XỬ LÝ CÔNG VIỆC NGẦM
        private void SetTextContentForShape(string shapeName, string text,object imageurlattachment)
        {
            new Thread(() =>
            {
                try
                {
                    Slide slide = Globals.ThisAddIn.Application.SlideShowWindows[currentshowslideindex].View.Slide;

                    Shape boxlive = GetShapeByName(slide, shapeName)?.First();
                    if (boxlive != null)
                    {
                        string imageurl = (imageurlattachment as dynamic).URL;
                        string type = (imageurlattachment as dynamic).TYPE;



                        if (text != null && IsCodeMesage(text) && PerCommandCode)
                        {
                            ParameterCommand(boxlive, text);
                            return;
                        }
                        else
                        {
                            if (text != "" && PerAllowText)
                            {
                                boxlive.TextEffect.Text = text;
                                Debug.WriteLine("Text gắn cho shape : " + text + (imageurl != "NOIMAGE" ? ("\n --> nền shape (type: " + type + " ): " + imageurl) : ""));
                            }
                        }

                        //kiểm tra ảnh có bị null ko
                        if (imageurl == "NOIMAGE") return;
                        switch (type)
                        {
                            case "image/jpeg":
                                SetGifForShape(boxlive, imageurl);
                                break;
                            case "image/gif":
                                SetGifForShape(boxlive, imageurl);
                                break;
                            case "STICKER":
                                SetGifForShape(boxlive, imageurl);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Không tìm được shape !");
                    }
                }
                catch (Exception)
                {
                }
            })
          .Start();
        }

        #region COMMAND COMMAND (CHEAT CODE)
        private void ParameterCommand(Shape shape,string code)
        {
            Regex reg = new Regex(@"(?<cmd>-\w+)(\s+|$)(?<arg>\w+|\d+|$)?");
            foreach (Match item in reg.Matches(code))
            {
                string command = item.Groups["cmd"].ToString().Trim();
                string args = item.Groups["arg"].ToString().Trim();
                DoCommand(shape,command, args);
            }
        }
        private void DoCommand(Shape shape,string cmd,string arg)
        {
            try
            {
                switch (cmd)
                {
                    case "-hello":
                        break;
                    case "-university":
                        break;
                    case "-repeat":
                        string csarg = arg;
                        arg = "RE: " + arg;
                        for (int i = 0; i < 10; i++)
                        {
                            arg += " " + csarg;
                        }
                        SetTextContentForShape(shape.Name, arg, new { URL = "NULL", TYPE = "NOIMAGE" });
                        break;
                    case "-random":
                        break;
                    case "-lactroi":
                        PlayAudioMessage(Properties.Resources.lactroisong, PerMessageAudioPlayTime);
                        break;
                    case "-omfg":
                        PlayAudioMessage(Properties.Resources.omfgsong, PerMessageAudioPlayTime);
                        break;
                    case "-next":
                        Application.SlideShowWindows[currentshowslideindex].View.Next();
                        break;
                    case "-back":
                        Application.SlideShowWindows[currentshowslideindex].View.Previous();
                        break;
                    case "-end":
                        Application.SlideShowWindows[currentshowslideindex].View.Exit();
                        break;
                    case "-fill":

                        Color color = Color.FromName(FirstLetterToUpper(arg.Trim().ToLower()));
                        Slide slide = Application.SlideShowWindows[currentshowslideindex].View.Slide;
                        slide.FollowMasterBackground = Office.MsoTriState.msoFalse;
                        slide.Background.Fill.ForeColor.RGB = System.Drawing.ColorTranslator.ToOle(color);

                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

                Debug.WriteLine("Có lỗi khi dùng command cheat !");
            }
          
        }
        public string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        #endregion


        private bool IsCodeMesage(string msg)
        {

            if (msg.ToUpper().StartsWith("+CMB")) return true;
            return false;
        }

        private void PlayAudioMessage(string audioURL,string Playtime)
        {
            if (audioURL == "NOAUDIO" || !PerAllowAudio ) return;
            
            new Thread(() =>
            {
                Debug.WriteLine("Đang chơi audio from ... \n  --> : " + audioURL);
                var url = audioURL;
                
                using (var mf = new MediaFoundationReader(url))
                using (var wo = new WaveOutEvent())
                {
          
                    int playtime = Int32.MaxValue;
                    try
                    {
                        playtime = Int32.Parse(Playtime);
                    }
                    catch (Exception)
                    {
                        playtime = Int32.MaxValue;
                    }
                    //đến giây audio được chơi

                    wo.Init(mf);
                    wo.Play();

                    int couter = 0;

                    while (wo.PlaybackState == PlaybackState.Playing)
                    {
                        if(couter < playtime)
                        {
                            couter++;
                        }
                        else
                        {
                            wo.Stop();
                        }
                        Thread.Sleep(1000);
                    }
                }
            })
            { IsBackground = true }.Start();
        }

        private void ListenMessageWorker(string pagetoken)
        {
            Debug.WriteLine("Bắt đầu nghe tin nhắn");
            isWannaStop = false;
            //cài biến stop
            new Thread(() =>
            {
                string messageidold = "FIRSTTIME";

                while (!isWannaStop)
                {
                    try
                    {
                        /* LẤY TIN NHẮN MỚI NHẤT TỪ FACEBOOK TIN NHẮN ĐẦU TIÊN VÀ CHECK TIN NHẮN ĐÓ
                         */
                        
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        //lỗi ngầm ko xác đinh
                        dynamic repl = fb.Get("me?fields=conversations.limit(1){messages.limit(1){message,attachments,sticker}}",
                                                 new
                                                 {
                                                     access_token = pagetoken
                                                 });
                        stopwatch.Stop();
                        string messageid = repl.conversations.data[0].messages.data[0].id;
                      
                        Debug.WriteLine("Time rest API message : " + stopwatch.Elapsed);
                        if (messageidold == "FIRSTTIME")
                        {
                            //cài message id mới vào
                            messageidold = messageid;
                            continue;
                        }
                        else
                        {
                            if (messageidold != messageid)
                            {
                                messageidold = messageid;
                                string messagecontent = repl.conversations.data[0].messages.data[0].message;
                                string imageattachmenturl = "NOIMAGE";
                                string audioattachmenturl = "NOAUDIO";
                                string imageattachmenttype = "NULLTYPE";

                                try
                                {
                                    //với trường hợp tin nhắn  có ảnh
                                    imageattachmenturl = repl.conversations.data[0].messages.data[0].attachments.data[0].image_data.url;
                                    imageattachmenttype = repl.conversations.data[0].messages.data[0].attachments.data[0].mime_type;                                        
                                    if (imageattachmenturl == null) throw new Exception("NULL file");
                                }
                                catch (Exception)
                                {
                                    try
                                    {
                                        imageattachmenturl = repl.conversations.data[0].messages.data[0].sticker;
                                        imageattachmenttype = "STICKER";
                                        if (imageattachmenturl == null) throw new Exception("NULL file");
                                    }
                                    catch (Exception)
                                    {
                                        imageattachmenturl = "NOIMAGE";
                                    }               
                                }
                                //audio

                                try
                                {
                                    //với trường họp  có audio
                                    audioattachmenturl = repl.conversations.data[0].messages.data[0].attachments.data[0].file_url;
                                    if (audioattachmenturl == null) throw new Exception("NULL file");
                                }
                                catch (Exception)
                                {
                                    audioattachmenturl = "NOAUDIO";
                                }
                               

                                if (OnReciveNewAudio != null) OnReciveNewAudio(audioattachmenturl);
                                //Event reciver new massage
                                if (OnReciveNewMessage != null) OnReciveNewMessage(messagecontent, 
                                    new { URL=imageattachmenturl,TYPE = imageattachmenttype });
                                //

                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine("Get message lỗi :" + e);
                    }
                }
            })
            .Start();
            
        }

        private void SetGifForShape(Shape shape,string gifurl)
        {
            try
            {
                Slide slide = Globals.ThisAddIn.Application.SlideShowWindows[currentshowslideindex].View.Slide;

                //tải gif về trước

                //thêm 1 cái picture ở dưới để chạy gif
                string giffolder = GetWkdir() + @"\Documents\CommentBoxLive\gif\";
                string gifname =
                    +DateTime.Now.Day + "_"
                    + DateTime.Now.Month + "_"
                    + DateTime.Now.Year + "_"
                    + DateTime.Now.Hour + "_"
                    + DateTime.Now.Minute + "_"
                    + DateTime.Now.Second + ".gif";
                //
                string ShapePicturename = shape.Name + ".PICTURE";
                DowloadFile(gifurl, giffolder, gifname, (filename) =>
                {
                    if (PerSeprate)
                    {
                        Shape picture = GetShapeByName(slide, ShapePicturename)?.First();
                        if (picture == null) return;
                        var pc = slide.Shapes.AddPicture(filename, Office.MsoTriState.msoTrue
                            , Office.MsoTriState.msoTrue, picture.Left, picture.Top, picture.Width, picture.Height);
                        pc.Name = picture.Name;
                        picture.Delete();
                    }
                    else
                    {
                        var ls = GetShapeByName(slide, ShapePicturename);
                        if (ls != null)
                        {
                            foreach (var item in ls)
                            {
                                item.Delete();
                            }
                        }
                        shape.Fill.Transparency = 1f;
                        Shape img = slide.Shapes.AddPicture(filename, Office.MsoTriState.msoTrue, Office.MsoTriState.msoTrue, shape.Left,
                        shape.Top, shape.Width, shape.Height);
                        img.Name = ShapePicturename;
                        img.ZOrder(Office.MsoZOrderCmd.msoSendBackward);
                    }
                    //set nó vào chung nóm
                });
            }
            catch (Exception)
            {
            }
           
        } 

        private void DowloadFile(string fileLink,string savefolder,string filename,Action<string> dowloadone)
        {
            try
            {
                using (var client = new WebClient())
                {
                    if (!Directory.Exists(savefolder))
                    {
                        Directory.CreateDirectory(savefolder);
                    }
                    Debug.WriteLine("Dowloading waiting... \n-- > " + fileLink + "-- > " + filename+"\n");
                    client.DownloadFile(fileLink, savefolder + filename);
                    Debug.WriteLine("Dowloaded  success | \n --> "  + fileLink + " --> " + filename + "\n");
                    dowloadone(savefolder + filename);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("ERR dowload file from ... \n --> ",fileLink+" -X> "+filename + " Reseon |  "+e );
            }
        
        }

        private Slide Getselectedslide()
        {
            try
            {
                Slide slide = Application.ActiveWindow.View.Slide;
                return slide;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private void ClearShapeInslid(Slide slide,string shapename)
        {
            try
            {
                 List<Shape> Sh = GetShapeByName(slide, shapename);
            if (Sh == null) return;
            foreach (var item in Sh)
            {
                item.Delete();
            }
            }
            catch (Exception)
            {
            }
        }
        private List<Shape> GetShapeByName(Slide slide,string ShapeName)
        {
            List<Shape> ls = new List<Shape>();
            foreach (Shape item in slide.Shapes)
            {
                if (item.Name == ShapeName) ls.Add(item);
            }
            if (ls.Count == 0) return null;
            return ls;
        }

        private static bool isWannaStop = false;
        private void StopListenMessage()
        {
            Debug.WriteLine("Đã dừng nghe tin nhắn");
            isWannaStop = true;
        }

        #endregion

        #region Event
        private delegate void NewMessageHandler(string messagetext,object imageattachmenturl);
        private event NewMessageHandler OnReciveNewMessage;
        private delegate void NewAudioHandler(string audioURL);
        private event NewAudioHandler OnReciveNewAudio;
        #endregion

       
        #endregion
    }
    public static class ColorConverterExtensions
    {
        public static string ToHexString(this Color c) => $"#{c.R:X2}{c.G:X2}{c.B:X2}";

        public static string ToRgbString(this Color c) => $"RGB({c.R}, {c.G}, {c.B})";
    }
}
