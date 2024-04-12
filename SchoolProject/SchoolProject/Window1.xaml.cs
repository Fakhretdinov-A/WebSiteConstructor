using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SolidColorBrush whitetheme = new SolidColorBrush(Color.FromRgb(242, 243, 244));
        SolidColorBrush blacktheme = new SolidColorBrush(Color.FromRgb(40, 39, 41));
        SolidColorBrush blackalph = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        SolidColorBrush whitealph = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        public Window1(string TempF, string CssF)
        {
            this.TempF= TempF;
            this.CssF = CssF;
            InitializeComponent();
        }
        string TempF, CssF;

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            grid.Background = whitetheme;
            l1.Foreground = blackalph;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            grid.Background = blacktheme;
            l1.Foreground = whitealph;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window4 w4 = new Window4(TempF, CssF);
            this.Close();
            w4.Show();
        }
    }
}
