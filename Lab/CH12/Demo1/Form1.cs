using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateChair_Click(object sender, EventArgs e)
        {
            //Instantiate a Chair?
            Chair myChair = new Chair();
            Chair yourChair = new Chair("purple", 1);
            Chair anotherOne = new Chair();
            anotherOne.ChairColor = "purble";
            anotherOne.SetNumWheels(6);

            //local variables
            string color = txtChairColor.Text;
            int numWheels = int.Parse(txtNumOfWheels.Text);

            //Call the mutators to insert the data into the instance fields
            //Object name . notation method name
            myChair.SetChairColor(color);
            myChair.SetNumWheels(numWheels);
            //Does not enforce data hiding or data validation at the middle tier
            myChair._chairHeight = 123;

            //Put the data out with the accessors aka the getters
            lblResult.Text = string.Format($"My chair is {myChair.ChairColor} and has {myChair.GetNumOfWheels()} wheels");
            lblResult.Text += string.Format($"\nYour chair is {yourChair.ChairColor} and has {yourChair.GetNumOfWheels()} wheels");
            lblResult.Text += string.Format($"\nAnother chair is {anotherOne.ChairColor} and has {anotherOne.GetNumOfWheels()} wheels");



        }
    }
}
