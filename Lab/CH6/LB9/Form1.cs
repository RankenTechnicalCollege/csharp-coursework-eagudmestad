using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Parallel Arrays
        string[] accountNumbers = { "123-456-789", "987-654-321" };
        string[] pins = { "1234", "9876" };
        string[] userNames = { "Mr. Smith", "Mr. Gudmestad" };
        double[] balances = { 10000, 1000 };

        int foundPosition; //-1 assumes invalid credentials

        //Event Handlers
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(txtAccountNumber.Text, txtPin.Text);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            MakeDeposit(double.Parse(txtDeposit.Text));
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            MakeWithdrawl(double.Parse(txtWithdrawl.Text));
        }



        //Custom Methods
        private void Login(string inputAccountNumber, string inputPin)
        {
            Logout();

            //string inputAccountNumber = txtAccountNumber.Text;
            //string inputPin = txtPin.Text;
            for (int i = 0; i < accountNumbers.Length; i++)
            {
                if (accountNumbers[i] == inputAccountNumber && pins[i] == inputPin)
                {
                    //user credentials valid
                    foundPosition = i;
                }
            }

            if (foundPosition == -1)
            {
                lblWelcome.Text = "UserName or Password invalid.  Please try again";
                lblAccountBalance.Text = "";
            }
            else
            {
                lblWelcome.Text = String.Format($"Welcome {userNames[foundPosition]}!");
                lblAccountBalance.Text = String.Format($"Your account balance is {balances[foundPosition]:C}");
                grpTransactions.Visible = true;
            }
        }

        private void Logout()
        {
            //empty label controls
            lblAccountBalance.Text = "";
            lblWelcome.Text = "";

            //hide transaction controls and reset found user to not found
            grpTransactions.Visible = false;
            foundPosition = -1;

            txtWithdrawl.Text = "";
            txtDeposit.Text = "";
        }

        private void MakeDeposit(double depositAmount)
        {
            balances[foundPosition] += depositAmount;
            lblAccountBalance.Text = String.Format($"Your account balance is {balances[foundPosition]:C}");
        }

        private void MakeWithdrawl(double withdrawAmount)
        {
            balances[foundPosition] -= withdrawAmount;
            lblAccountBalance.Text = String.Format($"Your account balance is {balances[foundPosition]:C}");
        }

      
    }
}
