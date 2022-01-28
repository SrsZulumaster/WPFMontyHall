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
using DoorBrain;

namespace WPFRPGame
{
    public partial class MainWindow : Window
    {
        bool DoorSelected = false;        
        int ChosenDoor = 0; //1,2,3 picked by player
        int OpenDoor = 0;// 100% a GOAT door
        int FinalDoor=0;//Final decision also neccessary for win and loss counter to properly work
        int WinAmount = 0;//Counts Wins
        int LossAmount = 0;//Counts Losses
        Random random = new Random();
        int WinningDoor;//Chosen at random
        bool GameWon=false;
        public MainWindow()
        {
            InitializeComponent();
            WinningDoor = random.Next(1, 4);
            Door1Info.Text = "Closed";
            Door2Info.Text = "Closed";
            Door3Info.Text = "Closed";
            GameWon = false;
            DoorSelected = false;
        }
        // resets the Game
        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            WinningDoor = random.Next(1, 4);
            Door1Info.Text = "Closed";
            Door2Info.Text = "Closed";
            Door3Info.Text = "Closed";
            DoorSelected = false;
            GameWon = false;
        }
        //First door
        private void Door1_Click(object sender, RoutedEventArgs e)
        {
            if (DoorSelected == false) // Checks if the door has been selected yet so it wouldnt be possible to spam the doors
            {
                ChosenDoor = 1; // sets the number of the Chosen door
                DoorSelected = true;//Selects the door 
                OpenDoor = DoorLogic.Logic(WinningDoor, ChosenDoor);//neccessary for Door Switch
                DoorOpener(OpenDoor); // logic behind opening a GOAT door
            }
        }
        //Second door
        private void Door2_Click(object sender, RoutedEventArgs e)
        {
            if (DoorSelected == false)
            {
                ChosenDoor = 2;
                DoorSelected = true;
                OpenDoor = DoorLogic.Logic(WinningDoor, ChosenDoor);
                DoorOpener(OpenDoor);
            }
        }
        //Third Door
        private void Door3_Click(object sender, RoutedEventArgs e)
        {
            if (DoorSelected == false)
            {
                ChosenDoor = 3;
                DoorSelected = true;
                OpenDoor = DoorLogic.Logic(WinningDoor, ChosenDoor);
                DoorOpener(OpenDoor);
            }
        }
       // gets input from DoorLogic and reveals a GOAT door
        public void DoorOpener(int OpenDoor)
        {
            if (OpenDoor == 1) { Door1Info.Text = "Goat"; }
            if (OpenDoor == 2) { Door2Info.Text = "Goat"; }
            if (OpenDoor == 3) { Door3Info.Text = "Goat"; }
        }
        public void DoorSwitch_Click(object sender, RoutedEventArgs e)
        {
            if ((ChosenDoor ==1) && (OpenDoor== 2)) { FinalDoor = 3; Wins(); }
            if ((ChosenDoor == 1) && (OpenDoor == 3)) { FinalDoor = 2; Wins(); }
            if ((ChosenDoor == 2) && (OpenDoor== 1)) { FinalDoor = 3; Wins(); }
            if ((ChosenDoor == 3) && (OpenDoor== 1)) { FinalDoor = 2; Wins(); }
            if ((ChosenDoor ==2) && (OpenDoor == 3)) { FinalDoor= 1; Wins(); }
            if ((ChosenDoor==3) && (OpenDoor== 2)) { FinalDoor= 1; Wins(); }
        }
        //Gives the Player the Choice to keep the door they Chose 
        public void DoorKeep_Click(object sender, RoutedEventArgs e)
        {
            FinalDoor = ChosenDoor;
            Wins();
        }
        // Determines if the Player Won or Lost
        // Counts Wins and Losses
        // Displays winning door
        public void Wins()
        {
            if (WinningDoor == 1) { Door1Info.Text = "Car"; }
            if (WinningDoor == 2) { Door2Info.Text = "Car"; }
            if (WinningDoor == 3) { Door3Info.Text = "Car"; }
            if (GameWon == false) // prevents WinButton abuse
            {
                if (FinalDoor == WinningDoor)
                {
                    GameWon = true;
                    WinAmount++;
                    WinBox.Text = WinAmount.ToString();
                }
                if (FinalDoor != WinningDoor)
                {
                    LossAmount--;
                    LoseBox.Text = LossAmount.ToString();
                    GameWon = true;
                }
            }
        }

        private void AutoPlay_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            string PVar = PlayBox.Text;
            bool ParseBool = double.TryParse(PVar, out double X);
            if (ParseBool == true)
            {
                do
                {
                Random AutoRandom = new Random();
                int AutoDoor = AutoRandom.Next(1, 4);
                if (AutoDoor == 1) { Door1_Click(sender, e); DoorKeep_Click(sender, e); NewGame_Click(sender, e); }
                if (AutoDoor == 2) { Door2_Click(sender, e); DoorKeep_Click(sender, e); NewGame_Click(sender, e); }
                if (AutoDoor == 3) { Door3_Click(sender, e); DoorKeep_Click(sender, e); NewGame_Click(sender, e); }
                i++;
                } while (i <= X);
            }
            else { ErrorBox.Text = "Please Write a Number!"; }


        }

        private void Autoplay1_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            string PVar = PlayBox.Text;
            bool ParseBool = double.TryParse(PVar, out double X);

            if (ParseBool == true)
            {
                do
                {
                    Random AutoRandom = new Random();
                    int AutoDoor = AutoRandom.Next(1, 4);
                    if (AutoDoor == 1) { Door1_Click(sender, e); DoorKeep_Click(sender, e); NewGame_Click(sender, e); }
                    if (AutoDoor == 2) { Door2_Click(sender, e); DoorKeep_Click(sender, e); NewGame_Click(sender, e); }
                    if (AutoDoor == 3) { Door3_Click(sender, e); DoorKeep_Click(sender, e); NewGame_Click(sender, e); }
                    i++;
                } while (i <= X);
            }
            else { ErrorBox.Text = "Please Write a Number!"; }
        }

        private void PlayBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}