using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Game
{
    public partial class AdventureGame : Form
    {
        // Tracks what page of the story the user is at
        int page= 1;
        Random random = new Random();
        int randonValue;
         
        public AdventureGame()
        {
            InitializeComponent();

            // Display initial message and options
            outputLabel.Text = "You have been pick to race in nasrace but you are having fun with what you are doing";

            option1Label.Text = "Keep wtih what you are doing";
            option2Label.Text = "NASCAR";

        }
        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 50;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 5)
            {
                page = 4;
            }
            else if (page == 6)
            {
                page = 5;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 50;
            }
            else if (page == 9)
            {
                page = 50;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 50;
            }
            else if (page == 12)
            {
                page = 50;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 50;
            }
            else if (page == 15)
            {
                page = 12;
            }
            else if (page == 16)
            {
                page = 50;
            }
            else if (page == 17)
            {
                page = 50;
            }

            /// Display text and game options to screen based on the 
            /// current page
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You have been pick to race in nascar but you are having fun with what you are doing";

                    option1Label.Text = "NASCAR";
                    option2Label.Text = "Keep wtih what you are doing";
                    break;
                case 2:
                    outputLabel.Text = "You have decide to keep doing what you where doing before and then it stoped work and no when cares you. Your life has stoped";

                    option1Label.Text = "GAME OVER";
                    option2Label.Text = "GAME OVER";
                    break;
                case 3:
                    outputLabel.Text = "You have picked nascar. But you have to pick a team";

                    option1Label.Text = "Joe Gibbs Racing";
                    option2Label.Text = "Stewart-Haas Racing";
                    break;
                case 4:
                    outputLabel.Text = "You are racing for Joe Gibbs Racing. They have a car that could win the championship would you like to try to win it";

                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 5:
                    outputLabel.Text = "You are racing for Stewart-Haas Racing. They do not have a car to win the championship want to keep with them are try something else";

                    option1Label.Text = "Chage temas";
                    option2Label.Text = "Keep going";
                    break;
                case 6:
                    outputLabel.Text = "You picked not to try to win the championship and they make you leave";

                    option1Label.Text = "Try something else";
                    option2Label.Text = "Quit";
                    break;
                case 7:
                    outputLabel.Text = "You picked to try to win the championship and it is work out. You just have to win the next 2 races. ";

                    option1Label.Text = "Race like noting is on the line";
                    option2Label.Text = "Try win the next two races ";
                    break;
                case 8:
                    outputLabel.Text = "You raced like nothing was on the line and you ended up doing good and you won the last race on the championship";

                    option1Label.Text = "Quit";
                    option2Label.Text = "Quit";
                    break;
                case 9:
                    outputLabel.Text = "You try to win the next to races but you end up hitting the wall bad and you die";

                    option1Label.Text = "Quit";
                    option2Label.Text = "Quit";
                    break;
                case 10:
                    outputLabel.Text = "You have decided to keep racing. You are around the middle of the standings and you could make it to the playoffs but you have had another team reach out to see if you would like to drive for them remain of the year plus 5 years. They are the best team and you would most likely win championship with them";

                    option1Label.Text = "Keep going";
                    option2Label.Text = "Move Teams";
                    break;
                case 11:
                    outputLabel.Text = "You have decide to keep going with your team and it did not go well.";
                    
                    option1Label.Text = "Quit";
                    option2Label.Text = "Quit";
                    break;
                case 12:
                    outputLabel.Text = "You win the championship in your second year";

                    option1Label.Text = "Quit";
                    option2Label.Text = "Quit";
                    break;
                case 13:
                    outputLabel.Text = "You have moved teams and your turned your year around. At the end of the year they ask you if you want a change car numbers";

                    option1Label.Text = "Keep";
                    option2Label.Text = "Change";
                    break;
                case 14:
                    outputLabel.Text = "You keep your car number and it is not working and they make you leave ";

                    option1Label.Text = "Quit";
                    option2Label.Text = "Quit";
                    break;
                case 15:
                    outputLabel.Text = "You have changed car number and you could win the championship. But you have to decide if you want to play it safe or risky ";

                    option1Label.Text = "Safe";
                    option2Label.Text = "Risky";
                    break;
                case 16:
                    outputLabel.Text = "You lost the game is over";

                    option1Label.Text = "Quit";
                    option2Label.Text = "Quit";
                    break;
                case 17:
                    outputLabel.Text = "You win the championship in your second year";

                    option1Label.Text = "Quit";
                    option2Label.Text = "Quit";
                    break;
                case 50:
                    outputLabel.Text = " thank you for playing";

                    option1Label.Text = "";
                    option2Label.Text = "";

                  //  Thread.Sleep(9000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
        
        private void option2Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 50;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 10;
            }
            else if (page == 6)
            {
                page = 50;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 50;
            }
            else if (page == 10)
            {
                page = 13;
            }
            else if (page == 11)
            {
                page = 50;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 15)
            {
                randonValue = random.Next(1, 101);
                if (randonValue < 75)
                {
                    page = 17;
                }
                else
                {
                    page = 16;
                }

            
            }

            /// Display text and game options to screen based on the 
            /// current page
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You have been pick to race in nascar but you are having fun with what you are doing";

                    option1Label.Text = "NASCAR";
                    option2Label.Text = "Keep wtih what you are doing";
                    break;
                case 2:
                    outputLabel.Text = "You have decide to keep doing what you where doing before and then it stoped work and no when cares you. Your life has stoped";

                    option1Label.Text = "GAME OVER";
                    option2Label.Text = "GAME OVER";
                    break;
                case 3:
                    outputLabel.Text = "You have picked nascar. But you have to pick a team";

                    option1Label.Text = "Joe Gibbs Racing";
                    option2Label.Text = "Stewart-Haas Racing";
                    break;
                case 4:
                    outputLabel.Text = "You are racing for Joe Gibbs Racing. They have a car that could win the championship would you like to try to win it";

                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 5:
                    outputLabel.Text = "You are racing for Stewart-Haas Racing. They do not have a car to win the championship want to keep with them are try something else";

                    option1Label.Text = "Chage temas";
                    option2Label.Text = "Keep going";
                    break;
                case 6:
                    outputLabel.Text = "You picked not to try to win the championship and they make you leave";

                    option1Label.Text = "Try something else";
                    option2Label.Text = "Quit";
                    break;
                case 7:
                    outputLabel.Text = "You picked to try to win the championship and it is work out. You just have to win the next 2 races. ";

                    option1Label.Text = "Race like noting is on the line";
                    option2Label.Text = "Try win the next two races ";
                    break;
                case 8:
                    outputLabel.Text = "You raced like nothing was on the line and you ended up doing good and you won the last race on the championship";

                    option1Label.Text = "Quit";
                    option2Label.Text = "Quit";
                    break;
                case 9:
                    outputLabel.Text = "You try to win the next to races but you end up hitting the wall bad and you die";

                    option1Label.Text = "Quit";
                    option2Label.Text = "Quit";
                    break;
                case 10:
                    outputLabel.Text = "You have decided to keep racing. You are around the middle of the standings and you could make it to the playoffs but you have had another team reach out to see if you would like to drive for them remain of the year plus 5 years. They are the best team and you would most likely win championship with them";

                    option1Label.Text = "Keep going";
                    option2Label.Text = "Move Teams";
                    break;
                case 11:
                    outputLabel.Text = "You have decide to keep going with your team and it did not go well.";

                    option1Label.Text = "Quit";
                    option2Label.Text = "Quit";
                    break;
                case 12:
                    outputLabel.Text = "You win the championship in your second year";

                    option1Label.Text = "Quit";
                    option2Label.Text = "Quit";
                    break;
                case 13:
                    outputLabel.Text = "You have moved teams and your turned your year around. At the end of the year they ask you if you want a change car numbers";

                    option1Label.Text = "Keep";
                    option2Label.Text = "Change";
                    break;
                case 14:
                    outputLabel.Text = "You keep your car number and it is not working and they make you leave ";

                    option1Label.Text = "Quit";
                    option2Label.Text = "Quit";
                    break;
                case 15:
                    outputLabel.Text = "You have changed car number and you could win the championship. But you have to decide if you want to play it safe or risky ";

                    option1Label.Text = "Safe";
                    option2Label.Text = "Risky";
                    break;
                case 16:
                    outputLabel.Text = "You lost the game is over";

                    option1Label.Text = "Quit";
                    option2Label.Text = "Quit";
                    break;
                case 17:
                    outputLabel.Text = "You win the championship in your second year";

                    option1Label.Text = "Quit";
                    option2Label.Text = "Quit";
                    break;
                case 50:
                    outputLabel.Text = " thank you for playing";

                    option1Label.Text = "";
                    option2Label.Text = "";

                    //  Thread.Sleep(9000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
