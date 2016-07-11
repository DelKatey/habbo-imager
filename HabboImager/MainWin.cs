using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Arav_Imager
{
    public partial class HabboImager : Form
    {
        private const string habboCharURL1 = "http://www.habbo";
        private const string habboCharURL2 = "/habbo-imaging/avatarimage?hb=img&user=";
        private string habboCountry = ".com";
        private const string habboGesture1 = "&gesture=";
        private string habboGesture2 = "";
        private const string habboAction1 = "&action=";
        private string habboAction2 = "";
        private string habboAction3 = "";
        private string strFileNameHI = "";
        private const string habboFormat1 = "&img_format=";
        private string habboFormat2 = "&img_format=gif";
        private const string habboDirection1 = "&direction=";
        private string habboDirection2 = "&direction=2";
        private const string habboHDirection1 = "&head_direction=";
        private string habboHDirection2 = "&head_direction=2";
        private int habboDirection3 = 2, habboHDirection3 = 2;
        private const string habboSize1 = "&size=";
        private string habboSize2 = "&size=m";
        private string strHabboName = "";
        private string strFilter = "GIF|*.gif";
        //private string strMIMEType = "image/gif";
        private string strType = "gif";
        private ImageFormat imgF = ImageFormat.Gif;
        private string strImgDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);// + "\\Arav Imager";
        Image imgStore;
        readonly CookieContainer cookiecontainer = new CookieContainer();

        public HabboImager()
        {
            InitializeComponent();
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (countryComboBox.Text == "Brazil")
                habboCountry = ".com.br";
            else if (countryComboBox.Text == "Denmark")
                habboCountry = ".dk";
            else if (countryComboBox.Text == "Finland")
                habboCountry = ".fi";
            else if (countryComboBox.Text == "France")
                habboCountry = ".fr";
            else if (countryComboBox.Text == "Germany")
                habboCountry = ".de";
            else if (countryComboBox.Text == "Italy")
                habboCountry = ".it";
            else if (countryComboBox.Text == "Netherlands")
                habboCountry = ".nl";
            else if (countryComboBox.Text == "Norway")
                habboCountry = ".no";
            else if (countryComboBox.Text == "Spain")
                habboCountry = ".es";
            else if (countryComboBox.Text == "Sweden")
                habboCountry = ".se";
            else
                habboCountry = ".com";
        }

        private void actionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actionComboBox.Text == "Drinking")
                habboAction2 = "drk=1";
            else if (actionComboBox.Text == "Hold Drink (blue)")
                habboAction2 = "crr=1";
            else if (actionComboBox.Text == "Hold: Carrot")
                habboAction2 = "crr=2";
            else if (actionComboBox.Text == "Hold: Icecream")
                habboAction2 = "crr=3";
            else if (actionComboBox.Text == "Hold: Cola")
                habboAction2 = "crr=5";
            else if (actionComboBox.Text == "Hold: Coffee")
                habboAction2 = "crr=6";
            else if (actionComboBox.Text == "Hold: Pink potion")
                habboAction2 = "crr=9";
            else if (actionComboBox.Text == "Hold: Calippo icecream")
                habboAction2 = "crr=33";
            else if (actionComboBox.Text == "Hold: Japanese tea")
                habboAction2 = "crr=42";
            else if (actionComboBox.Text == "Hold: red glass")
                habboAction2 = "crr=43";
            else if (actionComboBox.Text == "Hold: green glass")
                habboAction2 = "crr=44";
            else if (actionComboBox.Text == "Hold: Bubbles")
                habboAction2 = "crr=667";
            else if (actionComboBox.Text == "Eat: Carrot")
                habboAction2 = "drk=2";
            else if (actionComboBox.Text == "Eat: Icecream")
                habboAction2 = "drk=3";
            else if (actionComboBox.Text == "Eat: Calippo Icecream")
                habboAction2 = "drk=33";
            else if (actionComboBox.Text == "Drink: Cola")
                habboAction2 = "drk=5";
            else if (actionComboBox.Text == "Drink: Coffee")
                habboAction2 = "drk=6";
            else if (actionComboBox.Text == "Drink: Pink potion")
                habboAction2 = "drk=9";
            else if (actionComboBox.Text == "Drink: Japanese tea")
                habboAction2 = "drk=42";
            else if (actionComboBox.Text == "Drink: red glass")
                habboAction2 = "drk=43";
            else if (actionComboBox.Text == "Drink: green glass")
                habboAction2 = "drk=44";
            else if (actionComboBox.Text == "Drink: Bubbles")
                habboAction2 = "drk=667";
            else if (actionComboBox.Text == "-------------")
            {
                actionComboBox.Text = "None";
                MessageBox.Show("Please select something else, you cannot choose a separator!", "Error");
            }
            else
                habboAction2 = "";
        }

        private void gestureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gestureComboBox.Text == "Smile")
                habboGesture2 = habboGesture1 + "sml";
            else if (gestureComboBox.Text == "Sad")
                habboGesture2 = habboGesture1 + "sad";
            else if (gestureComboBox.Text == "Speak")
                habboGesture2 = habboGesture1 + "spk";
            else if (gestureComboBox.Text == "Eyes closed")
                habboGesture2 = habboGesture1 + "eyb";
            else if (gestureComboBox.Text == "Angry")
                habboGesture2 = habboGesture1 + "agr";
            else if (gestureComboBox.Text == "Surprised")
                habboGesture2 = habboGesture1 + "srp";
            else
                habboGesture2 = "";
        }

        private void countryComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void actionComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void gestureComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void formatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            habboFormat2 = habboFormat1 + formatComboBox.Text.ToLower();
        }

        private void formatComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #region Builder code thanks to rene @ stackoverflow
        private HttpWebResponse Builder(string url, string host, NameValueCollection cookies)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = WebRequestMethods.Http.Get;
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            // _request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip,deflate,sdch");
            request.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8");
            request.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0");

            request.Host = host;
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.146 Safari/537.36";

            request.CookieContainer = cookiecontainer;

            if (cookies != null)
            {
                foreach (var cookiekey in cookies.AllKeys)
                {
                    request.CookieContainer.Add(
                        new Cookie(
                            cookiekey,
                            cookies[cookiekey],
                            @"/",
                            host));
                }
            }
            return (HttpWebResponse)request.GetResponse();
        }

        // find in the html and return the three parameters in a string array
        // setCookie('YPF8827340282Jdskjhfiw_928937459182JAX666', '127.0.0.1', 10);
        private static string[] Parse(Stream _stream, string encoding)
        {
            const string setCookieCall = "setCookie('";

            // copy html as string
            var ms = new MemoryStream();
            _stream.CopyTo(ms);
            var html = Encoding.GetEncoding(encoding).GetString(ms.ToArray());

            // find setCookie call
            var findFirst = html.IndexOf(
                setCookieCall,
                StringComparison.InvariantCultureIgnoreCase) + setCookieCall.Length;
            var last = html.IndexOf(");", findFirst, StringComparison.InvariantCulture);

            var setCookieStatmentCall = html.Substring(findFirst, last - findFirst);
            // take the parameters
            var parameters = setCookieStatmentCall.Split(new[] { ',' });
            for (int x = 0; x < parameters.Length; x++)
            {
                // cleanup
                parameters[x] = parameters[x].Replace("'", "").Trim();
            }
            return parameters;
        }
        #endregion

        private void genButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                bool NetworkAvailability = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
                if (NetworkAvailability)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    strHabboName = nameTextBox.Text;
                    strType = formatComboBox.Text.ToLower();
                    strFilter = formatComboBox.Text.ToUpper() + "|*." + formatComboBox.Text.ToLower();
                    if (formatComboBox.Text.ToLower() == "gif")
                        imgF = ImageFormat.Gif;
                    else if (formatComboBox.Text.ToLower() == "png")
                        imgF = ImageFormat.Png;
                    Directory.CreateDirectory(strImgDirectory);

                    if (!wavCheckBox.Checked && actionComboBox.Text == "None")
                    {
                        if (noneRadioButton.Checked)
                            habboAction3 = "";
                        else if (walkRadioButton.Checked)
                            habboAction3 = habboAction1 + "wlk";
                        else if (layRadioButton.Checked)
                            habboAction3 = habboAction1 + "lay";
                        else if (sitRadioButton.Checked)
                            habboAction3 = habboAction1 + "sit";
                    }
                    else if (wavCheckBox.Checked && actionComboBox.Text == "None")
                    {
                        if (noneRadioButton.Checked)
                            habboAction3 = habboAction1 + "wav";
                        else if (walkRadioButton.Checked)
                            habboAction3 = habboAction1 + "wlk,wav";
                        else if (layRadioButton.Checked)
                            habboAction3 = habboAction1 + "lay,wav";
                        else if (sitRadioButton.Checked)
                            habboAction3 = habboAction1 + "sit,wav";
                    }
                    else if (!wavCheckBox.Checked && actionComboBox.Text != "None")
                    {
                        if (noneRadioButton.Checked)
                            habboAction3 = habboAction1 + habboAction2;
                        else if (walkRadioButton.Checked)
                            habboAction3 = habboAction1 + "wlk," + habboAction2;
                        else if (layRadioButton.Checked)
                            habboAction3 = habboAction1 + "lay," + habboAction2;
                        else if (sitRadioButton.Checked)
                            habboAction3 = habboAction1 + "sit," + habboAction2;
                    }
                    else if (wavCheckBox.Checked && actionComboBox.Text != "None")
                    {
                        if (noneRadioButton.Checked)
                            habboAction3 = habboAction1 + "wav," + habboAction2;
                        else if (walkRadioButton.Checked)
                            habboAction3 = habboAction1 + "wlk,wav," + habboAction2;
                        else if (layRadioButton.Checked)
                            habboAction3 = habboAction1 + "lay,wav," + habboAction2;
                        else if (sitRadioButton.Checked)
                            habboAction3 = habboAction1 + "sit,wav," + habboAction2;
                    }

                    string tempURL = habboCharURL1 + habboCountry + habboCharURL2 + strHabboName + habboAction3 + habboDirection2 + habboHDirection2 + habboGesture2 + habboSize2 + habboFormat2;

                    var cookies = new NameValueCollection();

                    try
                    {
                        for (int tries = 0; tries < 2; tries++)
                        {
                            using (var response = Builder(tempURL, "www.habbo" + habboCountry, cookies))
                            {
                                using (var stream = response.GetResponseStream())
                                {
                                    string contentType = response.ContentType.ToLowerInvariant();
                                    if (contentType.StartsWith("text/html"))
                                    {
                                        var parameters = Parse(stream, response.CharacterSet);
                                        cookies.Add(parameters[0], parameters[1]);
                                    }
                                    if (contentType.StartsWith("image"))
                                    {
                                        imgStore = Image.FromStream(stream);
                                        string contentDispType = response.ContentType;
                                        charPictureBox.Image = imgStore;//Image.FromStream(stream);
                                        break; // we're done, get out
                                    }
                                }
                            }
                        }


                        //HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(tempURL);
                        //request.Method = WebRequestMethods.Http.Get;
                        //request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                        //request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip,deflate,sdch");
                        //request.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8");
                        //request.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0");

                        //if (countryComboBox.Text == "International")
                        //{
                        //    request.Headers.Set(HttpRequestHeader.Cookie, "__qca=P0-1414519479-1388853469318;" +
                        //        "__utma=78068493.317843091.1388824624.1403978330.1404547185.150; __utmc=78068493;" +
                        //        "__utmz=78068493.1404547185.150.16.utmcsr=habbo.com|utmccn=(referral)|utmcmd=referral|utmcct=/;" +
                        //        "_em_hl=1; _em_vt=1e723fe24d210b3d0a46bea8e96d52b193e0591bf9-5500476253b7b098; CfP=1; CS1=2;" +
                        //        "JEB2=52B18E7A6E651C8C96E91E36F00FF223; optimizelyBuckets=%7B%7D; optimizelyEndUserId=oeu1387369441734r0.682829003315419;" +
                        //        "optimizelySegments=%7B%22194781750%22%3A%22gc%22%2C%22194877421%22%3A%22search%22%2C%22194881741%22%3A%22false%22%7D;" +
                        //        "browser_token=2da7724f40b818b081a3156a828317a60be3e2e5c86748e4e8a291b8c6695634;" +
                        //        "GED_PLAYLIST_ACTIVITY=[{\"u\":\"LvgM\",\"t\":1396559023,\"ed\":\"_tt6937_bs10_ed0c3m3867_ed1c2_ed3m341_ed4c2m1324_ed5m6165c6_es0\",\"nv\":1,\"pl\":6937}];" +
                        //        "JSESSIONID=E52A89E0B42883D6B44DC8D4173827CC.resin-fe-5; lec=\"HABBO,140454720096993605,http://www.habbo.com/me\"; mc=pKSk; pc=\"RkJMSUs6Ojo6Ojo=\";" +
                        //        "SLID=140454720096993605.0; xwindow_comm=pong; YPF8827340282Jdskjhfiw_928937459182JAX666=119.74.62.207");
                        //}
                        //request.Host = "www.habbo" + habboCountry;
                        //request.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.146 Safari/537.36";

                        //using (WebResponse response = request.GetResponse())
                        //using (Stream stream = response.GetResponseStream())
                        //{
                        //    Image tIMG = Image.FromStream(stream);
                        //    bmpStore = new Bitmap(tIMG);
                        //    //bmpStore = new Bitmap(resultImage);
                        //    string contentType = response.ContentType;
                        //    /*
                        //    // TODO: examine the content type and decide how to name your file

                        //    // Download the file
                        //    Stream file = File.Create(strImgDirectory + "\\avatarimage." + formatComboBox.Text.ToLower());
                        //    {
                        //        // Remark: if the file is very big read it in chunks
                        //        // to avoid loading it into memory
                        //        byte[] buffer = new byte[response.ContentLength];
                        //        stream.Read(buffer, 0, buffer.Length);
                        //        file.Write(buffer, 0, buffer.Length);
                        //    }
                        //    */
                        //    charPictureBox.Image = bmpStore;
                        //}
                    }
                    catch
                    {
                        MessageBox.Show("The Habbo whose image you requested does not exist!", "Habbo Imager");
                    }
                    Cursor.Current = Cursors.Default;
                }
                else
                    MessageBox.Show("You are not connected to the Internet!", "Habbo Imager");
            }
            else
                MessageBox.Show("Habbo Name cannot be left empty!", "Habbo Imager");
        }

        private void lRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lRadioButton.Checked)
                habboSize2 = habboSize1 + "l";
        }

        private void mRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mRadioButton.Checked)
                habboSize2 = habboSize1 + "m";
        }

        private void sRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sRadioButton.Checked)
                habboSize2 = habboSize1 + "s";
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveButton.PerformClick();
        }

        private void body_rotateright_PictureBox_Click(object sender, EventArgs e)
        {
            if (habboDirection3 >= 2)
                habboDirection3--;
            else
                habboDirection3 = 8;

            habboDirection2 = habboDirection1 + habboDirection3;

            if (habboDirection3 == 1)
                bodyPictureBox.Image = Properties.Resources.body_1;
            if (habboDirection3 == 2)
                bodyPictureBox.Image = Properties.Resources.body_2;
            if (habboDirection3 == 3)
                bodyPictureBox.Image = Properties.Resources.body_3;
            if (habboDirection3 == 4)
                bodyPictureBox.Image = Properties.Resources.body_4;
            if (habboDirection3 == 5)
                bodyPictureBox.Image = Properties.Resources.body_5;
            if (habboDirection3 == 6)
                bodyPictureBox.Image = Properties.Resources.body_6;
            if (habboDirection3 == 7)
                bodyPictureBox.Image = Properties.Resources.body_7;
            if (habboDirection3 == 8)
                bodyPictureBox.Image = Properties.Resources.body_8;
        }

        private void body_rotateleft_PictureBox_Click(object sender, EventArgs e)
        {
            if (habboDirection3 <= 7)
                habboDirection3++;
            else
                habboDirection3 = 1;

            habboDirection2 = habboDirection1 + habboDirection3;

            if (habboDirection3 == 1)
                bodyPictureBox.Image = Properties.Resources.body_1;
            if (habboDirection3 == 2)
                bodyPictureBox.Image = Properties.Resources.body_2;
            if (habboDirection3 == 3)
                bodyPictureBox.Image = Properties.Resources.body_3;
            if (habboDirection3 == 4)
                bodyPictureBox.Image = Properties.Resources.body_4;
            if (habboDirection3 == 5)
                bodyPictureBox.Image = Properties.Resources.body_5;
            if (habboDirection3 == 6)
                bodyPictureBox.Image = Properties.Resources.body_6;
            if (habboDirection3 == 7)
                bodyPictureBox.Image = Properties.Resources.body_7;
            if (habboDirection3 == 8)
                bodyPictureBox.Image = Properties.Resources.body_8;
        }

        private void head_rotateleft_PictureBox_Click(object sender, EventArgs e)
        {
            if (habboHDirection3 <= 7)
                habboHDirection3++;
            else
                habboHDirection3 = 1;

            habboHDirection2 = habboHDirection1 + habboHDirection3;

            if (habboHDirection3 == 1)
                headPictureBox.Image = Properties.Resources.head_1;
            if (habboHDirection3 == 2)
                headPictureBox.Image = Properties.Resources.head_2;
            if (habboHDirection3 == 3)
                headPictureBox.Image = Properties.Resources.head_3;
            if (habboHDirection3 == 4)
                headPictureBox.Image = Properties.Resources.head_4;
            if (habboHDirection3 == 5)
                headPictureBox.Image = Properties.Resources.head_5;
            if (habboHDirection3 == 6)
                headPictureBox.Image = Properties.Resources.head_6;
            if (habboHDirection3 == 7)
                headPictureBox.Image = Properties.Resources.head_7;
            if (habboHDirection3 == 8)
                headPictureBox.Image = Properties.Resources.head_8;
        }

        private void head_rotateright_PictureBox_Click(object sender, EventArgs e)
        {
            if (habboHDirection3 >= 2)
                habboHDirection3--;
            else
                habboHDirection3 = 8;

            habboHDirection2 = habboHDirection1 + habboHDirection3;

            if (habboHDirection3 == 1)
                headPictureBox.Image = Properties.Resources.head_1;
            if (habboHDirection3 == 2)
                headPictureBox.Image = Properties.Resources.head_2;
            if (habboHDirection3 == 3)
                headPictureBox.Image = Properties.Resources.head_3;
            if (habboHDirection3 == 4)
                headPictureBox.Image = Properties.Resources.head_4;
            if (habboHDirection3 == 5)
                headPictureBox.Image = Properties.Resources.head_5;
            if (habboHDirection3 == 6)
                headPictureBox.Image = Properties.Resources.head_6;
            if (habboHDirection3 == 7)
                headPictureBox.Image = Properties.Resources.head_7;
            if (habboHDirection3 == 8)
                headPictureBox.Image = Properties.Resources.head_8;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (charPictureBox.Image == null)
                MessageBox.Show("There is nothing to save!");
            else
            {
                hiSaveFileDialog.Filter = strFilter;
                hiSaveFileDialog.InitialDirectory = strImgDirectory;
                hiSaveFileDialog.FileName = "avatarimage_" + strHabboName;
                hiSaveFileDialog.ShowDialog();
            }
        }

        private void layRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (layRadioButton.Checked)
            {
                wavCheckBox.Checked = false;
                wavCheckBox.Enabled = false;
                actionComboBox.Text = "None";
                actionComboBox.Enabled = false;
            }
            else
            {
                wavCheckBox.Enabled = true;
                actionComboBox.Enabled = true;
            }
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                genButton.PerformClick();
        }

        private void hiSaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                Image saveIMG = imgStore;
                //saveBMP.MakeTransparent();
                strFileNameHI = hiSaveFileDialog.FileName;
                saveIMG.Save(strFileNameHI, imgF);
            }
            catch
            {
                MessageBox.Show("Image failed to save!", "Habbo Imager");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (strFileNameHI == "")
            {
                hiSaveFileDialog.Filter = strFilter;
                hiSaveFileDialog.InitialDirectory = strImgDirectory;
                hiSaveFileDialog.FileName = "avatarimage_" + strHabboName;
                hiSaveFileDialog.ShowDialog();
            }
            else
            {
                try
                {
                    Image saveIMG = imgStore;
                    //saveBMP.MakeTransparent();
                    strFileNameHI = hiSaveFileDialog.FileName;
                    saveIMG.Save(strFileNameHI, imgF);
                }
                catch
                {
                    MessageBox.Show("Image failed to save!", "Habbo Imager");
                }
            }
        }

        private void creditsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.habbo.nl/home/Emmerrrrrrr");
            }
            catch { }
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            headPictureBox.Image = Properties.Resources.head_2;
            bodyPictureBox.Image = Properties.Resources.body_2;
            habboHDirection3 = 2;
            habboDirection3 = 2;
            mRadioButton.Checked = true;
            wavCheckBox.Checked = false;
            noneRadioButton.Checked = true;
            nameTextBox.Clear();
            actionComboBox.Text = "None";
            formatComboBox.Text = "GIF";
            gestureComboBox.Text = "None";
            countryComboBox.Text = "International";
            habboCountry = ".com";
            habboGesture2 = "";
            habboAction2 = "";
            habboFormat2 = habboFormat1 + "gif";
            habboHDirection2 = habboHDirection1 + habboHDirection3;
            habboDirection2 = habboDirection1 + habboDirection3;
            charPictureBox.Image = null;
        }

        private void credits2LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://stackoverflow.com/a/24590419");
            }
            catch { }
        }

        private void body_lock_PictureBox_Click(object sender, EventArgs e)
        {
            bodyPictureBox.Image = Properties.Resources.body_2;
            habboDirection3 = 2;
            habboDirection2 = habboDirection1 + habboDirection3;
        }

        private void head_lock_PictureBox_Click(object sender, EventArgs e)
        {
            headPictureBox.Image = Properties.Resources.head_2;
            habboHDirection3 = 2;
            habboHDirection2 = habboHDirection1 + habboHDirection3;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutWin.objAbout.ShowDialog();
        }

        private void hiSaveFileDialog_FileOk_1(object sender, CancelEventArgs e)
        {
            try
            {
                Image saveIMG = imgStore;
                //saveBMP.MakeTransparent();
                strFileNameHI = hiSaveFileDialog.FileName;
                saveIMG.Save(strFileNameHI, imgF);
            }
            catch
            {
                MessageBox.Show("Image failed to save!", "Habbo Imager");
            }
        }
    }
}
