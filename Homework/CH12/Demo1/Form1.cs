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
    //Objects in C#
    //Why is this important?
    //Types of coding methodologies
    //Procedural -- Object Oriented -- Functional 

    //OOP is still a dominate coding methodology today
    //What were learning is the fundamentals of Objects
    //or Object Oriented Principals

    //Core Concepts in OOP is Code Reuse!!!
    //As an example, we learned to code a method
    //and then call that method many times.
    
    
    //A way to tie in behaviors and data to a thing (object)
    //A class is a blueprint of an object
    //an object is a digital representation of a real world THING
    //objects have 2 components
    //a method is a behavior

    //Attributes

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSellCoffee_Click(object sender, EventArgs e)
        {
            //when you USE the class you create an object
            CoffeeCup myCoffee = new CoffeeCup(); //creates an object
            CoffeeCup yourCoffee = new CoffeeCup();
            //default constructor sets all your instance fields
            //to default values - 0,0.0,false, null
            //Data Type is CoffeeCup
            //myCoffee is the identifier
            //= assignment operator
            //new is the keyword that creates an instance of an class
            //CoffeeCup(); - A method call - this method is called the constructor
            myCoffee.FillCupWithEightOunces();
            myCoffee.Sip();
            myCoffee.Sip();
            yourCoffee.FillCupWithEightOunces();
            yourCoffee.Sip();
            lblOunces.Text = String.Format($"Ounces of my Coffee: {myCoffee.CheckOuncesRemaining()}\n");
            lblOunces.Text += String.Format($"Ounces of your Coffee: {yourCoffee.CheckOuncesRemaining()}");
        }

        //currentOuncesOfCoffee variable is not DIRECTLY accessible
        //This provides a layer of security to our data
        //Instead, we can only modify the data through OUR METHODS! 
    }
}
