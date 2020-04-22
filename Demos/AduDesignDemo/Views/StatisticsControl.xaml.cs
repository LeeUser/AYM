using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace AduDesignDemo.Views
{
    /// <summary>
    /// Interaction logic for StatisticsControl.xaml
    /// </summary>
    public partial class StatisticsControl : UserControl
    {
        public StatisticsControl()
        {
            InitializeComponent();
            //Thread th = new Thread(new ThreadStart(test)); //也可简写为new Thread(ThreadMethod);                
            //th.Start(); //启动线程 
        }

        private void test()
        {
            for (; ; Thread.Sleep(1000))
            {
                    updateTextbox setProVisi = new updateTextbox(SetTextbox);
                    this.Dispatcher.Invoke(setProVisi, new object[] { DateTime.Now.ToString() });
            }
        }

        public delegate void updateTextbox(string text);

        public void SetTextbox(string text)   //多线程 更新
        {
            PacksTotal.Text = text;
        }

    }
}
