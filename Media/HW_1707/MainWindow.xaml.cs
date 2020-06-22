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

namespace HW_1707
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person p = new Person { Name="123" };
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse down");
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {firstNameTxt.Text}");
        }
    }
    public class Person
    {
        public string Name { get; set; }
    }
}
