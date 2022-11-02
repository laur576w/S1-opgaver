using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Opgave26 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        //20 femaleFirstNames
        private List<string> femaleFirstNames = new List<string>() { "Dana", "Isabell", "Carolyn", "Mindy", "Marian", "Reanna", "Candice", "Chana", "Emerson", "Reese", "Cecelia", "Josefina", "Iliana", "Kari", "Aja", "Zaria", "Shae", "Joelle", "Kalyn", "Aysia" };
        
        //20 maleFirstnames
        private List<string> maleFirstNames = new List<string>() { "Warren", "Gordon", "Ulysses", "Quinton", "Josiah", "Ahmad", "Cecil", "Jayce", "Jonathan", "Nathanial", "Alvaro", "Cayden", "Kelton", "Yisroel", "Keegan", "Aubrey", "Hector", "Lucas", "Kendell", "Hugo" };

        //10 Lastnames
        private List<string> lastNames = new List<string>() { "Washington", "Keel", "Robertson", "Fitzpatrick", "Ashford", "Voss", "Baggett", "Snow", "Scanlon", "Tang" };
        
        private Random rnd = new Random();

        private void btnFemaleNames_Click(object sender, RoutedEventArgs e) {
            int numberOfNames = int.Parse(tbxNameNum.Text);
            for (int i = 0; i < numberOfNames; i++) {
                string firstName = femaleFirstNames[rnd.Next(0, 20)];
            }
        }

        private void btnmaleNames_Click(object sender, RoutedEventArgs e) {

        }

        private void btnClearNames_Click(object sender, RoutedEventArgs e) {

        }
    }
}
