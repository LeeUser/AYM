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

namespace AduDesignDemo.Views
{
    /// <summary>
    /// Interaction logic for Entry1Control.xaml
    /// </summary>
    public partial class Entry1Control : UserControl
    {
        public Entry1Control()
        {
            InitializeComponent();
            //ImageBrush ib = new ImageBrush();
            //ib.ImageSource = new BitmapImage(new Uri("back.png", UriKind.RelativeOrAbsolute));
            //ib.Opacity = 0.3;
            //this.Background = ib;
        }

        private void BtnMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Point p = Mouse.GetPosition(this);  //获取鼠标相对位置
            var window = new Window();//Windows窗体
            window.WindowStyle = WindowStyle.None;
            window.Height = 150;
            window.Width = 80;
            window.WindowStartupLocation = WindowStartupLocation.Manual;
            window.Left = p.X;
            window.Top = p.Y;
            BagInfoControl jks = new BagInfoControl();  //UserControl写的界面          
            window.Content = jks;
            window.Show();
        }
    }
}
