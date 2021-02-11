using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB8
{
    public partial class frmCustomDesk : Form
    {
        public frmCustomDesk()
        {
            InitializeComponent();
        }

        //Event Handler
        private void btnEstimate_Click(object sender, EventArgs e)
        {
            string woodType = GetWood();
            int numDrawers = GetDrawers();

            lblWoodCost.Text = CalculateWoodCost(woodType).ToString("C");
            lblDrawerCost.Text = CalculateDrawerCost(numDrawers).ToString("C");

            lblTotalCost.Text = CalculateTotalCost(woodType, numDrawers).ToString("C");
        }

        private string GetWood()
        {
            string woodAbbreviationType = txtWoodType.Text.ToLower();
            string woodType = "";
            
            switch(woodAbbreviationType)
            {
                case "m":
                    woodType = "mahogany";
                    break;
                case "o":
                    woodType = "oak";
                    break;
                case "p":
                    woodType = "pine";
                    break;
                default:
                    woodType = "other";
                    break;
            }

            return woodType;
        }

        private int GetDrawers()
        {
            return int.Parse(txtNumDrawers.Text);
        }

        private double CalculateWoodCost(string woodType)
        {
            double woodCost = 0;

            switch(woodType)
            {
                case "pine":
                    woodCost = 100;
                    break;
                case "oak":
                    woodCost = 140;
                    break;
                default:
                    woodCost = 180;
                    break;
            }
            return woodCost;
        }

        private double CalculateDrawerCost(int numDrawers)
        {
            return numDrawers * 30;
        }

        private double CalculateTotalCost(string woodType, int numDrawers)
        {
            return CalculateWoodCost(woodType) + CalculateDrawerCost(numDrawers);
        }
    }
}
