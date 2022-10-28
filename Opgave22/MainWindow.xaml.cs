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

namespace Opgave22 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, RoutedEventArgs e) {
            lblHello.Content = "Hello World";
        }

        private void btnBlue_Click(object sender, RoutedEventArgs e) {
            lblColor.Background = Brushes.RoyalBlue;
            lblColor.Foreground = Brushes.Beige;
        }

        private void btnRed_Click(object sender, RoutedEventArgs e) {
            lblColor.Background = Brushes.Crimson;
            lblColor.Foreground = Brushes.Beige;
        }

        private void lblColorWhite_MouseEnter(object sender, MouseEventArgs e) {
            lblColorWhite.Background = lblColorRed.Background;
        }

        private void lblColorWhite_MouseLeave(object sender, MouseEventArgs e) {
            lblColorWhite.Background = Brushes.Beige;
        }

        private void lblColorRed_MouseEnter(object sender, MouseEventArgs e) {
            lblColorRed.Background = lblColorWhite.Background;
        }

        private void lblColorRed_MouseLeave(object sender, MouseEventArgs e) {
            lblColorRed.Background = Brushes.Crimson;
        }
    }
}
