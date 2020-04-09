using AduDesignDemo.Model;
using System.Collections.ObjectModel;
using System.Windows;
using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace AduDesignDemo
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            //ImageBrush ib = new ImageBrush();
            //ib.ImageSource = new BitmapImage(new Uri("Background.jpg", UriKind.RelativeOrAbsolute));
            //ib.Opacity = 0.3;
            //this.Background = ib;
        }

        private void DMSkinWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
