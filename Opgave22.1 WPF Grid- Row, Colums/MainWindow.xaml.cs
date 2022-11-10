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
using Opgave22._1_WPF_Grid__Row__Colums.BIZ;

namespace Opgave22._1_WPF_Grid__Row__Colums {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        ClassBIZ classBIZ = new(); 
        public MainWindow() {
            InitializeComponent();
        }

        private void ButtonOpg1_Click(object sender, RoutedEventArgs e) {
            classBIZ.Number4711(listBoxRes);
        }

        private void ButtonOpg2_Click(object sender, RoutedEventArgs e) {
            classBIZ.DelOpgave1_2(listBoxRes);
        }

        private void ButtonOpg3_Click(object sender, RoutedEventArgs e) {
            classBIZ.DelOpgave1_3(listBoxRes);
        }

        private void ButtonOpg4_Click(object sender, RoutedEventArgs e) {
            classBIZ.DelOpgave1_4(listBoxRes);
        }

        private void ButtonOpg5_Click(object sender, RoutedEventArgs e) {
            classBIZ.DelOpgave1_5(listBoxRes);

        }

        private void ButtonOpg6_Click(object sender, RoutedEventArgs e) {
            classBIZ.DelOpgave1_6(listBoxRes);
        }

        private void ButtonOpg7_Click(object sender, RoutedEventArgs e) {
            listBoxRes.ItemsSource = classBIZ.DelOpgave1_7(listBoxRes);
        }
        private void ButtonOpg8_Click(object sender, RoutedEventArgs e) {
            classBIZ.DelOpgave1_8(listBoxRes);
        }

        private void ButtonOpg9_Click(object sender, RoutedEventArgs e) {
            classBIZ.DelOpgave1_9(listBoxRes);
        }
    }
}
