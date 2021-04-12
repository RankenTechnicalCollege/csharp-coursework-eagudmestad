using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = textBox1.Text;
            DateTime date1 = DateTime.Parse(date);

            string otherDate = textBox2.Text;
            DateTime date2 = DateTime.Parse(otherDate);

            string searchDateString = "3/5/2021";
            DateTime searchDate = DateTime.Parse(searchDateString);


            if(searchDate >= date1 && searchDate < date2)
            {
                //in the range
                label1.Text = "in range";
            }
            else
            {
                //out of range
                label1.Text = "out of range";
            }
            
        }
    }
}
