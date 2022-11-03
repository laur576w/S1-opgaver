using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
using static System.Net.WebRequestMethods;

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
            //gets input from textbox
            if (string.IsNullOrWhiteSpace(tbxNameNum.Text)) {
                lblNotValid.Content = "Is there even something?";
            }
            else {
                int numberOfNames = int.Parse(tbxNameNum.Text);
                if (numberOfNames >= 1 && numberOfNames <= 10) {
                    lblNotValid.Content = "";
                    for (int i = 0; i < numberOfNames; i++) {
                        //random Firstname
                        string firstName = femaleFirstNames[rnd.Next(0, femaleFirstNames.Count)];

                        //random LastName
                        string lastName = lastNames[rnd.Next(0, lastNames.Count)];

                        //the new name
                        string newName = $"F: {firstName} {lastName}";

                        //check if it already exists if it does goes back one step if it doesn't add itto the list
                        if (lbxShowNames.Items.Contains(newName)) {
                            i--;
                        }
                        else {
                            lbxShowNames.Items.Add(newName);
                        }
                    }
                }
                else
                    lblNotValid.Content = "Number not between 1-10";
            }
        }

        private void btnmaleNames_Click(object sender, RoutedEventArgs e) {
            //gets input from textbox
            if (string.IsNullOrWhiteSpace(tbxNameNum.Text)) {
                lblNotValid.Content = "Is there even something?";
            }
            else {
                int numberOfNames = int.Parse(tbxNameNum.Text);
                if (numberOfNames >= 1 && numberOfNames <= 10) {
                    lblNotValid.Content = "";
                    for (int i = 0; i < numberOfNames; i++) {
                        //random Firstname
                        string firstName = maleFirstNames[rnd.Next(0, femaleFirstNames.Count)];

                        //random LastName
                        string lastName = lastNames[rnd.Next(0, lastNames.Count)];

                        //the new name
                        string newName = $"M: {firstName} {lastName}";

                        //check if it already exists if it does goes back one step if it doesn't add it to the list
                        if (lbxShowNames.Items.Contains(newName)) {
                            i--;
                        }
                        else {
                            lbxShowNames.Items.Add(newName);
                        }
                    }
                }
                else
                    lblNotValid.Content = "Number not between 1-10";
                
            }
        }

        private void btnClearNames_Click(object sender, RoutedEventArgs e) {
            //clears the list
            lbxShowNames.Items.Clear();
        }


        private void NumericOnly(object sender, TextCompositionEventArgs e) {
            e.Handled = IsTextNumeric(e.Text);

        }

        //doesn't allow anything that's not a number
        private static readonly Regex regex = new Regex("[^0-9]");

        //Makes sure it's valid data
        private static bool IsTextNumeric(string text) {
            return regex.IsMatch(text);

        }

        //stops you from pasting letters and only allows numbers
        private void TextBoxPastingNumbers(object sender, DataObjectPastingEventArgs e) {
            if (e.DataObject.GetDataPresent(typeof(string))) {
                string text = (string)e.DataObject.GetData(typeof(string));
                if (IsTextNumeric(text)) {
                    e.CancelCommand();
                }
            }
            else {
                e.CancelCommand();
            }
        }

        private void btnSaveNames_Click(object sender, RoutedEventArgs e) {
            string fileName = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text file (*.txt)|*.txt";
            sfd.InitialDirectory = @"C:\temp\";

            if (sfd.ShowDialog() == true) {                             
                    fileName = sfd.FileName;
                    writeToFile(fileName);               
            }
        }
        private void writeToFile(string fileName) {
            using (StreamWriter SaveFile = new StreamWriter(fileName)) {
                foreach (var item in lbxShowNames.Items)
                    SaveFile.WriteLine(item.ToString());
            }
        }
    }
}
