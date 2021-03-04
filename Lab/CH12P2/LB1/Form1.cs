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
    public partial class frmFoodOrder : Form
    {
        Order anOrder;
        double grandTotal = 0;
        public frmFoodOrder()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;

            if((chkSundae.Checked || chkSoda.Checked) && !String.IsNullOrEmpty(userName))
            {
                bool isValid = true;
                //create the order
                lblNameOrFoodError.Visible = false;
                
                //Creates an instance of an Order
                anOrder = new Order(userName, chkSundae.Checked, chkSoda.Checked);

                if(chkSundae.Checked)
                { 
                    if(chkSprinkles.Checked && chkNuts.Checked && chkSyrup.Checked)
                    {
                        //error message
                        lblToppingsError.Visible = true;
                        isValid = false;
                    }
                    else
                    {
                        //Add Toppings
                        lblToppingsError.Visible = false;
                        if(chkSprinkles.Checked) anOrder.Sundae.AddTopping(SundaeTopping.SPRINKLES);
                        if (chkNuts.Checked) anOrder.Sundae.AddTopping(SundaeTopping.NUTS);
                        if (chkSyrup.Checked) anOrder.Sundae.AddTopping(SundaeTopping.CHOCOLATE_SYRUP);
                    }
                }

                if(chkSoda.Checked)
                { 
                    if (chkLime.Checked && chkPeach.Checked || chkLime.Checked && chkMango.Checked || chkMango.Checked && chkPeach.Checked)
                    {
                        //Too many mixins selected
                        lblMixinError.Visible = true;
                        isValid = false;
                    }
                    else
                    {
                        lblMixinError.Visible = false;
                        //Add mixins to soda
                        if (chkLime.Checked) anOrder.Soda.AddFlavor(SodaFlavor.LIME);
                        if (chkPeach.Checked) anOrder.Soda.AddFlavor(SodaFlavor.PEACH);
                        if (chkMango.Checked) anOrder.Soda.AddFlavor(SodaFlavor.MANGO);
                    }
                }
                //Display Output
                if (isValid)
                {
                    //output total price
                    grandTotal += anOrder.Price;
                    lblTotalPrice.Text = grandTotal.ToString("C");

                    //output orders name
                    rtbOutput.Text += anOrder.Name;
                    rtbOutput.Text += "\n----------------\n";

                    if (anOrder.Soda == null)
                    {
                        DisplaySundae();
                        rtbOutput.Text += "\n";
                    }
                    else if (anOrder.Sundae == null)
                    {
                        DisplaySoda();
                        rtbOutput.Text += "\n";
                    }
                    else
                    {
                        DisplaySundae();
                        DisplaySoda();
                        rtbOutput.Text += "\n";
                    }
                }
            }
            else
            {
                //error message
                lblNameOrFoodError.Visible = true;
            }
        }

        private void DisplaySundae()
        {
            //output Sundae info
            rtbOutput.Text += "Sundae - ";

            //Read the # of toppings
            int toppingCount = anOrder.Sundae.ToppingCount;

            if (toppingCount == 0)
            {
                rtbOutput.Text += anOrder.Sundae.GetTopping(0) + " - ";
            }
            else
            {
                for (int i = 0; i < toppingCount; i++)
                {
                    rtbOutput.Text += anOrder.Sundae.GetTopping(i) + " ";
                }
            }
            rtbOutput.Text += anOrder.Sundae.Price.ToString("C") + "\n";
        }

        private void DisplaySoda()
        {
            //output Soda info
            rtbOutput.Text += "Soda - ";

            //Read the # of Mixins
            rtbOutput.Text += anOrder.Soda.Flavor + "-";

            rtbOutput.Text += anOrder.Soda.Price.ToString("C") + "\n";
        }
        private void chkSundae_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSundae.Checked)
            {
                grpSundaeToppings.Visible = true;
            }
            else
            {
                grpSundaeToppings.Visible = false;
            }
        }

        private void chkSoda_CheckedChanged(object sender, EventArgs e)
        {
            grpDrinkMixins.Visible = chkSoda.Checked ? true : false;
        }
    }
}
