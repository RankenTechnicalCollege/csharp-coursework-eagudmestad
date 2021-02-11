using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Event Handler
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //read data input from the form to pass into the CalcTotalArea method.
            double area = CalculateTotalArea(double.Parse(txtLength.Text), double.Parse(txtWidth.Text));

            //pass the area into the CaclPaintEstimate and store result of math in a variable
            double cost = CalculatePaintEstimate(area);

            //output
            lblArea.Text = area.ToString("f1");
            lblTotalCost.Text = cost.ToString("C");
        }

        //custom method
        private double CalculateTotalArea(double length,double width)
        {
            //math (L * H * 2) + (W * H * 2)
            //return the area to the event handler
            return (length * 9 * 2) + (width * 9 * 2);
        }

        private double CalculatePaintEstimate(double area)
        {
            //return the total cost
            //total cost is area * 6;
            return area * 6;
        }
    }
}
