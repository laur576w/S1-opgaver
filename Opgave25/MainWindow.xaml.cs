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

namespace Opgave25 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        //Variable to keep track of the game step
        private int currentGameStep = 0;
        //variable to keep track of the game status
        private bool isStarted = false;

        private void btnStartGame_Click(object sender, RoutedEventArgs e) {
            if (isStarted == false) {
                tblInstructions.Text = "Flyt musen over på den grønne kasse";
                isStarted = true;
                currentGameStep++;
                btnStartGame.Content = "Stop Spillet";
            }
            else {
                
                MessageBoxResult result = MessageBox.Show("Spillet er i gang. Ønsker du at stoppe spillet?", "Hov..", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes) {
                    isStarted = false;
                    tblInstructions.Text = "Her vil spillets instruktioner stå!\n" +
                        "Tryk Start Spillet for at begynde.";
                    currentGameStep = 0;
                    btnStartGame.Content = "Start Spillet!";
                } 

            }
        }

        private void tblYellow_MouseEnter(object sender, MouseEventArgs e) {
            if (currentGameStep == 1) {
                tblInstructions.Text = "Flot!\n" +
                    "Tryk nu på den højeste kasse.";
                currentGameStep++;
            }
        }

        private void tblSmallCase_Click(object sender, MouseButtonEventArgs e) {
            if (currentGameStep == 2) {
                tblInstructions.Text = "Godt trykket!\n" +
                    "Højreklik nu på GRØN";
                currentGameStep++;
            }
        }

        private void tblGreen_RightClick(object sender, MouseButtonEventArgs e) {
            if (currentGameStep == 3) {
                tblInstructions.Text = "Den forstod du godt!\n" +
                    "Fjern nu musen fra den lille kasse.";
                currentGameStep++;
            }
        }
    }
}
