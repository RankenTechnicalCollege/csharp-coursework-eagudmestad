using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB7
{
    public partial class frmCreditCardMasker : Form
    {
        //method called The Constructor
        public frmCreditCardMasker()
        {
            InitializeComponent();
        }

        private void btnMask_Click(object sender, EventArgs e)
        {
            lblMasked.Text = MaskedNumber(txtCCNumber.Text, "#", 4);
        }

        private string MaskedNumber(string unmasked,string replacementChar, int numDigitsToPreserve)
        {
            string masked = "";

            //uses the substring method to read the last 4 digits of the CC number
            string lastFour = unmasked.Substring(unmasked.Length - 4, 4);

            //iterates through all the digits besides the last 4 and replaces numbers & letters with #
            for (int i = 0; i < unmasked.Length-numDigitsToPreserve; i++)
            {
                if(unmasked[i] == ' ')
                {
                    masked += " ";
                }
                else if(unmasked[i] == '-')
                {
                    masked += "-";
                }
                else if(Char.IsDigit(unmasked[i]))
                {
                    masked += replacementChar;
                }
                else if(char.IsLetter(unmasked[i]))
                {
                    masked += replacementChar;
                }
            }

            masked += lastFour;

            return masked;
        }
    }
}
