using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class CoffeeCup
    {
        //Classes are made up of 2 things

        //data - Are the attributes of the class
        //access modifiers - control scope of the data

        //Instance Fields
        //Methods are used to insert, update, delete data
        //from our fields
        //Data Hiding is an object oriented principle
        //Data hiding means setting our instance fields
        //to private and only enabling the USERS of our class
        //to modify or access the data through METHODS (public)
        private string cupColor;
        private int currentOuncesOfCoffee;
        
        //methods - Are the behaviors of the class
        //often times, our methods modify OR access
        //our instance fields
        //filled with ounces
        public void FillCupWithEightOunces()
        {
            currentOuncesOfCoffee += 8;
        }
        //be consumed from
        public void Sip()
        {
            currentOuncesOfCoffee -= 3;
        }

        //read the variable
        public int CheckOuncesRemaining()
        {
            //With data hiding, the instance fields
            //are marked as private which makes them secure.
            //only with CONTROLED ACCESS through the methods
            //can a piece of data be revealed
            //if user has permission return the number of oz
            //otherwise don't give them access
            return currentOuncesOfCoffee;
        }
    }
}
