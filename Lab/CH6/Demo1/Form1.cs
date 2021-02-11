using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        int numRounds = 0;
        int numPlayerWins = 0;
        int numPcWins = 0;

        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnRock_Click(object sender, EventArgs e)
        {
            numRounds++;
            //pcPick of 1 = rock
            //pcPick of 2 = paper
            //pcPick of 3 = scissors
            int pcPick = GenerateRandomNumber();
            int result = DetermineRoundWinner(pcPick, 1);
            UpdateLabels(result);
            DetermineGameWinner();

        }

        

        private void btnPaper_Click(object sender, EventArgs e)
        {
            numRounds++;
            int pcPick = GenerateRandomNumber();
            int result = DetermineRoundWinner(pcPick, 2);
            UpdateLabels(result);
            DetermineGameWinner();

        }


        private void btnScissors_Click(object sender, EventArgs e)
        {
            numRounds++;
            int pcPick = GenerateRandomNumber();
            int result = DetermineRoundWinner(pcPick, 3);
            UpdateLabels(result);
            DetermineGameWinner();
        }

        private int GenerateRandomNumber()
        {
            Random rando = new Random();
            return rando.Next(1,4);
        }

        private int DetermineRoundWinner(int pcPick,int userPick)
        {
            //return 0 if player wins
            //return 1 if pc wins
            //return 2 if tie
            
            int winner;
            //1 is rock
            //2 is paper
            //3 is scissors

            if(pcPick ==1) //pc is rock
            {
                lblPcPick.Text = "Computer picked rock";
                if(userPick==1)
                {
                    winner = 2;
                }
                else if(userPick ==2)
                {
                    winner = 0;
                  
                }
                else
                {
                    winner = 1;
                }
            }
            else if(pcPick ==2) //pc is paper
            {
                lblPcPick.Text = "PC Picked Paper";
                if (userPick == 1)
                {
                    winner = 1;
                    
                }
                else if (userPick == 2)
                {
                    winner = 2;
                }
                else
                {
                    winner = 0;
                   
                }
            }
            else //pc is scissors
            {
                lblPcPick.Text = "PC Picked Scissors";
                if (userPick == 1)
                {
                    winner = 0;
                   
                }
                else if (userPick == 2)
                {
                    winner = 1;
                   
                }
                else
                {
                    winner = 2;
                }
            }
            return winner;
        }

        private void UpdateLabels(int result)
        {
            lblTie.Text = "";
            if (result == 0)
            {
                //player wins
                numPlayerWins++;
                lblPlayerScore.Text = numPlayerWins.ToString();
                lblPcScore.Text = numPcWins.ToString();
            }
            else if (result == 1)
            {
                //pc wins
                numPcWins++;
                lblPlayerScore.Text = numPlayerWins.ToString();
                lblPcScore.Text = numPcWins.ToString();
            }
            else
            {
                //tie
                lblPlayerScore.Text = numPlayerWins.ToString();
                lblPcScore.Text = numPcWins.ToString();
                lblTie.Text = "It was a tie";

            }
        }

        private void DetermineGameWinner()
        {
            if (numRounds == 3)
            {
                if (numPcWins > numPlayerWins)
                {
                    lblWinner.Text = "After 3 rounds, the PC wins!";
                }
                else if (numPlayerWins > numPcWins)
                {
                    lblWinner.Text = "After 3 rounds, the player wins!";
                }
                else
                {
                    lblWinner.Text = "After 3 rounds, it's a tie!";
                }
            }
        }
    }
}
