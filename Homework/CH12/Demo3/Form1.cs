using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Create a hockey player w the default constructor
            HockeyPlayer player1 = new HockeyPlayer();
            player1.SetPlayerName("Vladamir Tarasenko");
            lblResult.Text = player1.GetPlayerName();
            
            //You can use constructors to set instance field values
            //when the object is created
            HockeyPlayer player2 = new HockeyPlayer("Jordan Binnington");
            lblResult.Text += player2.GetPlayerName();

            HockeyPlayer player3 = new HockeyPlayer("Wayne Gretsky",99);
            lblResult.Text += player3.GetPlayerName() + player3.GetPlayerNumber();


            HockeyPlayer[] redWings = new HockeyPlayer[30];

            for (int i = 0; i < redWings.Length; i++)
            {
                redWings[i] = new HockeyPlayer();
            }

            redWings[0].SetPlayerName("some guy");
            redWings[0].SetPlayerNumber(30);

            redWings[1].SetPlayerName("other guy");
            redWings[1].SetPlayerNumber(31);

            redWings[2].Name = "some gal";
            

        }
    }
}
