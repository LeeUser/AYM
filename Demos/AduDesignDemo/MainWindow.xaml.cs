using AduDesignDemo.Model;
using System.Collections.ObjectModel;
using System.Windows;
using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using AduDesignDemo.Views;


namespace AduDesignDemo
{
    public partial class MainWindow
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEntryOne_Click(object sender, RoutedEventArgs e)
        {
            EntryOneControl entryOneControl = new EntryOneControl();
            mainView.Child = entryOneControl;
        }

        private void BtnEntryTwo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEntryThree_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTransfer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnExist_Click(object sender, RoutedEventArgs e)
        {
            OutputControl outputControl= new OutputControl();
            mainView.Child = outputControl;
        }

        private void BtnExitApp_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult;//设置对话框的返回值
            msgBoxResult=MessageBox.Show("确定退出程序吗?","提醒",MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (msgBoxResult == MessageBoxResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }
    }
}
