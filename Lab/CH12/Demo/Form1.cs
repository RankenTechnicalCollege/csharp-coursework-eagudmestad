using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        //Instantiates a list of type OculusRift
        List<OculusRift> myRifts = new List<OculusRift>();
        public Form1()
        {
            InitializeComponent();
            myRifts.Add(new OculusRift("blue","x"));
            myRifts.Add(new OculusRift("red", "y"));
            myRifts.Add(new OculusRift("orange", "z"));
        }

        private void btnAddRift_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            bool found = false;
            //Search for version of the rift
            for (int i = 0; i < myRifts.Count; i++)
            {
                if(txtVersion.Text == myRifts[i].Version)
                {
                    //If it exists, update the color
                    myRifts[i].Color = txtColor.Text;
                    found = true;
                }
            }

            if(!found)
            {
                //else create a new rift and add it to the list
                myRifts.Add(new OculusRift(txtColor.Text, txtVersion.Text));
            }

            foreach (OculusRift rift in myRifts)
            {
                lblResult.Text += String.Format($"My {rift.Color} Oculus Rift's version is {rift.Version} and cost me {rift.Price}\n");
            }




            //Create our object
            //OculusRift myRift = new OculusRift(txtColor.Text, txtVersion.Text);
            //myRifts.Add(myRift);
            //lblResult.Text = String.Format($"My {myRifts[3].Color} Oculus Rift's version is {myRifts[3].Version} and cost me {myRifts[3].Price}");
        }
    }
}
