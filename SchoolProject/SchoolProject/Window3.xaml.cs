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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.Title = "Выберите место для вашего будущего сайта";
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() is true)
            {
                string folderPath = System.IO.Path.GetDirectoryName(folderBrowser.FileName);
                var MainF = System.IO.Path.Combine(folderPath, "Мой сайт");
                Directory.CreateDirectory(MainF);

                var TempF = System.IO.Path.Combine(MainF, "Templates");
                Directory.CreateDirectory(TempF);
                
                var CssF = System.IO.Path.Combine(MainF, "CSS");
                Directory.CreateDirectory(CssF);
                TempF += "\\index1.html";
                CssF += "\\style1.css";


                StreamWriter temp1 = new StreamWriter(File.OpenWrite(TempF), Encoding.UTF8);
                StreamWriter css1 = new StreamWriter(File.OpenWrite(CssF), Encoding.UTF8);
                temp1.Close();
                css1.Close();
                this.Close();

                var t = nameofws.Text;
                string[] arr = new string[] {"<!DOCTYPE html>", "<html xmlns=\"http://www.w3.org/1999/xhtml\" lang=\"ru\">","<head>","<meta charset=\"utf-8\">",String.Format("<title>{0}</title>", t),
                    "<link rel=\"stylesheet\" href=\"../CSS/style1.css\">", "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">", "<link rel=\"stylesheet\" href=\"https://use.fontawesome.com/releases/v5.2.0/css/all.css\">", "<link href=\"http://fonts.googleapis.com/css?family=Source+Sans+Pro:200,300,400,600,700,900\" rel=\"stylesheet\" />",
                "<link href=\"default.css\" rel=\"stylesheet\" type=\"text/css\" media=\"all\"/>", "<link href=\"fonts.css\" rel=\"stylesheet\" type=\"text/css\" media=\"all\"/>" };
                File.WriteAllLines(TempF, arr, Encoding.UTF8);
                File.WriteAllText(CssF, "html, body{ height: 100 %; } body{margin: 0px;padding: 0px;background: " +
                    "#2b2b2b;font-family: 'Source Sans Pro', sans-serif;font-size: 11pt;font-weight: 300;color: #6c6c6c}");


                Window1 w1 = new Window1(TempF, CssF);
                w1.Show();
            }


        }

        private void nameofws_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
