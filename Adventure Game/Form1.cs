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
                page = 50;
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
                    option2Label.Text = "Try again";
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

                    option1Label.Text = "";
                    option2Label.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "";

                    option1Label.Text = "";
                    option2Label.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "";

                    option1Label.Text = "";
                    option2Label.Text = "";
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

        }
    }
}
