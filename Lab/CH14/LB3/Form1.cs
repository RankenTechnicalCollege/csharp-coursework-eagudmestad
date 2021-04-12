using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public partial class Form1 : Form
    {
         //List<ShinyCard> shinyCards = new List<ShinyCard>();
        // List<NormalCard> normalCards = new List<NormalCard>();

        List<ICard> myCards = new List<ICard>();
        public Form1()
        {
            InitializeComponent();
           // picImage1.Image = LB3.Properties.Resources.charizard_shiny;
           //Populate all my cards
           //when the form loads you populate all your cards that are possible
           //including all shiny/normal cards
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Random r1 = new Random();

            //Loop 4 times to generate 4 cards and add them to the list
            for (int i = 0; i < 4; i++)
            {
                
                if(r1.Next(1,11) <= 2)
                {
                    //If the random number is 1 or 2 generate a shiny card
                    myCards.Add(new ShinyCard("Charizard", LB3.Properties.Resources.charizard_shiny,1,Color.Gold,Color.Purple));
                }
                else
                {
                    //else generate a normal card
                    myCards.Add(new NormalCard("Charizard", LB3.Properties.Resources.charizard,0));
                }
            }


            myCards[0].ShowCard(picImage1, lblCaption1);
            myCards[1].ShowCard(picImage2, lblCaption2);
            myCards[2].ShowCard(picImage3, lblCaption3);
            myCards[3].ShowCard(picImage4, lblCaption4);

            myCards.Clear();
            
        }
    }
}
