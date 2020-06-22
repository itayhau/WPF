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

namespace DataContext
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person MyPerson { get; set; }
        public Person MyPerson2 { get; set; }
        bool person1 = true;
        public MainWindow()
        {
            
            InitializeComponent();

            MyPerson = new Person { Name = "Very nice person!" };
            MyPerson2 = new Person { Name = "very different person" };

            //this.DataContext = MyPerson; { Binding Name }
            this.DataContext = this; // { Binding MyPerson }
            //this.lbl1.DataContext = MyPerson; // you can choose item for the DataContext
        }

        public class Person
        {
            public string Name { get; set; }

            public override string ToString()
            {
                return $"Person name {Name}";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (person1)
            {
                this.lbl1.DataContext = MyPerson2;
            }
            else
            {
                this.lbl1.DataContext = MyPerson;
            }
            person1 = !person1;
        }
    }

}
