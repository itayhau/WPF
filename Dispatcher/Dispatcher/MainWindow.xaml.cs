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

namespace Dispatcher
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

        private void SafeInvoke(Action work)
        {
            if (Dispatcher.CheckAccess()) // CheckAccess returns true if you're on the dispatcher thread
            {
                work.Invoke();
                return;
            }
            this.Dispatcher.BeginInvoke(work);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                for (int i = 2; i < 100; i++)
                {
                    Action uiwork = () => { countLbl.Content = i; };
                    //this.Dispatcher.Invoke(uiwork); // countLbl.BeginInvoke(uiwork);
                    SafeInvoke(uiwork);
                    Thread.Sleep(20);
                }
            });
        }
    }
}
