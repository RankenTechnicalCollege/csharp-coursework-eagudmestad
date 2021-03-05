using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Creates an instance of the bat class
            //called wiffleBallBat
            //The Bat() constructor sets all
            //default values for the instance fields
            //to 0, 0.0, false, null etc
            Bat wiffleBallBat = new Bat();
            string brand = txtBrand.Text;
            double weight = double.Parse(txtWeight.Text);
            wiffleBallBat.setBatBrand(brand);
            wiffleBallBat.setBatWeight(weight);
            lblResult.Text = String.Format($"Your bat has a brand of {wiffleBallBat.getBatBrand()} and a weight of {wiffleBallBat.getBatWeight()}");

        }
    }
}
