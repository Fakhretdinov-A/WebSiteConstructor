using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Input;

using System.Diagnostics;

namespace SchoolProject
{

    public partial class Window4 : Window
    {
        public Window4(string TempF, string CssF)
        {
            this.TempF = TempF;
            this.CssF = CssF;
            InitializeComponent();
            StreamWriter temp1 = new StreamWriter(File.OpenWrite(TempF), Encoding.UTF8);
            StreamWriter css1 = new StreamWriter(File.OpenWrite(CssF), Encoding.UTF8);
            temp1.Close();
            css1.Close();

        }
        string TempF, CssF, PicPath, FolPath;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s1 = "</head>$<body>$<div id=\"header-wrapper\">$<div id = \"header\" class=\"container\">$<div id = \"logo\" >$<h1>$" +
                "<span class=\"fa fa-bolt\">$</span>$<a href = \"#\" >$" + textHead.Text + "$</a>$</h1>$</div>$</div>$</div>";
            var arr = s1.Split("$");
            File.AppendAllLines(TempF,arr);
            File.AppendAllText(CssF, "h1, h2, h3{margin: 0; padding: 0; font-weight: 600; color: #454445;}");
            File.AppendAllText(CssF, "#header-wrapper{background: #2b2b2b;}");
            File.AppendAllText(CssF, "#header{position: relative;height: 100px;}");
            var arr1 = "a{color: #2C383B;}$hover{ text-decoration: none;}$p{ line-height: 180 %; }$.container{ margin: 0px auto; width: 1200px; }$# logo{position: absolute;top: 2em;width: 100%;}$# logo h1{display: inline-block;font-size: 2.5em;text-transform: uppercase;font-weight: 700;color: #ED7070;padding-right: 0.50em;border-right: 1px solid rgba(0,0,0,.1);}$# logo span{ display: inline-block; padding-right: .50em; letter-spacing: 0.10em; text-transform: uppercase; font-size: 0.90em; }$#logo a{text-decoration: none;color: #FFF;}$#logo .fa{color: #8dc63f;}$#logo .fa:after{position: absolute;display: inline-block;padding-right: 2em;}".Split("$");
            var arr2 = "#logo{position: absolute;top: 2em;width: 100%;}$#logo h1{display: inline-block;font-size: 2.5em;text-transform: uppercase;font-weight: 700;color: #ED7070;padding-right: 0.50em;border-right: 1px solid rgba(0,0,0,.1);}$#logo span{display: inline-block;padding-right: .50em;letter-spacing: 0.10em;text-transform: uppercase;font-size: 0.90em;}$#logo a{text-decoration: none;color: #FFF;}$#logo .fa{color: #8dc63f;}$#logo .fa:after{position: absolute;display: inline-block;padding-right: 2em;}$".Split("$");
            File.AppendAllLines(CssF, arr1);
            File.AppendAllLines(CssF, arr2);
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            textHead.Text = "";
        }

        private void TextBox1_MouseEnter(object sender, MouseEventArgs e)
        {
            textHead2.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

 

        private void TextBox2_MouseEnter(object sender, MouseEventArgs e)
        {
            textHead3.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string s1 = "<div id=\"wrapper\">$<div id=\"featured-wrapper\">$<div id=\"featured\" class=\"extra2 margin-btm container\">$<div class=\"main-title\">$<h2>" + textHead3_1.Text +"</h2>$<span class=\"byline\">" + textHead3_2.Text + "</span>$</div>";         
            var arr = s1.Split("$");
            File.AppendAllLines(TempF, arr);

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            tb5_1.IsEnabled = true;
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            tb5_2.IsEnabled = true;
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            tb5_3.IsEnabled = true;
        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {
            tb5_4.IsEnabled = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            tb5_1.IsEnabled = false;
        }

        private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
        {
            tb5_2.IsEnabled = false;
        }

        private void CheckBox_Unchecked_2(object sender, RoutedEventArgs e)
        {
            tb5_3.IsEnabled = false;
        }

        private void CheckBox_Unchecked_3(object sender, RoutedEventArgs e)
        {
            tb5_4.IsEnabled = false;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(TempF)
            {
                UseShellExecute = true
            };
            p.Start();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var arr5 = ".buttonsss {width: 500px;}$.fab{color: white;font-size: 40px;margin-right: 20px;}$.sm{font-size: 25px;color:white}$".Split("$");
            File.AppendAllLines(CssF, arr5);
            string s = "<div id=\"copyright\" class=\"container\">$<div class=\"buttonsss\">$<p class=\"sm\">" + footer_text.Text + "</p>$";
            if (c1.IsChecked == true)
            {
                s += "<a href=\"" + tb5_1.Text + "\"><i class=\"fab fa-vk\"></i></a>";
            }
            if (c2.IsChecked == true)
            {
                s += "<a href=\"" + tb5_2.Text + "\"><i class=\"fab fa-facebook-square\"></i></a>";
            }
            if (c3.IsChecked == true)
            {
                s += "<a href=\"" + tb5_3.Text + "\"><i class=\"fab fa-youtube\"></i></a>";
            }
            if (c4.IsChecked == true)
            {
                s += "<a href=\"" + tb5_4.Text + "\"><i class=\"fab fa-instagram\"></i></a>";
            }
            s += "</div>$<p>&copy;All rights reserved.</p>$</div>$</body>$</html>";
            arr5 = s.Split("$");
            File.AppendAllLines(TempF, arr5);


        }

        private void Save2But_Click(object sender, RoutedEventArgs e)
        {
            string s1 = "<div id=\"header-featured\">$<div id=\"banner-wrapper\">$<div id=\"banner\" class=\"container\">$<h2>" + textHead3.Text + "</h2>$<p>" + textHead2.Text + "</p>$</div>$</div>$</div>";
            var arr = s1.Split("$");
            File.AppendAllLines(TempF, arr);
            s1 = "#header-featured{padding: 10em 0em;background-image: url(../img/" + PicPath + ");background-position: center;background-size: cover;}$#banner-wrapper{}$#banner{overflow: hidden;width: 1000px;text-align: center;color: rgba(255,255,255,.7);font-size: 1.5em;}$#banner a{color: rgba(255,255,255,.9);}$#banner h2{padding-bottom: 0.50em;font-weight: 400;font-size: 3em;color: #FFF;}$#banner .button{margin-top: 2em;background: #6fac1b;}$#banner strong{color: #FFF;}$#banner span{display: block;padding-top: 0.20em;text-transform: uppercase;font-size: 1.2em;color: #A2A2A2;}";
            arr = s1.Split("$");
            File.AppendAllLines(CssF, arr);
        }

        private void PIC4Ban_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.Title = "Выберите ваше изображение";
            folderBrowser.CheckPathExists = true;
            if (folderBrowser.ShowDialog() is true)
            {
                FolPath = System.IO.Path.GetDirectoryName(folderBrowser.FileName);
                PicPath = System.IO.Path.GetFileName(folderBrowser.FileName);

                
                var s2 = TempF.Substring(0, TempF.Length - 22);
                var PicF = System.IO.Path.Combine(s2, "img");
                Directory.CreateDirectory(PicF);
                PicF = PicF + "\\" + PicPath;
                string PicPathh = FolPath + "\\" + PicPath;
                System.IO.File.Copy(PicPathh, PicF);

                
            }
        }
       private void AddBlocks_Click(object sender, RoutedEventArgs e)
        {
            Window5 w5 = new Window5(TempF, CssF);
            w5.Show();
        }
        
    }

}
