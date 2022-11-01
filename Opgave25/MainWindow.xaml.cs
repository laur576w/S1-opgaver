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
        //keeps count of 'x' subject needs reset when reached
        private int MouseEnterCount = 0;

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

        private void tblGreen_MouseLeave(object sender, MouseEventArgs e) {
            if (currentGameStep == 4) {
                tblInstructions.Text = "Godt gjort!\n" +
                    "Rør nu ved noget småt.";
                currentGameStep++;
            }
        }

        private void tblSmallText_MouseEnter(object sender, MouseEventArgs e) {
            if (currentGameStep == 5) {
                tblInstructions.Text = "Sådan!\n" +
                    "Sidste step - før musen over den brede 2 gange";
                currentGameStep++;
            }
        }

        private void tblBla_MouseEnter(object sender, MouseEventArgs e) {
            
            if (currentGameStep == 6) {
                MouseEnterCount++;
                if (MouseEnterCount >= 2 ) {
                    tblInstructions.Text = "Tillyke du vandt!\n" +
                        "Tryk på start for at prøve igen";
                    isStarted = false;
                    btnStartGame.Content = "Start Spillet!";
                    currentGameStep = 0;
                    MouseEnterCount = 0;
                }
            }
        }
    }
}
