using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class Form1 : Form
    {
        //Create an array of Flashcards
        FlashCard[] myCards = new FlashCard[20];
        int index = 5;
        

        public Form1()
        {
            InitializeComponent();
            //Create individual Flashcard objects
            //stored in an array
            myCards[0] = new FlashCard("variable", "A named memory location");
            myCards[1] = new FlashCard("SQL", "Structured Query Language");
            myCards[2] = new FlashCard("HTML", "HyperText Markup Language");
            myCards[3] = new FlashCard("CSS", "Cascading Style Sheet");
            myCards[4] = new FlashCard("VB", "Visual Basic");
        }

        private void btnDefine_Click(object sender, EventArgs e)
        {
            //Search the array for the term provided by the user
            string searchTerm = txtTerm.Text;
            bool found = false;
            for (int i = 0; i < index && found==false; i++)
            {
                if(myCards[i].GetTerm().ToLower().Equals(searchTerm.ToLower()))
                {
                    found = true;
                    lblDefinition.Visible = true;
                    lblDefinition.Text = myCards[i].GetDefinition();
                }
            }

            if(!found)
            {
                lblDefinition.Visible = true;
                txtNewDefinition.Visible = true;
                btnAdd.Visible = true;
                lblDefinition.Text = "I don't know that term yet.  What does it mean?";
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string term = txtTerm.Text;
            string definition = txtNewDefinition.Text;

            if(index < 20)
            { 
                myCards[index] = new FlashCard(term, definition);
                index++;
                //hide controls
                lblDefinition.Visible = false;
                lblDefinition.Text = "";
                btnAdd.Visible = false;
                txtNewDefinition.Visible = false;
                txtNewDefinition.Text = "";
            }
            else
            {
                lblDefinition.Text = "FlashCards Are Full";
            }
        }
    }
}
