using System;
using System.Windows;


namespace SchoolProject
{ 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
 
                Window3 w3 = new Window3();
                w3.ShowDialog();
                this.Hide();
        }
        private void ButtonQA_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.Show();
        }
    }

}
