using System;
using System.Collections.Generic;
using System.IO;
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

namespace Opgave27 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        /*private void App_Startup(object sender, StartupEventArgs e) {
            StreamReader reader = new(System.IO.Path.Combine(Environment.GetFolderPath(
    Environment.SpecialFolder.MyDoc‌​uments), "Save.txt"));
            string strings = reader.ReadToEnd();
            highscore = int.Parse(strings);
            lblHighscore.Content = highscore;
        }*/

        private Random rnd = new();

        //number rolled
        private int numberSat = 0;
        //score counter
        private int score = 0;

        private int highscore;

        private bool isStarted = false;

        private void btnStartGame_Click(object sender, RoutedEventArgs e) {
            if (isStarted == false) {
                numberSat = rnd.Next(1, 7);//new number rolled
                lblDice.Content = numberSat;//new number showed
                lblScore.Content = score; //resets or sets the score
                isStarted = true;
            }
        }

        private void EndGame() {
            if (score > highscore) {
                highscore = score;
                lblHighscore.Content = highscore;
            }
            MessageBox.Show($"Desværre - du tabte. Du endte med en score på {score}", "Game Over", MessageBoxButton.OK);
            lblDice.Content = "n/a";           
            score = 0;
            isStarted = false;
        }

        private void btnLower_Click(object sender, RoutedEventArgs e) {
            int newRoll = rnd.Next(1, 7);
            lblDice.Content = newRoll;
            if (newRoll <= numberSat) {
                numberSat = newRoll;
                score++;
                lblScore.Content = score;
            }
            else {
                EndGame();
            }
        }

        private void btnOver_Click(object sender, RoutedEventArgs e) {
            int newRoll = rnd.Next(1, 7);
            lblDice.Content = newRoll;
            if (newRoll >= numberSat) {
                numberSat = newRoll;
                score++;
                lblScore.Content = score;
            }
            else {
                EndGame();
            }
        }

        //loads when opening
        private void Window_ContentRendered(object sender, EventArgs e) {
            if (File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "SaveOpg27.txt")) == true) {
                StreamReader reader = new(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "SaveOpg27.txt"));
                string strings = reader.ReadToEnd();
                highscore = int.Parse(strings);
                lblHighscore.Content = highscore;
            }
        }

        //saves when closing
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            using (StreamWriter writer = new(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "SaveOpg27.txt"))) {
                writer.Write(highscore);
            }
        }
    }
}
