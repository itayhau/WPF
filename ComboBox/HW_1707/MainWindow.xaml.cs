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
        public List<Person> people = new List<Person>();
        public MainWindow()
        {
            
            InitializeComponent();


            people.Add(new Person { FirstName = "Dana", LastName = "Koren" });
            people.Add(new Person { FirstName = "Keren", LastName = "Koko" });
            people.Add(new Person { FirstName = "Mor", LastName = "Mini" });

            myComboBox.ItemsSource = people;
            myComboBox.SelectedIndex = 0;
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse down");
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {firstNameTxt.Text}");
            people.Add(new Person { FirstName = firstNameTxt.Text, LastName = "Doe" });
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
