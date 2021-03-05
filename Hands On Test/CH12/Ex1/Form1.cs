using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class frmPasswordCracker : Form
    {
        List<Password> myPasswords = new List<Password>();
        public frmPasswordCracker()
        {
            InitializeComponent();
            myPasswords.Add(new Password("123456", "e10adc3949ba59abbe56e057f20f883e"));
            myPasswords.Add(new Password("123456789", "25f9e794323b453885f5181f1b624d0b"));
            myPasswords.Add(new Password("Tr0ub4dor&3", "4ece57a61323b52ccffdbef021956754"));
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            string raw = CrackPassword(txtInput.Text);
           
            if(String.IsNullOrEmpty(raw))
            {
                lblOutput.Text = "*FAIL*";
            }
            else
            {
                lblOutput.Text = raw;
            }
        }

        public string CrackPassword(string hash)
        {
            
            string found = null;
            //PAY ATTN TO THIS LOOP!
            for (int i = 0; i < myPasswords.Count; i++)
            {
                //i will equal 0,1,2
                if (myPasswords[i].Hash.Equals(hash))
                {
                    found = myPasswords[i].Raw;
                   //break; //Terminates the loop early
                }
            }
            return found;
        }
    }
}
