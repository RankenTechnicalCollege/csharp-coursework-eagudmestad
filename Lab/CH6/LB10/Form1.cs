using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            ShowAnswer();
        }

        private void ShowAnswer()
        {
            string[] eightballPhrases = { "Tomorrow", "Yesterday", "Saturday", "I don't know" };

            if (txtQuestion.Text.Contains("?"))
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 3);
                lblOutput.Text = eightballPhrases[randomNumber];
            }
            else
            {
                lblOutput.Text = eightballPhrases[3];
            }
        }
    }
}
