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
        //Can you explain passing by value and passing by reference?
        //pass by value or reference



        public Form1()
        {
            InitializeComponent();
        }

        //Event Handler
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //3 ints
            DoSomething(1, 2, 3);

            //10 ints
            DoSomething(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            //any number of ints can be passed into that array
        }

        
        //params array -- allows this method to accept a variable number of ints
        private void DoSomething(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                lblResult.Text += numbers[i];
            }
            
        }
    }
}
