using System;
using System.Windows;

namespace SampleWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Guidbutton_Click(object sender, RoutedEventArgs e)
        {
            tb_guid.Text = Guid.NewGuid().ToString();
        }

        private void Cpyguid_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(tb_guid.Text);
        }

        private void Cpyrandom_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(random.Text);
        }

        private void Genrandom_Click(object sender, RoutedEventArgs e)
        {
            Random ran = new Random();
            random.Text = ran.Next(Convert.ToInt32(length.Text)).ToString();
        }
    }
}