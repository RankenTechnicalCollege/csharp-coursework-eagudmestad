using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        int[] discountCodes = { 8264, 5679, 6483 };
        float[] discountPercents = { .3f, .2f, .1f };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            float discountPercentage = CheckDiscountCode(txtDiscountCode.Text);

          

            ShowInvoice(int.Parse(txtQuantity.Text), discountPercentage);
        }

        private float CheckDiscountCode(string code)
        {
            float discountPercentage = 0;
            //int codeInt = int.Parse(code);
            int.TryParse(code, out int codeInt);

            for (int i = 0; i < discountCodes.Length; i++)
            {
                if(codeInt == discountCodes[i])
                {
                    discountPercentage = discountPercents[i];
                }
            }
            return discountPercentage;
        }

        private void ShowInvoice(int qty,float discountPercent)
        {
            lblCartDescription.Text = String.Format($"{qty} Shirts @ $13.75 each");

            double subTotal=0, tax=0, total=0;

            if(discountPercent != 0)
            {
                //apply discount
                subTotal = (13.75 * qty) * (1-discountPercent);
                lblDiscountMessage.Text = String.Format($"{discountPercent}% discount applied");
         
            }
            else
            {
                //no discout
                subTotal = (13.75 * qty);
                lblDiscountMessage.Text = "No Discount Applied";
               
            }

            tax = subTotal * .08;
            total = subTotal + tax;

            lblSubtotal.Text = subTotal.ToString("C");
            lblTax.Text = tax.ToString("C");
            lblTotal.Text = total.ToString("C");

            
        }
    }
}
