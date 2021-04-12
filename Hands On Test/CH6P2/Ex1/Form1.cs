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
    public partial class Form1 : Form
    {
        int numSmallShirts=0, numMediumShirts=0, numLargeShirts = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            AddShirt("S");
            ShowInvoice();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            AddShirt("M");
            ShowInvoice();
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            AddShirt("L");
            ShowInvoice();
        }

        private void AddShirt(string shirtSize)
        {
            switch(shirtSize)
            {
                case "L":
                    numLargeShirts++;
                    break;
                case "M":
                    numMediumShirts++;
                    break;
                case "S":
                    numSmallShirts++;
                    break;
            }

            lblLarge.Text = numLargeShirts.ToString();
            lblMedium.Text = numMediumShirts.ToString();
            lblSmall.Text = numSmallShirts.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOrder();
            
        }

        private void ClearOrder()
        {
            numLargeShirts = 0;
            numMediumShirts = 0;
            numSmallShirts = 0;

            lblLarge.Text = "";
            lblMedium.Text = "";
            lblSmall.Text = "";

            lblSmallCart.Text = "";
            lblMediumCart.Text = "";
            lblLargeCart.Text = "";

            lblSubtotal.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";


        }

        private void ShowInvoice()
        {
            //output # of shirts
            lblSmallCart.Text = String.Format($"{numSmallShirts} Small @ 9.99 each");
            lblMediumCart.Text = String.Format($"{numMediumShirts} Medium @ 10.99 each");
            lblLargeCart.Text = String.Format($"{numLargeShirts} Large @ 11.99 each");

            //calc costs
            double subTotal = (numLargeShirts * 11.99) + (numMediumShirts * 10.99) + (numSmallShirts * 9.99);
            double tax = subTotal * .07;
            double total = subTotal + tax;

            //output costs
            lblSubtotal.Text = subTotal.ToString("C");
            lblTax.Text = tax.ToString("C");
            lblTotal.Text = total.ToString("C");

        }
    }
}
