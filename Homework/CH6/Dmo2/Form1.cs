using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dmo2
{
    public partial class Form1 : Form
    {

        //class variables
        int count = 0;
        int[] nums = new int[20];
       
        public Form1()
        {
            InitializeComponent();
        }

        //Event hanlder aka calling method
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //local variables
            
            double sum, avg;
            int min, max;
            nums[count] = int.Parse(txtNumberInput.Text);
            CalculateStats(out min, out max, out sum, out avg, nums);

            lblNumbersEntered.Text = String.Format($"{count}/20");
            lblHighest.Text = String.Format($"{max}");
            lblLowest.Text = String.Format($"{min}");
            lblSum.Text = String.Format($"{sum}");
            lblAverage.Text = String.Format($"{avg}");

            if (count == 20)
            {
                btnEnter.Enabled = false;
            }

            //string name = "$Evan";
            //if(name.StartsWith("$ "))
            //{
            //    //do the thing
            //}
            //else if(name.StartsWith("$"))
            //{

            //}
        }

        //Called method
        private void CalculateStats(out int min,out int max,out double sum,out double avg,params int[] numbers)
        {
            count++;
            min = int.MaxValue;
            max = int.MinValue;

            sum = 0;
            for (int i = 0; i < count; i++)
            {
                //accumulate sum
                sum += numbers[i];

                //search for the lowest
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
               
                //search for the largest
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            avg = sum / count;

            
        }
    }
}
