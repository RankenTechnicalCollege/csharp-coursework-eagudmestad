using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRing_Click(object sender, EventArgs e){
            //Create an object
            //aka Create an instance of the cell phone class
            CellPhone my2021Cell = new CellPhone();

            //Benefit of creating classes is that they are reusable
            CellPhone yourCell = new CellPhone();

            //How to CODE a MEMBER of a class
            //start with the object identifier 
            //then a .
            //then the name of the member

            /*  Evan Gudmestad
                Demo Program
                1/12/2021
                This program is for class demonstration
                for the C# programming class of 2021
            */

            //COMMENTS are for DOCUMENTATION
            //Comments are ignored by the compiler 
            //Comments are also ignored when your program is running
            //Comments are also used (commonly) when TROUBLESHOOTING
            my2021Cell.Manufacturer = "OnePlus";
            yourCell.Manufacturer = "Apple";

            lblResult.Text = my2021Cell.Ring();

        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnFocus_Click(object sender, EventArgs e)
        {
            txtLastName.Focus();
        }

      
    }
}
