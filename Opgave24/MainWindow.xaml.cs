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

namespace Opgave24 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnTest1_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Text", "Title");
        }

        private void btnTest2_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Text", "Title", MessageBoxButton.YesNoCancel);
        }

        private void btnTest3_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Do YOU wish to be happy?", "Ghouls", MessageBoxButton.YesNo, MessageBoxImage.Warning);          
        }

        private void btnTest4_Click(object sender, RoutedEventArgs e) {
            MessageBoxResult result = MessageBox.Show("Do you hereby allow mining of your Cookies?", "Santa", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes) {
                MessageBox.Show("Oh perfect now I don't have to eat naughty children", "Santa");
            }
            else {
                MessageBox.Show("I'll just eat naughty Children then hohoho");
            }
        }
    }
}
