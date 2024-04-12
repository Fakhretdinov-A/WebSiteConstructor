using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SchoolProject
{
    /// <summary>
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5(string TempF, string CssF)
        {
            this.TempF = TempF;
            this.CssF = CssF;
            InitializeComponent();
        }
        string TempF, CssF, PicPath1, PicPath2, FolPath1, FolPath2;


        private void saveb_Click(object sender, RoutedEventArgs e)
        {
            string s1 = "<div class=\"ebox1\">$<img src=\"../img/" + PicPath1 + "\"height=\"250\">$<div class=\"title\">$<h2>" + tb1.Text + "</h2>$<span class=\"byline\">" + tb2.Text + "</span>$</div>$<p>" + tb3.Text + "</p>$</div>";
            string s2 = "<div class=\"ebox2\">$<img src=\"../img/" + PicPath2 + "\"height=\"250\">$<div class=\"title\">$<h2>" + tb4.Text + "</h2>$<span class=\"byline\">" + tb5.Text + "</span>$</div>$<p>" + tb6.Text + "</p>$</div>$</div>$</div>$</div>";
            var arr = s1.Split("$");
            var arr2 = s2.Split("$");
            File.AppendAllLines(TempF, arr);
            File.AppendAllLines(TempF, arr2);
            s1 = "#featured-wrapper${$overflow: hidden;$padding: 10em 0em;$background: #FFF;$text-align: center;$}$#featured${$overflow: hidden;$}$#featured .main-title${$margin-bottom: 4em;$}$#featured .main-title h2${$font-size: 4em;$}$#featured .main-title .byline${$font-size: 2em;$}$#featured-wrapper .fa${$display: inline-block;$margin-bottom: 1em;$width: 3em;$height: 3em;$line-height: 3em;$font-size: 4em;$color: #8dc63f;$border: 1px solid #86bd3b;$border-radius: 50%;$}$.extra2 .button${$margin-top: 2em;$}$.extra2 .title h2${$font-size: 2em;$}$.extra2 .title .byline${$font-size: 0.80em;$}$.extra2 .ebox1,$.extra2 .ebox2${$width: 560px;$}$.extra2  .ebox1${$float: left;$padding-right: 40px;$border-right: 1px solid rgba(0,0,0,.1);$}$.extra2 .ebox2${$float: right;$}";
            arr = s1.Split("$");
            File.AppendAllLines(CssF, arr);
        }

        private void md1(object sender, MouseButtonEventArgs e)
        {
            tb1.Clear();
        }

        private void md2(object sender, MouseButtonEventArgs e)
        {
            tb2.Clear();
        }

        private void md3(object sender, MouseButtonEventArgs e)
        {
            tb3.Clear();
        }

        private void md4(object sender, MouseButtonEventArgs e)
        {
            tb4.Clear();
        }

        private void md5(object sender, MouseEventArgs e)
        {
            tb5.Clear();
        }

        private void md6(object sender, MouseEventArgs e)
        {
            tb6.Clear();
        }

        private void PIC4Ban1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.Title = "Выберите ваше изображение";
            folderBrowser.CheckPathExists = true;
            if (folderBrowser.ShowDialog() is true)
            {
                FolPath1 = System.IO.Path.GetDirectoryName(folderBrowser.FileName);
                PicPath1 = System.IO.Path.GetFileName(folderBrowser.FileName);


                var s2 = TempF.Substring(0, TempF.Length - 22);
                var PicF = System.IO.Path.Combine(s2, "img");
                Directory.CreateDirectory(PicF);
                PicF = PicF + "\\" + PicPath1;
                string PicPathh = FolPath1 + "\\" + PicPath1;
                System.IO.File.Copy(PicPathh, PicF);


            }
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
                FolPath2 = System.IO.Path.GetDirectoryName(folderBrowser.FileName);
                PicPath2 = System.IO.Path.GetFileName(folderBrowser.FileName);


                var s2 = TempF.Substring(0, TempF.Length - 22);
                var PicF = System.IO.Path.Combine(s2, "img");
                Directory.CreateDirectory(PicF);
                PicF = PicF + "\\" + PicPath2;
                string PicPathh = FolPath2 + "\\" + PicPath2;
                System.IO.File.Copy(PicPathh, PicF);


            }
        }
    }
}
