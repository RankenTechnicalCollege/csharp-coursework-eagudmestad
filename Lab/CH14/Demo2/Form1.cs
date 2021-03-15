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

        private void btnDog_Click(object sender, EventArgs e)
        {
            Animal a1 = new Animal();
            //Creates an instance of the dog class
            Dog d1 = new Dog();

            //Uses the inherited properites to set data into the dog instance
            d1.Age = 10;
            d1.Name = "Fido";
            d1.NumberOfLegs = 4;

            //Use the inherited ToString() method to GET data out of the instance
            lblOutput.Text = d1.ToString();

            
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            //Object Initalizer
            Cat someStrayCat = new Cat() {Name="Garfield",Age=20,NumberOfLegs=3};

            lblOutput.Text = someStrayCat.ToString();
            lblOutput.Text += someStrayCat.Walk();


        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            Mouse houseMouse = new Mouse("skippy", 100, 4, true);
            Mouse m2 = new Mouse("skippy", 25, 4, true);

            lblOutput.Text = houseMouse.Equals(m2).ToString();
        }
    }
}
