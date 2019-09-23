using System;
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

namespace Computer_Vision_Tool_EmguCV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Emgu.CV.UI.ImageBox imageBox;
        private BaslerCamera camera;

        public MainWindow()
        {
            InitializeComponent();
            imageBox = new Emgu.CV.UI.ImageBox();
            camera = new BaslerCamera();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            wfh_host.Child = imageBox;
        }

        private void Btn_snap_Click(object sender, RoutedEventArgs e)
        {
            camera.snapImage(imageBox, 1500, 1500);
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {
            camera.saveImage(imageBox, AppDomain.CurrentDomain.BaseDirectory + @"Images/test.jpg", 274, 274);
        }    
    }
}
