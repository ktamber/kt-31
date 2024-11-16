using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kt_31
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string imgsource1 = @"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\Ktamada\Downloads\ver.png";
        private string imgsource2 = @"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\Ktamada\Downloads\bux.png";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("lox прога умерла ты соучастник");
            Application.Current.Shutdown();
        }
        /*
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.gif;*.png;*bmp" };
            
                if (openFileDialog.ShowDialog() == true) {
                    BitmapImage bitmapImage = new BitmapImage(new Uri(openFileDialog.FileName));
                DisplayImage.Source = bitmapImage;
                }
            
        }
        */
        
    }
}
