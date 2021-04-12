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
        //Upcasting
        //Cast a child object into a parent
        List<Letter> letterList = new List<Letter>();
       // List<CertifiedLetter> certifiedLetters = new List<CertifiedLetter>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTrackingNumber.Text))
            {
                letterList.Add(new Letter(txtRecipient.Text, DateTime.Parse(txtSentDate.Text)));
            }
            else
            {
                letterList.Add(new CertifiedLetter(txtRecipient.Text, DateTime.Parse(txtSentDate.Text), txtTrackingNumber.Text));
            }
            //Append the last letter to the TOP of the RTB
            string currentRtbText = rtbResult.Text;

            //Add the last item added to the list to the rich textbox
            rtbResult.Text = letterList[letterList.Count - 1].ToString() + "\n" +currentRtbText;
        }
    }
}
